namespace Colecoes_Forms
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
            this.btnList = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnDic = new System.Windows.Forms.Button();
            this.btnSorted = new System.Windows.Forms.Button();
            this.btnSortDic = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnFila = new System.Windows.Forms.Button();
            this.btnPilha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(446, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(99, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(12, 12);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(428, 316);
            this.Lista.TabIndex = 1;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(446, 41);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(99, 23);
            this.btnHash.TabIndex = 2;
            this.btnHash.Text = "HashSet";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnDic
            // 
            this.btnDic.Location = new System.Drawing.Point(446, 70);
            this.btnDic.Name = "btnDic";
            this.btnDic.Size = new System.Drawing.Size(99, 23);
            this.btnDic.TabIndex = 3;
            this.btnDic.Text = "Dicionario";
            this.btnDic.UseVisualStyleBackColor = true;
            this.btnDic.Click += new System.EventHandler(this.btnDic_Click);
            // 
            // btnSorted
            // 
            this.btnSorted.Location = new System.Drawing.Point(446, 99);
            this.btnSorted.Name = "btnSorted";
            this.btnSorted.Size = new System.Drawing.Size(99, 23);
            this.btnSorted.TabIndex = 4;
            this.btnSorted.Text = "SortedList";
            this.btnSorted.UseVisualStyleBackColor = true;
            this.btnSorted.Click += new System.EventHandler(this.btnSorted_Click);
            // 
            // btnSortDic
            // 
            this.btnSortDic.Location = new System.Drawing.Point(446, 128);
            this.btnSortDic.Name = "btnSortDic";
            this.btnSortDic.Size = new System.Drawing.Size(99, 23);
            this.btnSortDic.TabIndex = 5;
            this.btnSortDic.Text = "SortedDicionario";
            this.btnSortDic.UseVisualStyleBackColor = true;
            this.btnSortDic.Click += new System.EventHandler(this.btnSortDic_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.Location = new System.Drawing.Point(446, 157);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(99, 23);
            this.btnSortedSet.TabIndex = 6;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.UseVisualStyleBackColor = true;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnFila
            // 
            this.btnFila.Location = new System.Drawing.Point(446, 186);
            this.btnFila.Name = "btnFila";
            this.btnFila.Size = new System.Drawing.Size(99, 23);
            this.btnFila.TabIndex = 7;
            this.btnFila.Text = "Fila";
            this.btnFila.UseVisualStyleBackColor = true;
            this.btnFila.Click += new System.EventHandler(this.btnFila_Click);
            // 
            // btnPilha
            // 
            this.btnPilha.Location = new System.Drawing.Point(446, 215);
            this.btnPilha.Name = "btnPilha";
            this.btnPilha.Size = new System.Drawing.Size(99, 23);
            this.btnPilha.TabIndex = 8;
            this.btnPilha.Text = "Pilha";
            this.btnPilha.UseVisualStyleBackColor = true;
            this.btnPilha.Click += new System.EventHandler(this.btnPilha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 342);
            this.Controls.Add(this.btnPilha);
            this.Controls.Add(this.btnFila);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSortDic);
            this.Controls.Add(this.btnSorted);
            this.Controls.Add(this.btnDic);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnDic;
        private System.Windows.Forms.Button btnSorted;
        private System.Windows.Forms.Button btnSortDic;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnFila;
        private System.Windows.Forms.Button btnPilha;
    }
}

