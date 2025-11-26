namespace _43.Client_de_chat
{
    partial class Client
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
            btnStart = new Button();
            nPorta = new NumericUpDown();
            txbIP = new TextBox();
            btnEnviar = new Button();
            txbMensagem = new TextBox();
            lbStatus = new Label();
            txbUserName = new TextBox();
            txbLog = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nPorta).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(356, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(90, 65);
            btnStart.TabIndex = 6;
            btnStart.Text = "Conectar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // nPorta
            // 
            nPorta.Font = new Font("Segoe UI", 14F);
            nPorta.Location = new Point(282, 11);
            nPorta.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nPorta.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nPorta.Name = "nPorta";
            nPorta.Size = new Size(68, 32);
            nPorta.TabIndex = 5;
            nPorta.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // txbIP
            // 
            txbIP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbIP.Location = new Point(12, 10);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(264, 33);
            txbIP.TabIndex = 4;
            txbIP.Text = "127.0.0.1";
            // 
            // btnEnviar
            // 
            btnEnviar.Enabled = false;
            btnEnviar.Location = new Point(310, 473);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(141, 32);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txbMensagem
            // 
            txbMensagem.Enabled = false;
            txbMensagem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMensagem.Location = new Point(12, 473);
            txbMensagem.Name = "txbMensagem";
            txbMensagem.Size = new Size(292, 33);
            txbMensagem.TabIndex = 9;
            txbMensagem.Text = "Digite aqui sua mensagem";
            txbMensagem.MouseClick += txbMensagem_MouseClick;
            txbMensagem.KeyPress += txbMensagem_KeyPress;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStatus.Location = new Point(288, 52);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(62, 25);
            lbStatus.TabIndex = 10;
            lbStatus.Text = "Status";
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUserName.Location = new Point(12, 49);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(264, 33);
            txbUserName.TabIndex = 11;
            txbUserName.Text = "Nome de Usuário";
            txbUserName.MouseClick += txbUserName_MouseClick;
            // 
            // txbLog
            // 
            txbLog.Location = new Point(12, 88);
            txbLog.Multiline = true;
            txbLog.Name = "txbLog";
            txbLog.ReadOnly = true;
            txbLog.Size = new Size(434, 379);
            txbLog.TabIndex = 12;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 518);
            Controls.Add(txbLog);
            Controls.Add(txbUserName);
            Controls.Add(lbStatus);
            Controls.Add(txbMensagem);
            Controls.Add(btnEnviar);
            Controls.Add(btnStart);
            Controls.Add(nPorta);
            Controls.Add(txbIP);
            Name = "Client";
            Text = "InfoChat";
            ((System.ComponentModel.ISupportInitialize)nPorta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStart;
        private NumericUpDown nPorta;
        private TextBox txbIP;
        private Button btnEnviar;
        private TextBox txbMensagem;
        private Label lbStatus;
        private TextBox txbUserName;
        private TextBox txbLog;
    }
}
