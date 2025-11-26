namespace Arquivos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.q = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnDirDel = new System.Windows.Forms.Button();
            this.btnDireMov = new System.Windows.Forms.Button();
            this.btnDirInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(147, 16);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(137, 31);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "Resultado";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(16, 63);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(131, 50);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(153, 63);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(131, 50);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(290, 63);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(131, 50);
            this.btnCriar.TabIndex = 3;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(16, 119);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(131, 50);
            this.q.TabIndex = 4;
            this.q.Text = "Copiar";
            this.q.UseVisualStyleBackColor = true;
            this.q.Click += new System.EventHandler(this.q_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(153, 119);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(131, 50);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(290, 119);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(131, 50);
            this.btnLer.TabIndex = 6;
            this.btnLer.Text = "Ler Arquivo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResultado);
            this.groupBox1.Controls.Add(this.btnLer);
            this.groupBox1.Controls.Add(this.btnExecutar);
            this.groupBox1.Controls.Add(this.btnMover);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.q);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações  Com Arquivos";
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.Location = new System.Drawing.Point(681, 178);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(131, 50);
            this.btnFileInfo.TabIndex = 7;
            this.btnFileInfo.Text = "File Info";
            this.btnFileInfo.UseVisualStyleBackColor = true;
            this.btnFileInfo.Click += new System.EventHandler(this.btnFileInfo_Click);
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Location = new System.Drawing.Point(454, 28);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(358, 144);
            this.lista.TabIndex = 8;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(544, 178);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(131, 50);
            this.btnDir.TabIndex = 9;
            this.btnDir.Text = "Diretorio Info";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDirInfo_Click);
            // 
            // btnDirDel
            // 
            this.btnDirDel.Location = new System.Drawing.Point(454, 178);
            this.btnDirDel.Name = "btnDirDel";
            this.btnDirDel.Size = new System.Drawing.Size(84, 50);
            this.btnDirDel.TabIndex = 10;
            this.btnDirDel.Text = "Diretorio Del";
            this.btnDirDel.UseVisualStyleBackColor = true;
            this.btnDirDel.Click += new System.EventHandler(this.btnDirDel_Click);
            // 
            // btnDireMov
            // 
            this.btnDireMov.Location = new System.Drawing.Point(454, 231);
            this.btnDireMov.Name = "btnDireMov";
            this.btnDireMov.Size = new System.Drawing.Size(84, 50);
            this.btnDireMov.TabIndex = 11;
            this.btnDireMov.Text = "Diretorio Mov";
            this.btnDireMov.UseVisualStyleBackColor = true;
            this.btnDireMov.Click += new System.EventHandler(this.btnDireMov_Click);
            // 
            // btnDirInfo
            // 
            this.btnDirInfo.Location = new System.Drawing.Point(544, 231);
            this.btnDirInfo.Name = "btnDirInfo";
            this.btnDirInfo.Size = new System.Drawing.Size(131, 50);
            this.btnDirInfo.TabIndex = 12;
            this.btnDirInfo.Text = "Diretorio Info";
            this.btnDirInfo.UseVisualStyleBackColor = true;
            this.btnDirInfo.Click += new System.EventHandler(this.btnDirInfo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 293);
            this.Controls.Add(this.btnDirInfo);
            this.Controls.Add(this.btnDireMov);
            this.Controls.Add(this.btnDirDel);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnFileInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arquivos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button q;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFileInfo;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnDirDel;
        private System.Windows.Forms.Button btnDireMov;
        private System.Windows.Forms.Button btnDirInfo;
    }
}

