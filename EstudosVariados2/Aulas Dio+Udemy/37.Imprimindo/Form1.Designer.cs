namespace _37.Imprimindo
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.CampoTexto = new System.Windows.Forms.RichTextBox();
            this.btnImprimirVarios = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.Visualizador = new System.Windows.Forms.PrintPreviewControl();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(318, 230);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // CampoTexto
            // 
            this.CampoTexto.Location = new System.Drawing.Point(12, 12);
            this.CampoTexto.Name = "CampoTexto";
            this.CampoTexto.Size = new System.Drawing.Size(300, 241);
            this.CampoTexto.TabIndex = 1;
            this.CampoTexto.Text = "";
            // 
            // btnImprimirVarios
            // 
            this.btnImprimirVarios.Location = new System.Drawing.Point(318, 184);
            this.btnImprimirVarios.Name = "btnImprimirVarios";
            this.btnImprimirVarios.Size = new System.Drawing.Size(75, 40);
            this.btnImprimirVarios.TabIndex = 2;
            this.btnImprimirVarios.Text = "Imprimir Vários";
            this.btnImprimirVarios.UseVisualStyleBackColor = true;
            this.btnImprimirVarios.Click += new System.EventHandler(this.btnImprimirVarios_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // Visualizador
            // 
            this.Visualizador.Location = new System.Drawing.Point(400, 12);
            this.Visualizador.Name = "Visualizador";
            this.Visualizador.Size = new System.Drawing.Size(255, 241);
            this.Visualizador.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(400, 250);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 22);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(566, 250);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(75, 22);
            this.btnProx.TabIndex = 6;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(485, 250);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 22);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 310);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Visualizador);
            this.Controls.Add(this.btnImprimirVarios);
            this.Controls.Add(this.CampoTexto);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RichTextBox CampoTexto;
        private System.Windows.Forms.Button btnImprimirVarios;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewControl Visualizador;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnVisualizar;
    }
}

