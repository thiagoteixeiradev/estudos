namespace _42.Servidor_de_Chat
{
    partial class Main
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
            txbIP = new TextBox();
            nPorta = new NumericUpDown();
            btnStart = new Button();
            lbLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nPorta).BeginInit();
            SuspendLayout();
            // 
            // txbIP
            // 
            txbIP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbIP.Location = new Point(12, 12);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(195, 33);
            txbIP.TabIndex = 0;
            txbIP.Text = "127.0.0.1";
            // 
            // nPorta
            // 
            nPorta.Font = new Font("Segoe UI", 14F);
            nPorta.Location = new Point(213, 12);
            nPorta.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nPorta.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nPorta.Name = "nPorta";
            nPorta.Size = new Size(68, 32);
            nPorta.TabIndex = 1;
            nPorta.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.Location = new Point(287, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(141, 32);
            btnStart.TabIndex = 2;
            btnStart.Text = "Ligar Servidor";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(12, 51);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(439, 214);
            lbLog.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 279);
            Controls.Add(lbLog);
            Controls.Add(btnStart);
            Controls.Add(nPorta);
            Controls.Add(txbIP);
            Name = "Main";
            Text = "InfoChat";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nPorta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbIP;
        private NumericUpDown nPorta;
        private Button btnStart;
        private ListBox lbLog;
    }
}
