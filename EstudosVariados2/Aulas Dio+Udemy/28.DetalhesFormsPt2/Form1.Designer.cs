namespace _28.DetalhesFormsPt2
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
            this.cbCombo = new System.Windows.Forms.ComboBox();
            this.btnPegar = new System.Windows.Forms.Button();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.btnPegaData = new System.Windows.Forms.Button();
            this.Link1 = new System.Windows.Forms.LinkLabel();
            this.lista = new System.Windows.Forms.ListView();
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletarItem = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.btnPegaData2 = new System.Windows.Forms.Button();
            this.nNumeros = new System.Windows.Forms.NumericUpDown();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbN2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCombo
            // 
            this.cbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombo.FormattingEnabled = true;
            this.cbCombo.Location = new System.Drawing.Point(12, 12);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(191, 28);
            this.cbCombo.TabIndex = 0;
            this.cbCombo.Text = "-Selecione um Item-";
            // 
            // btnPegar
            // 
            this.btnPegar.Location = new System.Drawing.Point(209, 15);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(75, 23);
            this.btnPegar.TabIndex = 1;
            this.btnPegar.Text = "Pega Item";
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCalendario.Location = new System.Drawing.Point(12, 46);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(119, 26);
            this.dtpCalendario.TabIndex = 2;
            // 
            // btnPegaData
            // 
            this.btnPegaData.Location = new System.Drawing.Point(137, 51);
            this.btnPegaData.Name = "btnPegaData";
            this.btnPegaData.Size = new System.Drawing.Size(66, 23);
            this.btnPegaData.TabIndex = 3;
            this.btnPegaData.Text = "Pega Data";
            this.btnPegaData.UseVisualStyleBackColor = true;
            this.btnPegaData.Click += new System.EventHandler(this.btnPegaData_Click);
            // 
            // Link1
            // 
            this.Link1.AutoSize = true;
            this.Link1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link1.Location = new System.Drawing.Point(437, 9);
            this.Link1.Name = "Link1";
            this.Link1.Size = new System.Drawing.Size(87, 24);
            this.Link1.TabIndex = 4;
            this.Link1.TabStop = true;
            this.Link1.Text = "Meu Link";
            this.Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link1_LinkClicked);
            // 
            // lista
            // 
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colFone,
            this.colEmail});
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.GridLines = true;
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(12, 78);
            this.lista.Margin = new System.Windows.Forms.Padding(5);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(512, 168);
            this.lista.TabIndex = 5;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 200;
            // 
            // colFone
            // 
            this.colFone.Text = "Telefone";
            this.colFone.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 200;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(449, 254);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletarItem
            // 
            this.btnDeletarItem.Location = new System.Drawing.Point(368, 254);
            this.btnDeletarItem.Name = "btnDeletarItem";
            this.btnDeletarItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarItem.TabIndex = 7;
            this.btnDeletarItem.Text = "Deletar item";
            this.btnDeletarItem.UseVisualStyleBackColor = true;
            this.btnDeletarItem.Click += new System.EventHandler(this.btnDeletarItem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(220, 54);
            this.maskedTextBox1.Mask = "(99) 9 9999-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(12, 254);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 9;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // btnPegaData2
            // 
            this.btnPegaData2.Location = new System.Drawing.Point(251, 370);
            this.btnPegaData2.Name = "btnPegaData2";
            this.btnPegaData2.Size = new System.Drawing.Size(66, 42);
            this.btnPegaData2.TabIndex = 10;
            this.btnPegaData2.Text = "Pega Data 2";
            this.btnPegaData2.UseVisualStyleBackColor = true;
            this.btnPegaData2.Click += new System.EventHandler(this.btnPegaData2_Click);
            // 
            // nNumeros
            // 
            this.nNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNumeros.Location = new System.Drawing.Point(368, 283);
            this.nNumeros.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nNumeros.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nNumeros.Name = "nNumeros";
            this.nNumeros.Size = new System.Drawing.Size(120, 26);
            this.nNumeros.TabIndex = 11;
            this.nNumeros.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nNumeros.ValueChanged += new System.EventHandler(this.nNumeros_ValueChanged);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(495, 284);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(0, 20);
            this.lbNumero.TabIndex = 12;
            // 
            // lbN2
            // 
            this.lbN2.AutoSize = true;
            this.lbN2.Location = new System.Drawing.Point(368, 316);
            this.lbN2.Name = "lbN2";
            this.lbN2.Size = new System.Drawing.Size(0, 13);
            this.lbN2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 424);
            this.Controls.Add(this.lbN2);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.nNumeros);
            this.Controls.Add(this.btnPegaData2);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnDeletarItem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Link1);
            this.Controls.Add(this.btnPegaData);
            this.Controls.Add(this.dtpCalendario);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.cbCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCombo;
        private System.Windows.Forms.Button btnPegar;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.Button btnPegaData;
        private System.Windows.Forms.LinkLabel Link1;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colFone;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletarItem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Button btnPegaData2;
        private System.Windows.Forms.NumericUpDown nNumeros;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbN2;
    }
}

