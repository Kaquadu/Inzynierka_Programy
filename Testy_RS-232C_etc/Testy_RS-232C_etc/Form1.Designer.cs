namespace Testy_RS_232C_etc
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
            this.textBox_ChooseCOM = new System.Windows.Forms.TextBox();
            this.textLabel_ChooseCOM = new System.Windows.Forms.Label();
            this.button_ListenStartStop = new System.Windows.Forms.Button();
            this.textLabel_BaudRate = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.textBox_DataBitsValue = new System.Windows.Forms.TextBox();
            this.textLabel_dataBits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ChooseCOM
            // 
            this.textBox_ChooseCOM.Location = new System.Drawing.Point(101, 30);
            this.textBox_ChooseCOM.Name = "textBox_ChooseCOM";
            this.textBox_ChooseCOM.Size = new System.Drawing.Size(121, 20);
            this.textBox_ChooseCOM.TabIndex = 0;
            this.textBox_ChooseCOM.Text = "COM1";
            // 
            // textLabel_ChooseCOM
            // 
            this.textLabel_ChooseCOM.AutoSize = true;
            this.textLabel_ChooseCOM.Location = new System.Drawing.Point(22, 33);
            this.textLabel_ChooseCOM.Name = "textLabel_ChooseCOM";
            this.textLabel_ChooseCOM.Size = new System.Drawing.Size(73, 13);
            this.textLabel_ChooseCOM.TabIndex = 1;
            this.textLabel_ChooseCOM.Text = "Choose COM:";
            // 
            // button_ListenStartStop
            // 
            this.button_ListenStartStop.Location = new System.Drawing.Point(238, 28);
            this.button_ListenStartStop.Name = "button_ListenStartStop";
            this.button_ListenStartStop.Size = new System.Drawing.Size(100, 23);
            this.button_ListenStartStop.TabIndex = 2;
            this.button_ListenStartStop.Text = "Listen Start";
            this.button_ListenStartStop.UseVisualStyleBackColor = true;
            this.button_ListenStartStop.Click += new System.EventHandler(this.button_ListenStartStop_Click);
            // 
            // textLabel_BaudRate
            // 
            this.textLabel_BaudRate.AutoSize = true;
            this.textLabel_BaudRate.Location = new System.Drawing.Point(34, 59);
            this.textLabel_BaudRate.Name = "textLabel_BaudRate";
            this.textLabel_BaudRate.Size = new System.Drawing.Size(61, 13);
            this.textLabel_BaudRate.TabIndex = 3;
            this.textLabel_BaudRate.Text = "Baud Rate:";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(101, 56);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BaudRate.TabIndex = 4;
            this.comboBox_BaudRate.Text = "9600";
            // 
            // textBox_DataBitsValue
            // 
            this.textBox_DataBitsValue.Location = new System.Drawing.Point(101, 83);
            this.textBox_DataBitsValue.Name = "textBox_DataBitsValue";
            this.textBox_DataBitsValue.Size = new System.Drawing.Size(121, 20);
            this.textBox_DataBitsValue.TabIndex = 6;
            this.textBox_DataBitsValue.Text = "8";
            // 
            // textLabel_dataBits
            // 
            this.textLabel_dataBits.AutoSize = true;
            this.textLabel_dataBits.Location = new System.Drawing.Point(12, 86);
            this.textLabel_dataBits.Name = "textLabel_dataBits";
            this.textLabel_dataBits.Size = new System.Drawing.Size(83, 13);
            this.textLabel_dataBits.TabIndex = 10;
            this.textLabel_dataBits.Text = "Data Bits Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 137);
            this.Controls.Add(this.textLabel_dataBits);
            this.Controls.Add(this.textBox_DataBitsValue);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.textLabel_BaudRate);
            this.Controls.Add(this.button_ListenStartStop);
            this.Controls.Add(this.textLabel_ChooseCOM);
            this.Controls.Add(this.textBox_ChooseCOM);
            this.Name = "Form1";
            this.Text = "Serials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ChooseCOM;
        private System.Windows.Forms.Label textLabel_ChooseCOM;
        private System.Windows.Forms.Button button_ListenStartStop;
        private System.Windows.Forms.Label textLabel_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.TextBox textBox_DataBitsValue;
        private System.Windows.Forms.Label textLabel_dataBits;
    }
}

