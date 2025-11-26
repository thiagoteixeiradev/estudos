namespace _36.GdiPlus
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
            picbImagem = new System.Windows.Forms.PictureBox();
            BtnDesenhar = new System.Windows.Forms.Button();
            btnLinhas = new System.Windows.Forms.Button();
            btnVariasLinhas = new System.Windows.Forms.Button();
            btnVLina = new System.Windows.Forms.Button();
            btnRetP = new System.Windows.Forms.Button();
            btnRetV = new System.Windows.Forms.Button();
            btnElipseVazio = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btnPolP = new System.Windows.Forms.Button();
            btnPolV = new System.Windows.Forms.Button();
            btnCurvaV = new System.Windows.Forms.Button();
            btnCurvaP = new System.Windows.Forms.Button();
            btnArco = new System.Windows.Forms.Button();
            btnBezier = new System.Windows.Forms.Button();
            btnGraficoPie = new System.Windows.Forms.Button();
            btnGPath = new System.Windows.Forms.Button();
            btnString = new System.Windows.Forms.Button();
            btnImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)picbImagem).BeginInit();
            SuspendLayout();
            // 
            // picbImagem
            // 
            picbImagem.Location = new System.Drawing.Point(12, 12);
            picbImagem.Name = "picbImagem";
            picbImagem.Size = new System.Drawing.Size(462, 354);
            picbImagem.TabIndex = 0;
            picbImagem.TabStop = false;
            // 
            // BtnDesenhar
            // 
            BtnDesenhar.Location = new System.Drawing.Point(480, 12);
            BtnDesenhar.Name = "BtnDesenhar";
            BtnDesenhar.Size = new System.Drawing.Size(146, 23);
            BtnDesenhar.TabIndex = 1;
            BtnDesenhar.Text = "Nova Página";
            BtnDesenhar.UseVisualStyleBackColor = true;
            BtnDesenhar.Click += BtnDesenhar_Click;
            // 
            // btnLinhas
            // 
            btnLinhas.Location = new System.Drawing.Point(480, 41);
            btnLinhas.Name = "btnLinhas";
            btnLinhas.Size = new System.Drawing.Size(146, 23);
            btnLinhas.TabIndex = 2;
            btnLinhas.Text = "Linhas";
            btnLinhas.UseVisualStyleBackColor = true;
            btnLinhas.Click += btnLinhas_Click;
            // 
            // btnVariasLinhas
            // 
            btnVariasLinhas.Location = new System.Drawing.Point(480, 70);
            btnVariasLinhas.Name = "btnVariasLinhas";
            btnVariasLinhas.Size = new System.Drawing.Size(146, 23);
            btnVariasLinhas.TabIndex = 3;
            btnVariasLinhas.Text = "Linhas em Sequencia";
            btnVariasLinhas.UseVisualStyleBackColor = true;
            btnVariasLinhas.Click += btnVariasLinhas_Click;
            // 
            // btnVLina
            // 
            btnVLina.Location = new System.Drawing.Point(480, 99);
            btnVLina.Name = "btnVLina";
            btnVLina.Size = new System.Drawing.Size(146, 23);
            btnVLina.TabIndex = 4;
            btnVLina.Text = "Várias Linhas";
            btnVLina.UseVisualStyleBackColor = true;
            btnVLina.Click += btnVLina_Click;
            // 
            // btnRetP
            // 
            btnRetP.Location = new System.Drawing.Point(480, 157);
            btnRetP.Name = "btnRetP";
            btnRetP.Size = new System.Drawing.Size(146, 23);
            btnRetP.TabIndex = 5;
            btnRetP.Text = "Retangulo Preenchido";
            btnRetP.UseVisualStyleBackColor = true;
            btnRetP.Click += btnRetP_Click;
            // 
            // btnRetV
            // 
            btnRetV.Location = new System.Drawing.Point(480, 128);
            btnRetV.Name = "btnRetV";
            btnRetV.Size = new System.Drawing.Size(146, 23);
            btnRetV.TabIndex = 6;
            btnRetV.Text = "Retangulo Vazio";
            btnRetV.UseVisualStyleBackColor = true;
            btnRetV.Click += btnRetV_Click;
            // 
            // btnElipseVazio
            // 
            btnElipseVazio.Location = new System.Drawing.Point(480, 186);
            btnElipseVazio.Name = "btnElipseVazio";
            btnElipseVazio.Size = new System.Drawing.Size(146, 23);
            btnElipseVazio.TabIndex = 7;
            btnElipseVazio.Text = "Elipse Vazio";
            btnElipseVazio.UseVisualStyleBackColor = true;
            btnElipseVazio.Click += btnElipseVazio_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(480, 215);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(146, 23);
            button2.TabIndex = 8;
            button2.Text = "Elipse Preenchido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPolP
            // 
            btnPolP.Location = new System.Drawing.Point(480, 273);
            btnPolP.Name = "btnPolP";
            btnPolP.Size = new System.Drawing.Size(146, 23);
            btnPolP.TabIndex = 9;
            btnPolP.Text = "Poligno Preenchido";
            btnPolP.UseVisualStyleBackColor = true;
            btnPolP.Click += btnPolP_Click;
            // 
            // btnPolV
            // 
            btnPolV.Location = new System.Drawing.Point(480, 244);
            btnPolV.Name = "btnPolV";
            btnPolV.Size = new System.Drawing.Size(146, 23);
            btnPolV.TabIndex = 10;
            btnPolV.Text = "Poligno Vazio";
            btnPolV.UseVisualStyleBackColor = true;
            btnPolV.Click += btnPolV_Click;
            // 
            // btnCurvaV
            // 
            btnCurvaV.Location = new System.Drawing.Point(480, 302);
            btnCurvaV.Name = "btnCurvaV";
            btnCurvaV.Size = new System.Drawing.Size(146, 23);
            btnCurvaV.TabIndex = 11;
            btnCurvaV.Text = "Curva Vazia";
            btnCurvaV.UseVisualStyleBackColor = true;
            btnCurvaV.Click += btnCurvaV_Click;
            // 
            // btnCurvaP
            // 
            btnCurvaP.Location = new System.Drawing.Point(480, 331);
            btnCurvaP.Name = "btnCurvaP";
            btnCurvaP.Size = new System.Drawing.Size(146, 23);
            btnCurvaP.TabIndex = 12;
            btnCurvaP.Text = "Curva Preenchida";
            btnCurvaP.UseVisualStyleBackColor = true;
            btnCurvaP.Click += btnCurvaP_Click;
            // 
            // btnArco
            // 
            btnArco.Location = new System.Drawing.Point(632, 12);
            btnArco.Name = "btnArco";
            btnArco.Size = new System.Drawing.Size(146, 23);
            btnArco.TabIndex = 13;
            btnArco.Text = "Arcos";
            btnArco.UseVisualStyleBackColor = true;
            btnArco.Click += btnArco_Click;
            // 
            // btnBezier
            // 
            btnBezier.Location = new System.Drawing.Point(632, 41);
            btnBezier.Name = "btnBezier";
            btnBezier.Size = new System.Drawing.Size(146, 23);
            btnBezier.TabIndex = 14;
            btnBezier.Text = "Beziers";
            btnBezier.UseVisualStyleBackColor = true;
            btnBezier.Click += btnBezier_Click;
            // 
            // btnGraficoPie
            // 
            btnGraficoPie.Location = new System.Drawing.Point(632, 70);
            btnGraficoPie.Name = "btnGraficoPie";
            btnGraficoPie.Size = new System.Drawing.Size(146, 23);
            btnGraficoPie.TabIndex = 15;
            btnGraficoPie.Text = "Grafico Fatias";
            btnGraficoPie.UseVisualStyleBackColor = true;
            btnGraficoPie.Click += btnGraficoPie_Click;
            // 
            // btnGPath
            // 
            btnGPath.Location = new System.Drawing.Point(632, 99);
            btnGPath.Name = "btnGPath";
            btnGPath.Size = new System.Drawing.Size(146, 23);
            btnGPath.TabIndex = 16;
            btnGPath.Text = "Grafico Path";
            btnGPath.UseVisualStyleBackColor = true;
            btnGPath.Click += btnGPath_Click;
            // 
            // btnString
            // 
            btnString.Location = new System.Drawing.Point(632, 128);
            btnString.Name = "btnString";
            btnString.Size = new System.Drawing.Size(146, 23);
            btnString.TabIndex = 17;
            btnString.Text = "String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnImagem
            // 
            btnImagem.Location = new System.Drawing.Point(632, 157);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new System.Drawing.Size(146, 23);
            btnImagem.TabIndex = 18;
            btnImagem.Text = "Imagem";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(830, 372);
            Controls.Add(btnImagem);
            Controls.Add(btnString);
            Controls.Add(btnGPath);
            Controls.Add(btnGraficoPie);
            Controls.Add(btnBezier);
            Controls.Add(btnArco);
            Controls.Add(btnCurvaP);
            Controls.Add(btnCurvaV);
            Controls.Add(btnPolV);
            Controls.Add(btnPolP);
            Controls.Add(button2);
            Controls.Add(btnElipseVazio);
            Controls.Add(btnRetV);
            Controls.Add(btnRetP);
            Controls.Add(btnVLina);
            Controls.Add(btnVariasLinhas);
            Controls.Add(btnLinhas);
            Controls.Add(BtnDesenhar);
            Controls.Add(picbImagem);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "GdiPlus";
            ((System.ComponentModel.ISupportInitialize)picbImagem).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbImagem;
        private System.Windows.Forms.Button BtnDesenhar;
        private System.Windows.Forms.Button btnLinhas;
        private System.Windows.Forms.Button btnVariasLinhas;
        private System.Windows.Forms.Button btnVLina;
        private System.Windows.Forms.Button btnRetP;
        private System.Windows.Forms.Button btnRetV;
        private System.Windows.Forms.Button btnElipseVazio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPolP;
        private System.Windows.Forms.Button btnPolV;
        private System.Windows.Forms.Button btnCurvaV;
        private System.Windows.Forms.Button btnCurvaP;
        private System.Windows.Forms.Button btnArco;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnGraficoPie;
        private System.Windows.Forms.Button btnGPath;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnImagem;
    }
}

