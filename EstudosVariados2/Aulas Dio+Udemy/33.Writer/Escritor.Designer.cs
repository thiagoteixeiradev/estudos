namespace Writer
{
    partial class Escritor
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
            this.txbConteudo = new System.Windows.Forms.TextBox();
            this.btnEscrever = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnLerBinario = new System.Windows.Forms.Button();
            this.btnEscreverBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbConteudo
            // 
            this.txbConteudo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConteudo.Location = new System.Drawing.Point(0, 0);
            this.txbConteudo.Multiline = true;
            this.txbConteudo.Name = "txbConteudo";
            this.txbConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbConteudo.Size = new System.Drawing.Size(623, 294);
            this.txbConteudo.TabIndex = 0;
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(12, 300);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(75, 23);
            this.btnEscrever.TabIndex = 1;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(93, 300);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLerBinario
            // 
            this.btnLerBinario.Location = new System.Drawing.Point(255, 300);
            this.btnLerBinario.Name = "btnLerBinario";
            this.btnLerBinario.Size = new System.Drawing.Size(75, 23);
            this.btnLerBinario.TabIndex = 3;
            this.btnLerBinario.Text = "Ler Binario";
            this.btnLerBinario.UseVisualStyleBackColor = true;
            this.btnLerBinario.Click += new System.EventHandler(this.btnLerBinario_Click);
            // 
            // btnEscreverBin
            // 
            this.btnEscreverBin.Location = new System.Drawing.Point(174, 300);
            this.btnEscreverBin.Name = "btnEscreverBin";
            this.btnEscreverBin.Size = new System.Drawing.Size(75, 23);
            this.btnEscreverBin.TabIndex = 4;
            this.btnEscreverBin.Text = "Escrever Binario";
            this.btnEscreverBin.UseVisualStyleBackColor = true;
            this.btnEscreverBin.Click += new System.EventHandler(this.btnEscreverBin_Click);
            // 
            // Escritor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 331);
            this.Controls.Add(this.btnEscreverBin);
            this.Controls.Add(this.btnLerBinario);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnEscrever);
            this.Controls.Add(this.txbConteudo);
            this.Name = "Escritor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbConteudo;
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnLerBinario;
        private System.Windows.Forms.Button btnEscreverBin;
    }
}

