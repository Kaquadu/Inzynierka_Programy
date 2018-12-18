namespace UIex
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
            this.pictureBox__Close = new System.Windows.Forms.PictureBox();
            this.pictureBox__Visualisation = new System.Windows.Forms.PictureBox();
            this.pictureBox__Export = new System.Windows.Forms.PictureBox();
            this.pictureBox__Scanning = new System.Windows.Forms.PictureBox();
            this.pictureBox__Communication = new System.Windows.Forms.PictureBox();
            this.pictureBox_TopBar = new System.Windows.Forms.PictureBox();
            this.panel__Communication = new System.Windows.Forms.Panel();
            this.button__DisconnectRobot = new System.Windows.Forms.Button();
            this.button__DisconnectScanner = new System.Windows.Forms.Button();
            this.label__RobotPort = new System.Windows.Forms.Label();
            this.label__RobotIP = new System.Windows.Forms.Label();
            this.button__ConnectRobot = new System.Windows.Forms.Button();
            this.textBox__RobotPort = new System.Windows.Forms.TextBox();
            this.textBox__RobotIP = new System.Windows.Forms.TextBox();
            this.button__ConnectScanner = new System.Windows.Forms.Button();
            this.label__BaudRate = new System.Windows.Forms.Label();
            this.label__COM = new System.Windows.Forms.Label();
            this.textBox__BaudRate = new System.Windows.Forms.TextBox();
            this.textBox__COM = new System.Windows.Forms.TextBox();
            this.panel__Scanning = new System.Windows.Forms.Panel();
            this.label__ScanResultsFile = new System.Windows.Forms.Label();
            this.textBox__ScanResultsFile = new System.Windows.Forms.TextBox();
            this.button__StartStopAutomatedScanning = new System.Windows.Forms.Button();
            this.button__MoveToHome = new System.Windows.Forms.Button();
            this.label__ScanAccuracy = new System.Windows.Forms.Label();
            this.button__ScanAccuracy = new System.Windows.Forms.Button();
            this.textBox__ScanAccuracy = new System.Windows.Forms.TextBox();
            this.button__MakeScan = new System.Windows.Forms.Button();
            this.button__MoveRobot = new System.Windows.Forms.Button();
            this.checkBox__AutomatedScanning = new System.Windows.Forms.CheckBox();
            this.checkBox__ManualScanning = new System.Windows.Forms.CheckBox();
            this.label__Scaner = new System.Windows.Forms.Label();
            this.label__Robot = new System.Windows.Forms.Label();
            this.label__CheckScanner = new System.Windows.Forms.Label();
            this.label__CheckRobot = new System.Windows.Forms.Label();
            this.richTextBox__OutputLog = new System.Windows.Forms.RichTextBox();
            this.label__OutputLog = new System.Windows.Forms.Label();
            this.panel__Export = new System.Windows.Forms.Panel();
            this.button__DXFExport = new System.Windows.Forms.Button();
            this.button__XYZExport = new System.Windows.Forms.Button();
            this.label__DXFToFile = new System.Windows.Forms.Label();
            this.label__DXFFromFile = new System.Windows.Forms.Label();
            this.label__XYZToFile = new System.Windows.Forms.Label();
            this.label__XYZFromFile = new System.Windows.Forms.Label();
            this.textBox__DXFToFile = new System.Windows.Forms.TextBox();
            this.textBox__DXFFromFile = new System.Windows.Forms.TextBox();
            this.textBox__XYZToFile = new System.Windows.Forms.TextBox();
            this.textBox__XYZFromFile = new System.Windows.Forms.TextBox();
            this.backgroundWorker__automatedScan = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Visualisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Scanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Communication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TopBar)).BeginInit();
            this.panel__Communication.SuspendLayout();
            this.panel__Scanning.SuspendLayout();
            this.panel__Export.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox__Close
            // 
            this.pictureBox__Close.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox__Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox__Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__Close.Image")));
            this.pictureBox__Close.Location = new System.Drawing.Point(690, 4);
            this.pictureBox__Close.Name = "pictureBox__Close";
            this.pictureBox__Close.Size = new System.Drawing.Size(32, 32);
            this.pictureBox__Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__Close.TabIndex = 0;
            this.pictureBox__Close.TabStop = false;
            this.pictureBox__Close.Click += new System.EventHandler(this.pictureBox__Close_Click);
            // 
            // pictureBox__Visualisation
            // 
            this.pictureBox__Visualisation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__Visualisation.Image")));
            this.pictureBox__Visualisation.Location = new System.Drawing.Point(12, 348);
            this.pictureBox__Visualisation.Name = "pictureBox__Visualisation";
            this.pictureBox__Visualisation.Size = new System.Drawing.Size(202, 102);
            this.pictureBox__Visualisation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__Visualisation.TabIndex = 1;
            this.pictureBox__Visualisation.TabStop = false;
            // 
            // pictureBox__Export
            // 
            this.pictureBox__Export.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__Export.Image")));
            this.pictureBox__Export.Location = new System.Drawing.Point(12, 247);
            this.pictureBox__Export.Name = "pictureBox__Export";
            this.pictureBox__Export.Size = new System.Drawing.Size(202, 102);
            this.pictureBox__Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__Export.TabIndex = 2;
            this.pictureBox__Export.TabStop = false;
            this.pictureBox__Export.Click += new System.EventHandler(this.pictureBox__Export_Click);
            // 
            // pictureBox__Scanning
            // 
            this.pictureBox__Scanning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__Scanning.Image")));
            this.pictureBox__Scanning.Location = new System.Drawing.Point(12, 146);
            this.pictureBox__Scanning.Name = "pictureBox__Scanning";
            this.pictureBox__Scanning.Size = new System.Drawing.Size(202, 102);
            this.pictureBox__Scanning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__Scanning.TabIndex = 3;
            this.pictureBox__Scanning.TabStop = false;
            this.pictureBox__Scanning.Click += new System.EventHandler(this.pictureBox__Scanning_Click);
            // 
            // pictureBox__Communication
            // 
            this.pictureBox__Communication.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__Communication.Image")));
            this.pictureBox__Communication.Location = new System.Drawing.Point(12, 45);
            this.pictureBox__Communication.Name = "pictureBox__Communication";
            this.pictureBox__Communication.Size = new System.Drawing.Size(202, 102);
            this.pictureBox__Communication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__Communication.TabIndex = 4;
            this.pictureBox__Communication.TabStop = false;
            this.pictureBox__Communication.Click += new System.EventHandler(this.pictureBox__Communication_Click);
            // 
            // pictureBox_TopBar
            // 
            this.pictureBox_TopBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox_TopBar.Location = new System.Drawing.Point(-12, -1);
            this.pictureBox_TopBar.Name = "pictureBox_TopBar";
            this.pictureBox_TopBar.Size = new System.Drawing.Size(929, 40);
            this.pictureBox_TopBar.TabIndex = 5;
            this.pictureBox_TopBar.TabStop = false;
            this.pictureBox_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            // 
            // panel__Communication
            // 
            this.panel__Communication.Controls.Add(this.button__DisconnectRobot);
            this.panel__Communication.Controls.Add(this.button__DisconnectScanner);
            this.panel__Communication.Controls.Add(this.label__RobotPort);
            this.panel__Communication.Controls.Add(this.label__RobotIP);
            this.panel__Communication.Controls.Add(this.button__ConnectRobot);
            this.panel__Communication.Controls.Add(this.textBox__RobotPort);
            this.panel__Communication.Controls.Add(this.textBox__RobotIP);
            this.panel__Communication.Controls.Add(this.button__ConnectScanner);
            this.panel__Communication.Controls.Add(this.label__BaudRate);
            this.panel__Communication.Controls.Add(this.label__COM);
            this.panel__Communication.Controls.Add(this.textBox__BaudRate);
            this.panel__Communication.Controls.Add(this.textBox__COM);
            this.panel__Communication.Location = new System.Drawing.Point(223, 45);
            this.panel__Communication.Name = "panel__Communication";
            this.panel__Communication.Size = new System.Drawing.Size(499, 305);
            this.panel__Communication.TabIndex = 6;
            // 
            // button__DisconnectRobot
            // 
            this.button__DisconnectRobot.Location = new System.Drawing.Point(205, 217);
            this.button__DisconnectRobot.Name = "button__DisconnectRobot";
            this.button__DisconnectRobot.Size = new System.Drawing.Size(115, 23);
            this.button__DisconnectRobot.TabIndex = 42;
            this.button__DisconnectRobot.Text = "Disconnect Robot";
            this.button__DisconnectRobot.UseVisualStyleBackColor = true;
            this.button__DisconnectRobot.Click += new System.EventHandler(this.button__DisconnectRobot_Click);
            // 
            // button__DisconnectScanner
            // 
            this.button__DisconnectScanner.Location = new System.Drawing.Point(205, 88);
            this.button__DisconnectScanner.Name = "button__DisconnectScanner";
            this.button__DisconnectScanner.Size = new System.Drawing.Size(115, 23);
            this.button__DisconnectScanner.TabIndex = 41;
            this.button__DisconnectScanner.Text = "Disconnect Scanner";
            this.button__DisconnectScanner.UseVisualStyleBackColor = true;
            this.button__DisconnectScanner.Click += new System.EventHandler(this.button__DisconnectScanner_Click);
            // 
            // label__RobotPort
            // 
            this.label__RobotPort.AutoSize = true;
            this.label__RobotPort.Location = new System.Drawing.Point(29, 195);
            this.label__RobotPort.Name = "label__RobotPort";
            this.label__RobotPort.Size = new System.Drawing.Size(29, 13);
            this.label__RobotPort.TabIndex = 40;
            this.label__RobotPort.Text = "Port:";
            // 
            // label__RobotIP
            // 
            this.label__RobotIP.AutoSize = true;
            this.label__RobotIP.Location = new System.Drawing.Point(29, 168);
            this.label__RobotIP.Name = "label__RobotIP";
            this.label__RobotIP.Size = new System.Drawing.Size(61, 13);
            this.label__RobotIP.TabIndex = 39;
            this.label__RobotIP.Text = "IP Address:";
            // 
            // button__ConnectRobot
            // 
            this.button__ConnectRobot.Location = new System.Drawing.Point(96, 217);
            this.button__ConnectRobot.Name = "button__ConnectRobot";
            this.button__ConnectRobot.Size = new System.Drawing.Size(100, 23);
            this.button__ConnectRobot.TabIndex = 38;
            this.button__ConnectRobot.Text = "Connect Robot";
            this.button__ConnectRobot.UseVisualStyleBackColor = true;
            this.button__ConnectRobot.Click += new System.EventHandler(this.button__ConnectRobot_Click);
            // 
            // textBox__RobotPort
            // 
            this.textBox__RobotPort.Location = new System.Drawing.Point(96, 191);
            this.textBox__RobotPort.Name = "textBox__RobotPort";
            this.textBox__RobotPort.Size = new System.Drawing.Size(100, 20);
            this.textBox__RobotPort.TabIndex = 37;
            this.textBox__RobotPort.Text = "3333";
            // 
            // textBox__RobotIP
            // 
            this.textBox__RobotIP.Location = new System.Drawing.Point(96, 165);
            this.textBox__RobotIP.Name = "textBox__RobotIP";
            this.textBox__RobotIP.Size = new System.Drawing.Size(100, 20);
            this.textBox__RobotIP.TabIndex = 36;
            this.textBox__RobotIP.Text = "172.31.0.1";
            // 
            // button__ConnectScanner
            // 
            this.button__ConnectScanner.Location = new System.Drawing.Point(96, 87);
            this.button__ConnectScanner.Name = "button__ConnectScanner";
            this.button__ConnectScanner.Size = new System.Drawing.Size(100, 23);
            this.button__ConnectScanner.TabIndex = 35;
            this.button__ConnectScanner.Text = "Connect Scanner";
            this.button__ConnectScanner.UseVisualStyleBackColor = true;
            this.button__ConnectScanner.Click += new System.EventHandler(this.button__ConnectScanner_Click);
            // 
            // label__BaudRate
            // 
            this.label__BaudRate.AutoSize = true;
            this.label__BaudRate.Location = new System.Drawing.Point(29, 64);
            this.label__BaudRate.Name = "label__BaudRate";
            this.label__BaudRate.Size = new System.Drawing.Size(61, 13);
            this.label__BaudRate.TabIndex = 34;
            this.label__BaudRate.Text = "Baud Rate:";
            // 
            // label__COM
            // 
            this.label__COM.AutoSize = true;
            this.label__COM.Location = new System.Drawing.Point(29, 37);
            this.label__COM.Name = "label__COM";
            this.label__COM.Size = new System.Drawing.Size(34, 13);
            this.label__COM.TabIndex = 33;
            this.label__COM.Text = "COM:";
            // 
            // textBox__BaudRate
            // 
            this.textBox__BaudRate.Location = new System.Drawing.Point(96, 61);
            this.textBox__BaudRate.Name = "textBox__BaudRate";
            this.textBox__BaudRate.Size = new System.Drawing.Size(100, 20);
            this.textBox__BaudRate.TabIndex = 32;
            this.textBox__BaudRate.Text = "115200";
            // 
            // textBox__COM
            // 
            this.textBox__COM.Location = new System.Drawing.Point(96, 34);
            this.textBox__COM.Name = "textBox__COM";
            this.textBox__COM.Size = new System.Drawing.Size(100, 20);
            this.textBox__COM.TabIndex = 31;
            this.textBox__COM.Text = "COM8";
            // 
            // panel__Scanning
            // 
            this.panel__Scanning.Controls.Add(this.label__ScanResultsFile);
            this.panel__Scanning.Controls.Add(this.textBox__ScanResultsFile);
            this.panel__Scanning.Controls.Add(this.button__StartStopAutomatedScanning);
            this.panel__Scanning.Controls.Add(this.button__MoveToHome);
            this.panel__Scanning.Controls.Add(this.label__ScanAccuracy);
            this.panel__Scanning.Controls.Add(this.button__ScanAccuracy);
            this.panel__Scanning.Controls.Add(this.textBox__ScanAccuracy);
            this.panel__Scanning.Controls.Add(this.button__MakeScan);
            this.panel__Scanning.Controls.Add(this.button__MoveRobot);
            this.panel__Scanning.Controls.Add(this.checkBox__AutomatedScanning);
            this.panel__Scanning.Controls.Add(this.checkBox__ManualScanning);
            this.panel__Scanning.Location = new System.Drawing.Point(217, 51);
            this.panel__Scanning.Name = "panel__Scanning";
            this.panel__Scanning.Size = new System.Drawing.Size(499, 316);
            this.panel__Scanning.TabIndex = 41;
            // 
            // label__ScanResultsFile
            // 
            this.label__ScanResultsFile.AutoSize = true;
            this.label__ScanResultsFile.Location = new System.Drawing.Point(29, 113);
            this.label__ScanResultsFile.Name = "label__ScanResultsFile";
            this.label__ScanResultsFile.Size = new System.Drawing.Size(92, 13);
            this.label__ScanResultsFile.TabIndex = 17;
            this.label__ScanResultsFile.Text = "Scan Results File:";
            // 
            // textBox__ScanResultsFile
            // 
            this.textBox__ScanResultsFile.Location = new System.Drawing.Point(127, 110);
            this.textBox__ScanResultsFile.Name = "textBox__ScanResultsFile";
            this.textBox__ScanResultsFile.Size = new System.Drawing.Size(100, 20);
            this.textBox__ScanResultsFile.TabIndex = 16;
            this.textBox__ScanResultsFile.Text = "distances.txt";
            // 
            // button__StartStopAutomatedScanning
            // 
            this.button__StartStopAutomatedScanning.Location = new System.Drawing.Point(276, 193);
            this.button__StartStopAutomatedScanning.Name = "button__StartStopAutomatedScanning";
            this.button__StartStopAutomatedScanning.Size = new System.Drawing.Size(86, 23);
            this.button__StartStopAutomatedScanning.TabIndex = 15;
            this.button__StartStopAutomatedScanning.Text = "Start Scanning";
            this.button__StartStopAutomatedScanning.UseVisualStyleBackColor = true;
            this.button__StartStopAutomatedScanning.Click += new System.EventHandler(this.button__StartStopAutomatedScanning_Click);
            // 
            // button__MoveToHome
            // 
            this.button__MoveToHome.Location = new System.Drawing.Point(56, 197);
            this.button__MoveToHome.Name = "button__MoveToHome";
            this.button__MoveToHome.Size = new System.Drawing.Size(86, 23);
            this.button__MoveToHome.TabIndex = 14;
            this.button__MoveToHome.Text = "Home Robot";
            this.button__MoveToHome.UseVisualStyleBackColor = true;
            this.button__MoveToHome.Click += new System.EventHandler(this.button__MoveToHome_Click);
            // 
            // label__ScanAccuracy
            // 
            this.label__ScanAccuracy.AutoSize = true;
            this.label__ScanAccuracy.Location = new System.Drawing.Point(29, 87);
            this.label__ScanAccuracy.Name = "label__ScanAccuracy";
            this.label__ScanAccuracy.Size = new System.Drawing.Size(83, 13);
            this.label__ScanAccuracy.TabIndex = 13;
            this.label__ScanAccuracy.Text = "Scan Accuracy:";
            // 
            // button__ScanAccuracy
            // 
            this.button__ScanAccuracy.Location = new System.Drawing.Point(233, 82);
            this.button__ScanAccuracy.Name = "button__ScanAccuracy";
            this.button__ScanAccuracy.Size = new System.Drawing.Size(86, 23);
            this.button__ScanAccuracy.TabIndex = 5;
            this.button__ScanAccuracy.Text = "Set Scan Step";
            this.button__ScanAccuracy.UseVisualStyleBackColor = true;
            this.button__ScanAccuracy.Click += new System.EventHandler(this.button__ScanAccuracy_Click);
            // 
            // textBox__ScanAccuracy
            // 
            this.textBox__ScanAccuracy.Location = new System.Drawing.Point(126, 84);
            this.textBox__ScanAccuracy.Name = "textBox__ScanAccuracy";
            this.textBox__ScanAccuracy.Size = new System.Drawing.Size(100, 20);
            this.textBox__ScanAccuracy.TabIndex = 4;
            this.textBox__ScanAccuracy.Text = "10";
            // 
            // button__MakeScan
            // 
            this.button__MakeScan.Location = new System.Drawing.Point(56, 255);
            this.button__MakeScan.Name = "button__MakeScan";
            this.button__MakeScan.Size = new System.Drawing.Size(86, 23);
            this.button__MakeScan.TabIndex = 3;
            this.button__MakeScan.Text = "Commit Scan";
            this.button__MakeScan.UseVisualStyleBackColor = true;
            this.button__MakeScan.Click += new System.EventHandler(this.button__MakeScan_Click);
            // 
            // button__MoveRobot
            // 
            this.button__MoveRobot.Location = new System.Drawing.Point(56, 226);
            this.button__MoveRobot.Name = "button__MoveRobot";
            this.button__MoveRobot.Size = new System.Drawing.Size(86, 23);
            this.button__MoveRobot.TabIndex = 2;
            this.button__MoveRobot.Text = "Move Robot";
            this.button__MoveRobot.UseVisualStyleBackColor = true;
            this.button__MoveRobot.Click += new System.EventHandler(this.button__MoveRobot_Click);
            // 
            // checkBox__AutomatedScanning
            // 
            this.checkBox__AutomatedScanning.AutoSize = true;
            this.checkBox__AutomatedScanning.Location = new System.Drawing.Point(256, 170);
            this.checkBox__AutomatedScanning.Name = "checkBox__AutomatedScanning";
            this.checkBox__AutomatedScanning.Size = new System.Drawing.Size(125, 17);
            this.checkBox__AutomatedScanning.TabIndex = 1;
            this.checkBox__AutomatedScanning.Text = "Automated Scanning";
            this.checkBox__AutomatedScanning.UseVisualStyleBackColor = true;
            this.checkBox__AutomatedScanning.CheckedChanged += new System.EventHandler(this.checkBox__AutomatedScanning_CheckedChanged);
            // 
            // checkBox__ManualScanning
            // 
            this.checkBox__ManualScanning.AutoSize = true;
            this.checkBox__ManualScanning.Location = new System.Drawing.Point(47, 170);
            this.checkBox__ManualScanning.Name = "checkBox__ManualScanning";
            this.checkBox__ManualScanning.Size = new System.Drawing.Size(109, 17);
            this.checkBox__ManualScanning.TabIndex = 0;
            this.checkBox__ManualScanning.Text = "Manual Scanning";
            this.checkBox__ManualScanning.UseVisualStyleBackColor = true;
            this.checkBox__ManualScanning.CheckedChanged += new System.EventHandler(this.checkBox__ManualScanning_CheckedChanged);
            // 
            // label__Scaner
            // 
            this.label__Scaner.AutoSize = true;
            this.label__Scaner.Location = new System.Drawing.Point(572, 454);
            this.label__Scaner.Name = "label__Scaner";
            this.label__Scaner.Size = new System.Drawing.Size(50, 13);
            this.label__Scaner.TabIndex = 7;
            this.label__Scaner.Text = "Scanner:";
            // 
            // label__Robot
            // 
            this.label__Robot.AutoSize = true;
            this.label__Robot.Location = new System.Drawing.Point(425, 453);
            this.label__Robot.Name = "label__Robot";
            this.label__Robot.Size = new System.Drawing.Size(39, 13);
            this.label__Robot.TabIndex = 8;
            this.label__Robot.Text = "Robot:";
            // 
            // label__CheckScanner
            // 
            this.label__CheckScanner.AutoSize = true;
            this.label__CheckScanner.Location = new System.Drawing.Point(628, 454);
            this.label__CheckScanner.Name = "label__CheckScanner";
            this.label__CheckScanner.Size = new System.Drawing.Size(73, 13);
            this.label__CheckScanner.TabIndex = 9;
            this.label__CheckScanner.Text = "Disconnected";
            // 
            // label__CheckRobot
            // 
            this.label__CheckRobot.AutoSize = true;
            this.label__CheckRobot.Location = new System.Drawing.Point(470, 454);
            this.label__CheckRobot.Name = "label__CheckRobot";
            this.label__CheckRobot.Size = new System.Drawing.Size(73, 13);
            this.label__CheckRobot.TabIndex = 10;
            this.label__CheckRobot.Text = "Disconnected";
            // 
            // richTextBox__OutputLog
            // 
            this.richTextBox__OutputLog.Location = new System.Drawing.Point(220, 470);
            this.richTextBox__OutputLog.Name = "richTextBox__OutputLog";
            this.richTextBox__OutputLog.ReadOnly = true;
            this.richTextBox__OutputLog.Size = new System.Drawing.Size(499, 66);
            this.richTextBox__OutputLog.TabIndex = 11;
            this.richTextBox__OutputLog.Text = "";
            // 
            // label__OutputLog
            // 
            this.label__OutputLog.AutoSize = true;
            this.label__OutputLog.Location = new System.Drawing.Point(220, 454);
            this.label__OutputLog.Name = "label__OutputLog";
            this.label__OutputLog.Size = new System.Drawing.Size(63, 13);
            this.label__OutputLog.TabIndex = 12;
            this.label__OutputLog.Text = "Output Log:";
            // 
            // panel__Export
            // 
            this.panel__Export.Controls.Add(this.button__DXFExport);
            this.panel__Export.Controls.Add(this.button__XYZExport);
            this.panel__Export.Controls.Add(this.label__DXFToFile);
            this.panel__Export.Controls.Add(this.label__DXFFromFile);
            this.panel__Export.Controls.Add(this.label__XYZToFile);
            this.panel__Export.Controls.Add(this.label__XYZFromFile);
            this.panel__Export.Controls.Add(this.textBox__DXFToFile);
            this.panel__Export.Controls.Add(this.textBox__DXFFromFile);
            this.panel__Export.Controls.Add(this.textBox__XYZToFile);
            this.panel__Export.Controls.Add(this.textBox__XYZFromFile);
            this.panel__Export.Location = new System.Drawing.Point(220, 48);
            this.panel__Export.Name = "panel__Export";
            this.panel__Export.Size = new System.Drawing.Size(499, 265);
            this.panel__Export.TabIndex = 42;
            // 
            // button__DXFExport
            // 
            this.button__DXFExport.Location = new System.Drawing.Point(355, 225);
            this.button__DXFExport.Name = "button__DXFExport";
            this.button__DXFExport.Size = new System.Drawing.Size(98, 23);
            this.button__DXFExport.TabIndex = 9;
            this.button__DXFExport.Text = "Export to DXF";
            this.button__DXFExport.UseVisualStyleBackColor = true;
            this.button__DXFExport.Click += new System.EventHandler(this.button__DXFExport_Click);
            // 
            // button__XYZExport
            // 
            this.button__XYZExport.Location = new System.Drawing.Point(355, 122);
            this.button__XYZExport.Name = "button__XYZExport";
            this.button__XYZExport.Size = new System.Drawing.Size(98, 23);
            this.button__XYZExport.TabIndex = 8;
            this.button__XYZExport.Text = "Export to XYZ";
            this.button__XYZExport.UseVisualStyleBackColor = true;
            this.button__XYZExport.Click += new System.EventHandler(this.button__XYZExport_Click);
            // 
            // label__DXFToFile
            // 
            this.label__DXFToFile.AutoSize = true;
            this.label__DXFToFile.Location = new System.Drawing.Point(220, 209);
            this.label__DXFToFile.Name = "label__DXFToFile";
            this.label__DXFToFile.Size = new System.Drawing.Size(42, 13);
            this.label__DXFToFile.TabIndex = 7;
            this.label__DXFToFile.Text = "To File:";
            // 
            // label__DXFFromFile
            // 
            this.label__DXFFromFile.AutoSize = true;
            this.label__DXFFromFile.Location = new System.Drawing.Point(32, 209);
            this.label__DXFFromFile.Name = "label__DXFFromFile";
            this.label__DXFFromFile.Size = new System.Drawing.Size(33, 13);
            this.label__DXFFromFile.TabIndex = 6;
            this.label__DXFFromFile.Text = "From:";
            // 
            // label__XYZToFile
            // 
            this.label__XYZToFile.AutoSize = true;
            this.label__XYZToFile.Location = new System.Drawing.Point(220, 108);
            this.label__XYZToFile.Name = "label__XYZToFile";
            this.label__XYZToFile.Size = new System.Drawing.Size(42, 13);
            this.label__XYZToFile.TabIndex = 5;
            this.label__XYZToFile.Text = "To File:";
            // 
            // label__XYZFromFile
            // 
            this.label__XYZFromFile.AutoSize = true;
            this.label__XYZFromFile.Location = new System.Drawing.Point(32, 108);
            this.label__XYZFromFile.Name = "label__XYZFromFile";
            this.label__XYZFromFile.Size = new System.Drawing.Size(33, 13);
            this.label__XYZFromFile.TabIndex = 4;
            this.label__XYZFromFile.Text = "From:";
            // 
            // textBox__DXFToFile
            // 
            this.textBox__DXFToFile.Location = new System.Drawing.Point(223, 225);
            this.textBox__DXFToFile.Name = "textBox__DXFToFile";
            this.textBox__DXFToFile.Size = new System.Drawing.Size(100, 20);
            this.textBox__DXFToFile.TabIndex = 3;
            this.textBox__DXFToFile.Text = "distancesDXF.dxf";
            // 
            // textBox__DXFFromFile
            // 
            this.textBox__DXFFromFile.Location = new System.Drawing.Point(32, 225);
            this.textBox__DXFFromFile.Name = "textBox__DXFFromFile";
            this.textBox__DXFFromFile.Size = new System.Drawing.Size(100, 20);
            this.textBox__DXFFromFile.TabIndex = 2;
            this.textBox__DXFFromFile.Text = "distancesXYZ.txt";
            // 
            // textBox__XYZToFile
            // 
            this.textBox__XYZToFile.Location = new System.Drawing.Point(223, 124);
            this.textBox__XYZToFile.Name = "textBox__XYZToFile";
            this.textBox__XYZToFile.Size = new System.Drawing.Size(100, 20);
            this.textBox__XYZToFile.TabIndex = 1;
            this.textBox__XYZToFile.Text = "distancesXYZ.txt";
            // 
            // textBox__XYZFromFile
            // 
            this.textBox__XYZFromFile.Location = new System.Drawing.Point(32, 124);
            this.textBox__XYZFromFile.Name = "textBox__XYZFromFile";
            this.textBox__XYZFromFile.Size = new System.Drawing.Size(100, 20);
            this.textBox__XYZFromFile.TabIndex = 0;
            this.textBox__XYZFromFile.Text = "distances.txt";
            // 
            // backgroundWorker__automatedScan
            // 
            this.backgroundWorker__automatedScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker__automatedScan_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 548);
            this.Controls.Add(this.label__OutputLog);
            this.Controls.Add(this.richTextBox__OutputLog);
            this.Controls.Add(this.label__CheckRobot);
            this.Controls.Add(this.label__Scaner);
            this.Controls.Add(this.label__CheckScanner);
            this.Controls.Add(this.pictureBox__Communication);
            this.Controls.Add(this.label__Robot);
            this.Controls.Add(this.pictureBox__Scanning);
            this.Controls.Add(this.pictureBox__Export);
            this.Controls.Add(this.pictureBox__Visualisation);
            this.Controls.Add(this.pictureBox__Close);
            this.Controls.Add(this.pictureBox_TopBar);
            this.Controls.Add(this.panel__Scanning);
            this.Controls.Add(this.panel__Communication);
            this.Controls.Add(this.panel__Export);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Scaner Interface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Visualisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Scanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Communication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TopBar)).EndInit();
            this.panel__Communication.ResumeLayout(false);
            this.panel__Communication.PerformLayout();
            this.panel__Scanning.ResumeLayout(false);
            this.panel__Scanning.PerformLayout();
            this.panel__Export.ResumeLayout(false);
            this.panel__Export.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox__Close;
        private System.Windows.Forms.PictureBox pictureBox__Visualisation;
        private System.Windows.Forms.PictureBox pictureBox__Export;
        private System.Windows.Forms.PictureBox pictureBox__Scanning;
        private System.Windows.Forms.PictureBox pictureBox__Communication;
        private System.Windows.Forms.PictureBox pictureBox_TopBar;
        private System.Windows.Forms.Panel panel__Communication;
        private System.Windows.Forms.Label label__BaudRate;
        private System.Windows.Forms.Label label__COM;
        private System.Windows.Forms.TextBox textBox__BaudRate;
        private System.Windows.Forms.TextBox textBox__COM;
        private System.Windows.Forms.Label label__Scaner;
        private System.Windows.Forms.Label label__Robot;
        private System.Windows.Forms.Label label__CheckScanner;
        private System.Windows.Forms.Label label__CheckRobot;
        private System.Windows.Forms.RichTextBox richTextBox__OutputLog;
        private System.Windows.Forms.Label label__OutputLog;
        private System.Windows.Forms.Label label__RobotPort;
        private System.Windows.Forms.Label label__RobotIP;
        private System.Windows.Forms.Button button__ConnectRobot;
        private System.Windows.Forms.TextBox textBox__RobotPort;
        private System.Windows.Forms.TextBox textBox__RobotIP;
        private System.Windows.Forms.Button button__ConnectScanner;
        private System.Windows.Forms.Button button__MoveToHome;
        private System.Windows.Forms.Label label__ScanAccuracy;
        private System.Windows.Forms.Button button__ScanAccuracy;
        private System.Windows.Forms.TextBox textBox__ScanAccuracy;
        private System.Windows.Forms.Button button__MakeScan;
        private System.Windows.Forms.Button button__MoveRobot;
        private System.Windows.Forms.CheckBox checkBox__AutomatedScanning;
        private System.Windows.Forms.CheckBox checkBox__ManualScanning;
        private System.Windows.Forms.Label label__ScanResultsFile;
        private System.Windows.Forms.TextBox textBox__ScanResultsFile;
        private System.Windows.Forms.Button button__StartStopAutomatedScanning;
        private System.Windows.Forms.Button button__DXFExport;
        private System.Windows.Forms.Button button__XYZExport;
        private System.Windows.Forms.Label label__DXFToFile;
        private System.Windows.Forms.Label label__DXFFromFile;
        private System.Windows.Forms.Label label__XYZToFile;
        private System.Windows.Forms.Label label__XYZFromFile;
        private System.Windows.Forms.TextBox textBox__DXFToFile;
        private System.Windows.Forms.TextBox textBox__DXFFromFile;
        private System.Windows.Forms.TextBox textBox__XYZToFile;
        private System.Windows.Forms.TextBox textBox__XYZFromFile;
        public System.Windows.Forms.Panel panel__Scanning;
        public System.Windows.Forms.Panel panel__Export;
        private System.Windows.Forms.Button button__DisconnectRobot;
        private System.Windows.Forms.Button button__DisconnectScanner;
        private System.ComponentModel.BackgroundWorker backgroundWorker__automatedScan;
    }
}

