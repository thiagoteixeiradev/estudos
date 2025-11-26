namespace LINQ
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
            this.lista = new System.Windows.Forms.ListBox();
            this.txbConsulta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOrdenarNomes = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnPesquisarNomes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarProdutos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgruparEstados = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnAgregacao = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnOpElemento = new System.Windows.Forms.Button();
            this.btnLinqLambda = new System.Windows.Forms.Button();
            this.btnLingLamdbaWhere = new System.Windows.Forms.Button();
            this.btnLamdbaEstados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.HorizontalScrollbar = true;
            this.lista.ItemHeight = 24;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(307, 292);
            this.lista.TabIndex = 0;
            // 
            // txbConsulta
            // 
            this.txbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsulta.Location = new System.Drawing.Point(325, 12);
            this.txbConsulta.Name = "txbConsulta";
            this.txbConsulta.Size = new System.Drawing.Size(308, 26);
            this.txbConsulta.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLingLamdbaWhere);
            this.groupBox1.Controls.Add(this.btnLinqLambda);
            this.groupBox1.Controls.Add(this.btnMaior);
            this.groupBox1.Controls.Add(this.btnAgregacao);
            this.groupBox1.Controls.Add(this.BtnOrdenarNomes);
            this.groupBox1.Controls.Add(this.btnWhere);
            this.groupBox1.Controls.Add(this.btnPesquisarNomes);
            this.groupBox1.Location = new System.Drawing.Point(325, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nomes";
            // 
            // BtnOrdenarNomes
            // 
            this.BtnOrdenarNomes.Location = new System.Drawing.Point(6, 79);
            this.BtnOrdenarNomes.Name = "BtnOrdenarNomes";
            this.BtnOrdenarNomes.Size = new System.Drawing.Size(128, 24);
            this.BtnOrdenarNomes.TabIndex = 10;
            this.BtnOrdenarNomes.Text = "Ordernar Nomes";
            this.BtnOrdenarNomes.UseVisualStyleBackColor = true;
            this.BtnOrdenarNomes.Click += new System.EventHandler(this.BtnOrdenarNomes_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(6, 49);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(128, 24);
            this.btnWhere.TabIndex = 9;
            this.btnWhere.Text = "Pesquisar Nome";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnPesquisarNomes
            // 
            this.btnPesquisarNomes.Location = new System.Drawing.Point(6, 19);
            this.btnPesquisarNomes.Name = "btnPesquisarNomes";
            this.btnPesquisarNomes.Size = new System.Drawing.Size(128, 24);
            this.btnPesquisarNomes.TabIndex = 8;
            this.btnPesquisarNomes.Text = "Pesquisar Primeiro Nome";
            this.btnPesquisarNomes.UseVisualStyleBackColor = true;
            this.btnPesquisarNomes.Click += new System.EventHandler(this.btnPesquisarNomes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrdenarProdutos);
            this.groupBox2.Location = new System.Drawing.Point(688, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 259);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btnOrdenarProdutos
            // 
            this.btnOrdenarProdutos.Location = new System.Drawing.Point(11, 19);
            this.btnOrdenarProdutos.Name = "btnOrdenarProdutos";
            this.btnOrdenarProdutos.Size = new System.Drawing.Size(123, 24);
            this.btnOrdenarProdutos.TabIndex = 12;
            this.btnOrdenarProdutos.Text = "Ordernar Produtos";
            this.btnOrdenarProdutos.UseVisualStyleBackColor = true;
            this.btnOrdenarProdutos.Click += new System.EventHandler(this.btnOrdenarProdutos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLamdbaEstados);
            this.groupBox3.Controls.Add(this.btnAgruparEstados);
            this.groupBox3.Location = new System.Drawing.Point(845, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 259);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estados";
            // 
            // btnAgruparEstados
            // 
            this.btnAgruparEstados.Location = new System.Drawing.Point(20, 19);
            this.btnAgruparEstados.Name = "btnAgruparEstados";
            this.btnAgruparEstados.Size = new System.Drawing.Size(151, 24);
            this.btnAgruparEstados.TabIndex = 13;
            this.btnAgruparEstados.Text = "Agrupar Estados";
            this.btnAgruparEstados.UseVisualStyleBackColor = true;
            this.btnAgruparEstados.Click += new System.EventHandler(this.btnAgruparEstados_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOpElemento);
            this.groupBox4.Controls.Add(this.btnMinMax);
            this.groupBox4.Controls.Add(this.btnSoma);
            this.groupBox4.Controls.Add(this.btnMedia);
            this.groupBox4.Controls.Add(this.btnOrderBy);
            this.groupBox4.Controls.Add(this.btnImpares);
            this.groupBox4.Controls.Add(this.btnExecutar);
            this.groupBox4.Location = new System.Drawing.Point(482, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 259);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Numeros";
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(20, 19);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(151, 24);
            this.btnOrderBy.TabIndex = 15;
            this.btnOrderBy.Text = "Ordernar Numeros";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(20, 49);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(151, 24);
            this.btnImpares.TabIndex = 14;
            this.btnImpares.Text = "Pesquisar Numeros Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(20, 79);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(151, 24);
            this.btnExecutar.TabIndex = 13;
            this.btnExecutar.Text = "Pesquisar Numeros Pares";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // btnAgregacao
            // 
            this.btnAgregacao.Location = new System.Drawing.Point(9, 109);
            this.btnAgregacao.Name = "btnAgregacao";
            this.btnAgregacao.Size = new System.Drawing.Size(123, 47);
            this.btnAgregacao.TabIndex = 13;
            this.btnAgregacao.Text = "Nomes Começando com R";
            this.btnAgregacao.UseVisualStyleBackColor = true;
            this.btnAgregacao.Click += new System.EventHandler(this.btnAgregacao_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(20, 109);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(151, 24);
            this.btnMedia.TabIndex = 16;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(20, 139);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(151, 24);
            this.btnSoma.TabIndex = 17;
            this.btnSoma.Text = "Somar Valores < 50";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(20, 169);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(151, 24);
            this.btnMinMax.TabIndex = 18;
            this.btnMinMax.Text = "Valor maior e menor";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnMaior
            // 
            this.btnMaior.Location = new System.Drawing.Point(6, 162);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(128, 24);
            this.btnMaior.TabIndex = 14;
            this.btnMaior.Text = "Maior Nome";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnOpElemento
            // 
            this.btnOpElemento.Location = new System.Drawing.Point(20, 199);
            this.btnOpElemento.Name = "btnOpElemento";
            this.btnOpElemento.Size = new System.Drawing.Size(151, 24);
            this.btnOpElemento.TabIndex = 15;
            this.btnOpElemento.Text = "Ultimo e primeiro";
            this.btnOpElemento.UseVisualStyleBackColor = true;
            this.btnOpElemento.Click += new System.EventHandler(this.btnOpElemento_Click);
            // 
            // btnLinqLambda
            // 
            this.btnLinqLambda.Location = new System.Drawing.Point(6, 192);
            this.btnLinqLambda.Name = "btnLinqLambda";
            this.btnLinqLambda.Size = new System.Drawing.Size(128, 24);
            this.btnLinqLambda.TabIndex = 15;
            this.btnLinqLambda.Text = "LinqLambda";
            this.btnLinqLambda.UseVisualStyleBackColor = true;
            this.btnLinqLambda.Click += new System.EventHandler(this.btnLinqLambda_Click);
            // 
            // btnLingLamdbaWhere
            // 
            this.btnLingLamdbaWhere.Location = new System.Drawing.Point(9, 222);
            this.btnLingLamdbaWhere.Name = "btnLingLamdbaWhere";
            this.btnLingLamdbaWhere.Size = new System.Drawing.Size(128, 54);
            this.btnLingLamdbaWhere.TabIndex = 16;
            this.btnLingLamdbaWhere.Text = "Nomes com a Letra R LINQ+Lambda";
            this.btnLingLamdbaWhere.UseVisualStyleBackColor = true;
            this.btnLingLamdbaWhere.Click += new System.EventHandler(this.btnLingLamdbaWhere_Click);
            // 
            // btnLamdbaEstados
            // 
            this.btnLamdbaEstados.Location = new System.Drawing.Point(20, 49);
            this.btnLamdbaEstados.Name = "btnLamdbaEstados";
            this.btnLamdbaEstados.Size = new System.Drawing.Size(151, 24);
            this.btnLamdbaEstados.TabIndex = 14;
            this.btnLamdbaEstados.Text = "Agrupar Estados";
            this.btnLamdbaEstados.UseVisualStyleBackColor = true;
            this.btnLamdbaEstados.Click += new System.EventHandler(this.btnLamdbaEstados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 339);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbConsulta);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox txbConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOrdenarNomes;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnPesquisarNomes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdenarProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgruparEstados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnAgregacao;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnOpElemento;
        private System.Windows.Forms.Button btnLinqLambda;
        private System.Windows.Forms.Button btnLingLamdbaWhere;
        private System.Windows.Forms.Button btnLamdbaEstados;
    }
}

