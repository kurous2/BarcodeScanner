namespace BarcodeScanner;

using System.Windows.Forms.VisualStyles;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Timers;


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    VideoCaptureDevice captureDevice;
    FilterInfoCollection filterInfoCollection;
    private CancellationTokenSource cancellationTokenSource;

   private void Form1_Load(object sender, EventArgs e){
        filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        foreach(FilterInfo filterInfo in filterInfoCollection)
            cbxCamera.Items.Add(filterInfo.Name);
        cbxCamera.SelectedIndex = 0;
        cancellationTokenSource = new CancellationTokenSource();
    }

    private void btnCapture_Click(System.Object? sender, System.EventArgs e){
        Task.Run(() => CaptureVideo(cancellationTokenSource.Token));
    }

    private void CaptureVideo(CancellationToken cancellationToken)
    {
        captureDevice = new VideoCaptureDevice(filterInfoCollection[cbxCamera.SelectedIndex].MonikerString);
        captureDevice.NewFrame += CameraCapture_NewFrame;
        captureDevice.Start();
        timerCapture.Start();

        DateTime startTime = DateTime.Now;

        //prevent infinite loop, locking thread on video capture qrcode
        while (!cancellationToken.IsCancellationRequested && (DateTime.Now - startTime).TotalSeconds <= 60)
        {
    
        }

        captureDevice.SignalToStop();
        captureDevice.WaitForStop();
    }
    private void CameraCapture_NewFrame(object sender, NewFrameEventArgs eventArgs){
        pictBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        // throw new NotImplementedException();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e){
        // if(captureDevice.IsRunning)
        if (captureDevice != null && captureDevice.IsRunning)
        {
            cancellationTokenSource?.Cancel();
            captureDevice.SignalToStop();
            captureDevice.WaitForStop();
        }
    }
    private void Form1_FormClosed(object sender, FormClosedEventArgs e){
        captureDevice.Stop();
    }
    private void timerCapture_Elapsed(object sender, ElapsedEventArgs e){
        if (pictBoxCamera.Image != null)
        {
            ZXing.IBarcodeReader barcodeReader = new ZXing.BarcodeReader();
            Result result = barcodeReader.Decode((Bitmap)pictBoxCamera.Image);
            if(result!=null){
                txtResult.Text = result.Text.ToString();
            }
        }
    }
}
