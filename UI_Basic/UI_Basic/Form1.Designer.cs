namespace UI_Basic
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_COM = new System.Windows.Forms.TextBox();
            this.textBox_BaudRate = new System.Windows.Forms.TextBox();
            this.label_COM = new System.Windows.Forms.Label();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_ScanningInProgress = new System.Windows.Forms.Label();
            this.label_CheckConnection = new System.Windows.Forms.Label();
            this.button_StartStopScanning = new System.Windows.Forms.Button();
            this.textBox_Filename = new System.Windows.Forms.TextBox();
            this.label_Filename = new System.Windows.Forms.Label();
            this.button_exportScan = new System.Windows.Forms.Button();
            this.label_exportInfo = new System.Windows.Forms.Label();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_XYZimport = new System.Windows.Forms.Button();
            this.textBox_XYZimport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_COM
            // 
            this.textBox_COM.Location = new System.Drawing.Point(114, 12);
            this.textBox_COM.Name = "textBox_COM";
            this.textBox_COM.Size = new System.Drawing.Size(100, 20);
            this.textBox_COM.TabIndex = 0;
            this.textBox_COM.Text = "COM3";
            // 
            // textBox_BaudRate
            // 
            this.textBox_BaudRate.Location = new System.Drawing.Point(114, 38);
            this.textBox_BaudRate.Name = "textBox_BaudRate";
            this.textBox_BaudRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_BaudRate.TabIndex = 1;
            this.textBox_BaudRate.Text = "115200";
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Location = new System.Drawing.Point(35, 15);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(73, 13);
            this.label_COM.TabIndex = 2;
            this.label_COM.Text = "Choose COM:";
            this.label_COM.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Location = new System.Drawing.Point(35, 41);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(61, 13);
            this.label_BaudRate.TabIndex = 3;
            this.label_BaudRate.Text = "Baud Rate:";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(220, 10);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(93, 23);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_ScanningInProgress
            // 
            this.label_ScanningInProgress.AutoSize = true;
            this.label_ScanningInProgress.ForeColor = System.Drawing.Color.Red;
            this.label_ScanningInProgress.Location = new System.Drawing.Point(220, 191);
            this.label_ScanningInProgress.Name = "label_ScanningInProgress";
            this.label_ScanningInProgress.Size = new System.Drawing.Size(72, 13);
            this.label_ScanningInProgress.TabIndex = 5;
            this.label_ScanningInProgress.Text = "Not Scanning";
            // 
            // label_CheckConnection
            // 
            this.label_CheckConnection.AutoSize = true;
            this.label_CheckConnection.ForeColor = System.Drawing.Color.Red;
            this.label_CheckConnection.Location = new System.Drawing.Point(220, 41);
            this.label_CheckConnection.Name = "label_CheckConnection";
            this.label_CheckConnection.Size = new System.Drawing.Size(78, 13);
            this.label_CheckConnection.TabIndex = 6;
            this.label_CheckConnection.Text = "Not connected";
            // 
            // button_StartStopScanning
            // 
            this.button_StartStopScanning.Location = new System.Drawing.Point(38, 186);
            this.button_StartStopScanning.Name = "button_StartStopScanning";
            this.button_StartStopScanning.Size = new System.Drawing.Size(176, 23);
            this.button_StartStopScanning.TabIndex = 7;
            this.button_StartStopScanning.Text = "Start Scanning";
            this.button_StartStopScanning.UseVisualStyleBackColor = true;
            this.button_StartStopScanning.Click += new System.EventHandler(this.button_StartStopScanning_Click);
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Location = new System.Drawing.Point(114, 122);
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.Size = new System.Drawing.Size(100, 20);
            this.textBox_Filename.TabIndex = 8;
            this.textBox_Filename.Text = "distances.txt";
            // 
            // label_Filename
            // 
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(35, 125);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(52, 13);
            this.label_Filename.TabIndex = 9;
            this.label_Filename.Text = "Filename:";
            // 
            // button_exportScan
            // 
            this.button_exportScan.Location = new System.Drawing.Point(220, 120);
            this.button_exportScan.Name = "button_exportScan";
            this.button_exportScan.Size = new System.Drawing.Size(93, 23);
            this.button_exportScan.TabIndex = 10;
            this.button_exportScan.Text = "Export";
            this.button_exportScan.UseVisualStyleBackColor = true;
            this.button_exportScan.Click += new System.EventHandler(this.button_exportScan_Click);
            // 
            // label_exportInfo
            // 
            this.label_exportInfo.AutoSize = true;
            this.label_exportInfo.Location = new System.Drawing.Point(35, 106);
            this.label_exportInfo.Name = "label_exportInfo";
            this.label_exportInfo.Size = new System.Drawing.Size(134, 13);
            this.label_exportInfo.TabIndex = 11;
            this.label_exportInfo.Text = "Export last scan data to file";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Disconnect.Location = new System.Drawing.Point(220, 64);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(93, 23);
            this.button_Disconnect.TabIndex = 12;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_XYZimport
            // 
            this.button_XYZimport.Location = new System.Drawing.Point(220, 149);
            this.button_XYZimport.Name = "button_XYZimport";
            this.button_XYZimport.Size = new System.Drawing.Size(93, 23);
            this.button_XYZimport.TabIndex = 13;
            this.button_XYZimport.Text = "Export";
            this.button_XYZimport.UseVisualStyleBackColor = true;
            this.button_XYZimport.Click += new System.EventHandler(this.button_XYZimport_Click);
            // 
            // textBox_XYZimport
            // 
            this.textBox_XYZimport.Location = new System.Drawing.Point(114, 152);
            this.textBox_XYZimport.Name = "textBox_XYZimport";
            this.textBox_XYZimport.Size = new System.Drawing.Size(100, 20);
            this.textBox_XYZimport.TabIndex = 14;
            this.textBox_XYZimport.Text = "distancesXYZ.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 288);
            this.Controls.Add(this.textBox_XYZimport);
            this.Controls.Add(this.button_XYZimport);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.label_exportInfo);
            this.Controls.Add(this.button_exportScan);
            this.Controls.Add(this.label_Filename);
            this.Controls.Add(this.textBox_Filename);
            this.Controls.Add(this.button_StartStopScanning);
            this.Controls.Add(this.label_CheckConnection);
            this.Controls.Add(this.label_ScanningInProgress);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label_BaudRate);
            this.Controls.Add(this.label_COM);
            this.Controls.Add(this.textBox_BaudRate);
            this.Controls.Add(this.textBox_COM);
            this.Name = "Form1";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_COM;
        private System.Windows.Forms.TextBox textBox_BaudRate;
        private System.Windows.Forms.Label label_COM;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_ScanningInProgress;
        private System.Windows.Forms.Label label_CheckConnection;
        private System.Windows.Forms.Button button_StartStopScanning;
        private System.Windows.Forms.TextBox textBox_Filename;
        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.Button button_exportScan;
        private System.Windows.Forms.Label label_exportInfo;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_XYZimport;
        private System.Windows.Forms.TextBox textBox_XYZimport;
    }
}

