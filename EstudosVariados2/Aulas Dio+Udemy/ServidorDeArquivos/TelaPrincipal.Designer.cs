namespace ServidorDeArquivos
{
    partial class TelaPrincipal
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
            lbTitulo = new Label();
            btnConexao = new Button();
            btnParar = new Button();
            txbEndereco = new TextBox();
            nPorta = new NumericUpDown();
            lbPasta = new LinkLabel();
            lbLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nPorta).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.Font = new Font("Yu Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(64, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(496, 99);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Servidor para Compartilhamento de Arquivos";
            lbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(100, 152);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(210, 66);
            btnConexao.TabIndex = 1;
            btnConexao.Text = "Estabelecer Conexão";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(316, 152);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(210, 66);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar Servidor";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // txbEndereco
            // 
            txbEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbEndereco.Location = new Point(144, 111);
            txbEndereco.Name = "txbEndereco";
            txbEndereco.Size = new Size(210, 35);
            txbEndereco.TabIndex = 3;
            txbEndereco.Text = "127.0.0.1";
            // 
            // nPorta
            // 
            nPorta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nPorta.Location = new Point(360, 111);
            nPorta.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nPorta.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nPorta.Name = "nPorta";
            nPorta.Size = new Size(78, 35);
            nPorta.TabIndex = 4;
            nPorta.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lbPasta
            // 
            lbPasta.AutoSize = true;
            lbPasta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPasta.Location = new Point(12, 234);
            lbPasta.Name = "lbPasta";
            lbPasta.Size = new Size(276, 25);
            lbPasta.TabIndex = 5;
            lbPasta.TabStop = true;
            lbPasta.Text = "Clique para selecionar a Pasta...";
            lbPasta.LinkClicked += lbPasta_LinkClicked;
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(12, 262);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(624, 109);
            lbLog.TabIndex = 6;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 383);
            Controls.Add(lbLog);
            Controls.Add(lbPasta);
            Controls.Add(nPorta);
            Controls.Add(txbEndereco);
            Controls.Add(btnParar);
            Controls.Add(btnConexao);
            Controls.Add(lbTitulo);
            Name = "TelaPrincipal";
            Text = "Compartilhamento de Arquivos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nPorta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Button btnConexao;
        private Button btnParar;
        private TextBox txbEndereco;
        private NumericUpDown nPorta;
        private LinkLabel lbPasta;
        private ListBox lbLog;
    }
}
