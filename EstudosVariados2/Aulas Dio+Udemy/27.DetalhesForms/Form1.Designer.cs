namespace _27.DetalhesForms
{
    partial class btnRemoverTudo
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
            this.lbNome = new System.Windows.Forms.Label();
            this.txbNomes = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.ckbGamer = new System.Windows.Forms.CheckBox();
            this.ckbOtaku = new System.Windows.Forms.CheckBox();
            this.ckbMaromba = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listaBox = new System.Windows.Forms.CheckedListBox();
            this.btnCheckListBox = new System.Windows.Forms.Button();
            this.btnLimparCkb = new System.Windows.Forms.Button();
            this.btnConferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNome.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(136, 73);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Romário";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            this.lbNome.MouseEnter += new System.EventHandler(this.lbNome_MouseEnter);
            this.lbNome.MouseLeave += new System.EventHandler(this.lbNome_MouseLeave);
            // 
            // txbNomes
            // 
            this.txbNomes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomes.Location = new System.Drawing.Point(12, 85);
            this.txbNomes.Name = "txbNomes";
            this.txbNomes.Size = new System.Drawing.Size(207, 29);
            this.txbNomes.TabIndex = 1;
            this.txbNomes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 18;
            this.lista.Items.AddRange(new object[] {
            "Romario",
            "Dany",
            "Berto",
            "Alberto"});
            this.lista.Location = new System.Drawing.Point(14, 120);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(205, 166);
            this.lista.TabIndex = 2;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(225, 134);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(68, 40);
            this.btnRemoverItem.TabIndex = 4;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remover Tudo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(225, 258);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(68, 28);
            this.btnContar.TabIndex = 6;
            this.btnContar.Text = "Contar Itens";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // ckbGamer
            // 
            this.ckbGamer.AutoSize = true;
            this.ckbGamer.Location = new System.Drawing.Point(325, 195);
            this.ckbGamer.Name = "ckbGamer";
            this.ckbGamer.Size = new System.Drawing.Size(108, 17);
            this.ckbGamer.TabIndex = 7;
            this.ckbGamer.Text = "Ou você é gamer";
            this.ckbGamer.UseVisualStyleBackColor = true;
            // 
            // ckbOtaku
            // 
            this.ckbOtaku.AutoSize = true;
            this.ckbOtaku.Location = new System.Drawing.Point(325, 218);
            this.ckbOtaku.Name = "ckbOtaku";
            this.ckbOtaku.Size = new System.Drawing.Size(79, 17);
            this.ckbOtaku.TabIndex = 8;
            this.ckbOtaku.Text = "Ou é otaku";
            this.ckbOtaku.UseVisualStyleBackColor = true;
            // 
            // ckbMaromba
            // 
            this.ckbMaromba.AutoSize = true;
            this.ckbMaromba.Location = new System.Drawing.Point(325, 241);
            this.ckbMaromba.Name = "ckbMaromba";
            this.ckbMaromba.Size = new System.Drawing.Size(95, 17);
            this.ckbMaromba.TabIndex = 9;
            this.ckbMaromba.Text = "Ou é maromba";
            this.ckbMaromba.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Checkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listaBox
            // 
            this.listaBox.CheckOnClick = true;
            this.listaBox.FormattingEnabled = true;
            this.listaBox.Items.AddRange(new object[] {
            "Bike",
            "Moto",
            "Patinete",
            "Barco",
            "Carro",
            "Avião",
            "Jatinho"});
            this.listaBox.Location = new System.Drawing.Point(313, 9);
            this.listaBox.Name = "listaBox";
            this.listaBox.Size = new System.Drawing.Size(120, 109);
            this.listaBox.TabIndex = 11;
            // 
            // btnCheckListBox
            // 
            this.btnCheckListBox.Location = new System.Drawing.Point(376, 124);
            this.btnCheckListBox.Name = "btnCheckListBox";
            this.btnCheckListBox.Size = new System.Drawing.Size(57, 28);
            this.btnCheckListBox.TabIndex = 12;
            this.btnCheckListBox.Text = "Checkar";
            this.btnCheckListBox.UseVisualStyleBackColor = true;
            this.btnCheckListBox.Click += new System.EventHandler(this.btnCheckListBox_Click);
            // 
            // btnLimparCkb
            // 
            this.btnLimparCkb.Location = new System.Drawing.Point(314, 124);
            this.btnLimparCkb.Name = "btnLimparCkb";
            this.btnLimparCkb.Size = new System.Drawing.Size(57, 28);
            this.btnLimparCkb.TabIndex = 13;
            this.btnLimparCkb.Text = "Limpar";
            this.btnLimparCkb.UseVisualStyleBackColor = true;
            this.btnLimparCkb.Click += new System.EventHandler(this.btnLimparCkb_Click);
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(314, 155);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(119, 28);
            this.btnConferir.TabIndex = 14;
            this.btnConferir.Text = "Conferir";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // btnRemoverTudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 304);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.btnLimparCkb);
            this.Controls.Add(this.btnCheckListBox);
            this.Controls.Add(this.listaBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ckbMaromba);
            this.Controls.Add(this.ckbOtaku);
            this.Controls.Add(this.ckbGamer);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.txbNomes);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "btnRemoverTudo";
            this.Text = "Elementos do Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txbNomes;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.CheckBox ckbGamer;
        private System.Windows.Forms.CheckBox ckbOtaku;
        private System.Windows.Forms.CheckBox ckbMaromba;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox listaBox;
        private System.Windows.Forms.Button btnCheckListBox;
        private System.Windows.Forms.Button btnLimparCkb;
        private System.Windows.Forms.Button btnConferir;
    }
}

