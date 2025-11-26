namespace _41.ClienteDeArquivos
{
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
            label1 = new Label();
            lbIp = new TextBox();
            nPorta = new NumericUpDown();
            lbArquivo = new LinkLabel();
            lbStatus = new Label();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)nPorta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente para Compartilhar Arquivos";
            // 
            // lbIp
            // 
            lbIp.Font = new Font("Segoe UI", 16F);
            lbIp.Location = new Point(97, 85);
            lbIp.Name = "lbIp";
            lbIp.Size = new Size(147, 36);
            lbIp.TabIndex = 1;
            lbIp.Text = "127.0.0.1";
            // 
            // nPorta
            // 
            nPorta.Font = new Font("Segoe UI", 16F);
            nPorta.Location = new Point(250, 86);
            nPorta.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nPorta.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nPorta.Name = "nPorta";
            nPorta.Size = new Size(72, 36);
            nPorta.TabIndex = 2;
            nPorta.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lbArquivo
            // 
            lbArquivo.AutoSize = true;
            lbArquivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbArquivo.Location = new Point(79, 125);
            lbArquivo.Name = "lbArquivo";
            lbArquivo.Size = new Size(288, 25);
            lbArquivo.TabIndex = 3;
            lbArquivo.TabStop = true;
            lbArquivo.Text = "Clique Para Selecionar o Arquivo";
            lbArquivo.LinkClicked += lbArquivo_LinkClicked;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatus.ForeColor = SystemColors.MenuText;
            lbStatus.Location = new Point(166, 215);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(96, 37);
            lbStatus.TabIndex = 4;
            lbStatus.Text = "Status";
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(130, 153);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(164, 35);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar Arquivo";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 261);
            Controls.Add(btnEnviar);
            Controls.Add(lbStatus);
            Controls.Add(lbArquivo);
            Controls.Add(nPorta);
            Controls.Add(lbIp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Comparilhar Arquivos";
            ((System.ComponentModel.ISupportInitialize)nPorta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lbIp;
        private NumericUpDown nPorta;
        private LinkLabel lbArquivo;
        private Label lbStatus;
        private Button btnEnviar;
    }
}
