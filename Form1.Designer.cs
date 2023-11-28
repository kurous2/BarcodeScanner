namespace BarcodeScanner;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.btnCapture = new System.Windows.Forms.Button();
        this.pictBoxCamera = new System.Windows.Forms.PictureBox();
        this.lblCamera = new System.Windows.Forms.Label();
        this.cbxCamera = new System.Windows.Forms.ComboBox();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.timerCapture = new System.Timers.Timer();
        ((System.ComponentModel.ISupportInitialize)(this.pictBoxCamera)).BeginInit();
        this.SuspendLayout();
        //
        // btnCapture
        //
        this.btnCapture.Text =  "Capture";
        this.btnCapture.Location = new System.Drawing.Point(28,316);
        this.btnCapture.Click += btnCapture_Click;
        //
        // pictBoxCamera
        //
        this.pictBoxCamera.TabIndex = 1;
        this.pictBoxCamera.Text =  "PictureBox1";
        this.pictBoxCamera.Location = new System.Drawing.Point(20,56);
        this.pictBoxCamera.Size = new System.Drawing.Size(424,244);
        //
        // lblCamera
        //
        this.lblCamera.AutoSize =  true;
        this.lblCamera.Text =  "Camera";
        this.lblCamera.Location = new System.Drawing.Point(44,24);
        this.lblCamera.Size = new System.Drawing.Size(48,15);
        this.lblCamera.TabIndex = 2;
        //
        // cbxCamera
        //
        this.cbxCamera.DropDownWidth = 304;
        this.cbxCamera.ItemHeight = 15;
        this.cbxCamera.Location = new System.Drawing.Point(100,20);
        this.cbxCamera.Size = new System.Drawing.Size(304,23);
        this.cbxCamera.TabIndex = 3;
        //
        // txtResult
        //
        this.txtResult.Location = new System.Drawing.Point(108,316);
        this.txtResult.Size = new System.Drawing.Size(332,23);
        this.txtResult.TabIndex = 4;
        //
        // Timer
        //
        this.timerCapture.Interval = 1000;
        this.timerCapture.Elapsed += timerCapture_Elapsed;
                //
     //
     // form
     //
        this.Size = new System.Drawing.Size(480,400);
        this.Text =  "QR Code Scanner";
        this.Load += Form1_Load;
        this.FormClosing += Form1_FormClosing;
        this.Controls.Add(this.btnCapture);
        this.Controls.Add(this.pictBoxCamera);
        this.Controls.Add(this.lblCamera);
        this.Controls.Add(this.cbxCamera);
        this.Controls.Add(this.txtResult);
        ((System.ComponentModel.ISupportInitialize)(this.pictBoxCamera)).EndInit();
        this.ResumeLayout(false);
    } 

    #endregion 

    private System.Windows.Forms.Button btnCapture;
    private System.Windows.Forms.PictureBox pictBoxCamera;
    private System.Windows.Forms.Label lblCamera;
    private System.Windows.Forms.ComboBox cbxCamera;
    private System.Windows.Forms.TextBox txtResult;
    private System.Timers.Timer timerCapture;
}

