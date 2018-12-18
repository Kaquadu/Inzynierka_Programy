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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.textBox_XYZexport = new System.Windows.Forms.TextBox();
            this.textBox_XYZimport = new System.Windows.Forms.TextBox();
            this.label_FromFileXYZ = new System.Windows.Forms.Label();
            this.label_ToFIleXYZ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_Xoffset = new System.Windows.Forms.TextBox();
            this.textBox_Yoffset = new System.Windows.Forms.TextBox();
            this.textBox_Zoffset = new System.Windows.Forms.TextBox();
            this.label_Xoffset = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_setOffset = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_IPAdress = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_IPAdress = new System.Windows.Forms.TextBox();
            this.label_ToFileDXF = new System.Windows.Forms.Label();
            this.label_FromFileDXF = new System.Windows.Forms.Label();
            this.textBox_DXFimport = new System.Windows.Forms.TextBox();
            this.textBox_DXFexport = new System.Windows.Forms.TextBox();
            this.button_DXFparser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_COM
            // 
            this.textBox_COM.Location = new System.Drawing.Point(203, 18);
            this.textBox_COM.Name = "textBox_COM";
            this.textBox_COM.Size = new System.Drawing.Size(100, 20);
            this.textBox_COM.TabIndex = 0;
            this.textBox_COM.Text = "COM3";
            // 
            // textBox_BaudRate
            // 
            this.textBox_BaudRate.Location = new System.Drawing.Point(203, 44);
            this.textBox_BaudRate.Name = "textBox_BaudRate";
            this.textBox_BaudRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_BaudRate.TabIndex = 1;
            this.textBox_BaudRate.Text = "115200";
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Location = new System.Drawing.Point(124, 21);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(73, 13);
            this.label_COM.TabIndex = 2;
            this.label_COM.Text = "Choose COM:";
            this.label_COM.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Location = new System.Drawing.Point(124, 47);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(61, 13);
            this.label_BaudRate.TabIndex = 3;
            this.label_BaudRate.Text = "Baud Rate:";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(309, 16);
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
            this.label_ScanningInProgress.Location = new System.Drawing.Point(309, 105);
            this.label_ScanningInProgress.Name = "label_ScanningInProgress";
            this.label_ScanningInProgress.Size = new System.Drawing.Size(72, 13);
            this.label_ScanningInProgress.TabIndex = 5;
            this.label_ScanningInProgress.Text = "Not Scanning";
            // 
            // label_CheckConnection
            // 
            this.label_CheckConnection.AutoSize = true;
            this.label_CheckConnection.ForeColor = System.Drawing.Color.Red;
            this.label_CheckConnection.Location = new System.Drawing.Point(309, 47);
            this.label_CheckConnection.Name = "label_CheckConnection";
            this.label_CheckConnection.Size = new System.Drawing.Size(78, 13);
            this.label_CheckConnection.TabIndex = 6;
            this.label_CheckConnection.Text = "Not connected";
            // 
            // button_StartStopScanning
            // 
            this.button_StartStopScanning.Location = new System.Drawing.Point(127, 100);
            this.button_StartStopScanning.Name = "button_StartStopScanning";
            this.button_StartStopScanning.Size = new System.Drawing.Size(176, 23);
            this.button_StartStopScanning.TabIndex = 7;
            this.button_StartStopScanning.Text = "Start Scanning";
            this.button_StartStopScanning.UseVisualStyleBackColor = true;
            this.button_StartStopScanning.Click += new System.EventHandler(this.button_StartStopScanning_Click);
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Location = new System.Drawing.Point(625, 166);
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.Size = new System.Drawing.Size(100, 20);
            this.textBox_Filename.TabIndex = 8;
            this.textBox_Filename.Text = "distances.txt";
            // 
            // label_Filename
            // 
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(546, 169);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(52, 13);
            this.label_Filename.TabIndex = 9;
            this.label_Filename.Text = "Filename:";
            // 
            // button_exportScan
            // 
            this.button_exportScan.Location = new System.Drawing.Point(731, 164);
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
            this.label_exportInfo.Location = new System.Drawing.Point(546, 150);
            this.label_exportInfo.Name = "label_exportInfo";
            this.label_exportInfo.Size = new System.Drawing.Size(134, 13);
            this.label_exportInfo.TabIndex = 11;
            this.label_exportInfo.Text = "Export last scan data to file";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Disconnect.Location = new System.Drawing.Point(309, 70);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(93, 23);
            this.button_Disconnect.TabIndex = 12;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_XYZimport
            // 
            this.button_XYZimport.Location = new System.Drawing.Point(744, 225);
            this.button_XYZimport.Name = "button_XYZimport";
            this.button_XYZimport.Size = new System.Drawing.Size(93, 23);
            this.button_XYZimport.TabIndex = 13;
            this.button_XYZimport.Text = "Parse to XYZ";
            this.button_XYZimport.UseVisualStyleBackColor = true;
            this.button_XYZimport.Click += new System.EventHandler(this.button_XYZimport_Click);
            // 
            // textBox_XYZexport
            // 
            this.textBox_XYZexport.Location = new System.Drawing.Point(638, 227);
            this.textBox_XYZexport.Name = "textBox_XYZexport";
            this.textBox_XYZexport.Size = new System.Drawing.Size(100, 20);
            this.textBox_XYZexport.TabIndex = 14;
            this.textBox_XYZexport.Text = "distancesXYZ.txt";
            // 
            // textBox_XYZimport
            // 
            this.textBox_XYZimport.Location = new System.Drawing.Point(536, 227);
            this.textBox_XYZimport.Name = "textBox_XYZimport";
            this.textBox_XYZimport.Size = new System.Drawing.Size(100, 20);
            this.textBox_XYZimport.TabIndex = 15;
            this.textBox_XYZimport.Text = "distances.txt";
            // 
            // label_FromFileXYZ
            // 
            this.label_FromFileXYZ.AutoSize = true;
            this.label_FromFileXYZ.Location = new System.Drawing.Point(565, 211);
            this.label_FromFileXYZ.Name = "label_FromFileXYZ";
            this.label_FromFileXYZ.Size = new System.Drawing.Size(33, 13);
            this.label_FromFileXYZ.TabIndex = 16;
            this.label_FromFileXYZ.Text = "From:";
            // 
            // label_ToFIleXYZ
            // 
            this.label_ToFIleXYZ.AutoSize = true;
            this.label_ToFIleXYZ.Location = new System.Drawing.Point(663, 211);
            this.label_ToFIleXYZ.Name = "label_ToFIleXYZ";
            this.label_ToFIleXYZ.Size = new System.Drawing.Size(23, 13);
            this.label_ToFIleXYZ.TabIndex = 17;
            this.label_ToFIleXYZ.Text = "To:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(447, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_Xoffset
            // 
            this.textBox_Xoffset.Location = new System.Drawing.Point(543, 40);
            this.textBox_Xoffset.Name = "textBox_Xoffset";
            this.textBox_Xoffset.Size = new System.Drawing.Size(100, 20);
            this.textBox_Xoffset.TabIndex = 20;
            this.textBox_Xoffset.Text = "0";
            // 
            // textBox_Yoffset
            // 
            this.textBox_Yoffset.Location = new System.Drawing.Point(649, 40);
            this.textBox_Yoffset.Name = "textBox_Yoffset";
            this.textBox_Yoffset.Size = new System.Drawing.Size(100, 20);
            this.textBox_Yoffset.TabIndex = 21;
            this.textBox_Yoffset.Text = "0";
            // 
            // textBox_Zoffset
            // 
            this.textBox_Zoffset.Location = new System.Drawing.Point(755, 40);
            this.textBox_Zoffset.Name = "textBox_Zoffset";
            this.textBox_Zoffset.Size = new System.Drawing.Size(100, 20);
            this.textBox_Zoffset.TabIndex = 22;
            this.textBox_Zoffset.Text = "0";
            // 
            // label_Xoffset
            // 
            this.label_Xoffset.AutoSize = true;
            this.label_Xoffset.Location = new System.Drawing.Point(574, 21);
            this.label_Xoffset.Name = "label_Xoffset";
            this.label_Xoffset.Size = new System.Drawing.Size(46, 13);
            this.label_Xoffset.TabIndex = 23;
            this.label_Xoffset.Text = "X offset:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Y offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Z offset:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(447, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // button_setOffset
            // 
            this.button_setOffset.Location = new System.Drawing.Point(755, 66);
            this.button_setOffset.Name = "button_setOffset";
            this.button_setOffset.Size = new System.Drawing.Size(100, 23);
            this.button_setOffset.TabIndex = 27;
            this.button_setOffset.Text = "Set Offset";
            this.button_setOffset.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(320, 150);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(29, 13);
            this.label_Port.TabIndex = 32;
            this.label_Port.Text = "Port:";
            // 
            // label_IPAdress
            // 
            this.label_IPAdress.AutoSize = true;
            this.label_IPAdress.Location = new System.Drawing.Point(177, 150);
            this.label_IPAdress.Name = "label_IPAdress";
            this.label_IPAdress.Size = new System.Drawing.Size(55, 13);
            this.label_IPAdress.TabIndex = 31;
            this.label_IPAdress.Text = "IP Adress:";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(281, 169);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 20);
            this.textBox_Port.TabIndex = 30;
            this.textBox_Port.Text = "6000";
            // 
            // textBox_IPAdress
            // 
            this.textBox_IPAdress.Location = new System.Drawing.Point(127, 169);
            this.textBox_IPAdress.Name = "textBox_IPAdress";
            this.textBox_IPAdress.Size = new System.Drawing.Size(148, 20);
            this.textBox_IPAdress.TabIndex = 29;
            this.textBox_IPAdress.Text = "127.0.0.1";
            // 
            // label_ToFileDXF
            // 
            this.label_ToFileDXF.AutoSize = true;
            this.label_ToFileDXF.Location = new System.Drawing.Point(663, 266);
            this.label_ToFileDXF.Name = "label_ToFileDXF";
            this.label_ToFileDXF.Size = new System.Drawing.Size(23, 13);
            this.label_ToFileDXF.TabIndex = 37;
            this.label_ToFileDXF.Text = "To:";
            // 
            // label_FromFileDXF
            // 
            this.label_FromFileDXF.AutoSize = true;
            this.label_FromFileDXF.Location = new System.Drawing.Point(565, 266);
            this.label_FromFileDXF.Name = "label_FromFileDXF";
            this.label_FromFileDXF.Size = new System.Drawing.Size(33, 13);
            this.label_FromFileDXF.TabIndex = 36;
            this.label_FromFileDXF.Text = "From:";
            // 
            // textBox_DXFimport
            // 
            this.textBox_DXFimport.Location = new System.Drawing.Point(536, 282);
            this.textBox_DXFimport.Name = "textBox_DXFimport";
            this.textBox_DXFimport.Size = new System.Drawing.Size(100, 20);
            this.textBox_DXFimport.TabIndex = 35;
            this.textBox_DXFimport.Text = "distancesXYZ.txt";
            // 
            // textBox_DXFexport
            // 
            this.textBox_DXFexport.Location = new System.Drawing.Point(638, 282);
            this.textBox_DXFexport.Name = "textBox_DXFexport";
            this.textBox_DXFexport.Size = new System.Drawing.Size(100, 20);
            this.textBox_DXFexport.TabIndex = 34;
            this.textBox_DXFexport.Text = "distancesDXF.dxf";
            // 
            // button_DXFparser
            // 
            this.button_DXFparser.Location = new System.Drawing.Point(744, 280);
            this.button_DXFparser.Name = "button_DXFparser";
            this.button_DXFparser.Size = new System.Drawing.Size(93, 23);
            this.button_DXFparser.TabIndex = 33;
            this.button_DXFparser.Text = "Parse to DXF";
            this.button_DXFparser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 329);
            this.Controls.Add(this.label_ToFileDXF);
            this.Controls.Add(this.label_FromFileDXF);
            this.Controls.Add(this.textBox_DXFimport);
            this.Controls.Add(this.textBox_DXFexport);
            this.Controls.Add(this.button_DXFparser);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.label_IPAdress);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IPAdress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button_setOffset);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Xoffset);
            this.Controls.Add(this.textBox_Zoffset);
            this.Controls.Add(this.textBox_Yoffset);
            this.Controls.Add(this.textBox_Xoffset);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_ToFIleXYZ);
            this.Controls.Add(this.label_FromFileXYZ);
            this.Controls.Add(this.textBox_XYZimport);
            this.Controls.Add(this.textBox_XYZexport);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_XYZexport;
        private System.Windows.Forms.TextBox textBox_XYZimport;
        private System.Windows.Forms.Label label_FromFileXYZ;
        private System.Windows.Forms.Label label_ToFIleXYZ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_Xoffset;
        private System.Windows.Forms.TextBox textBox_Yoffset;
        private System.Windows.Forms.TextBox textBox_Zoffset;
        private System.Windows.Forms.Label label_Xoffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_setOffset;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_IPAdress;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_IPAdress;
        private System.Windows.Forms.Label label_ToFileDXF;
        private System.Windows.Forms.Label label_FromFileDXF;
        private System.Windows.Forms.TextBox textBox_DXFimport;
        private System.Windows.Forms.TextBox textBox_DXFexport;
        private System.Windows.Forms.Button button_DXFparser;
    }
}

