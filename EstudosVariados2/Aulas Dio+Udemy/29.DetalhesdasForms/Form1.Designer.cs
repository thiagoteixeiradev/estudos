namespace _29.DetalhesdasForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Filho principal");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Filho Segundo");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Segunda");
            this.picb = new System.Windows.Forms.PictureBox();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btnAcressentar = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.RadioButton();
            this.btn20 = new System.Windows.Forms.RadioButton();
            this.btn30 = new System.Windows.Forms.RadioButton();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tv1 = new System.Windows.Forms.TreeView();
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.txbLink = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.SuspendLayout();
            // 
            // picb
            // 
            this.picb.BackgroundImage = global::_29.DetalhesdasForms.Properties.Resources._4ac7aa163b76c6fa0b4cef7297a6a2f9;
            this.picb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picb.Image = global::_29.DetalhesdasForms.Properties.Resources._5d8380350174cb734a228d43f8d70f62;
            this.picb.InitialImage = ((System.Drawing.Image)(resources.GetObject("picb.InitialImage")));
            this.picb.Location = new System.Drawing.Point(12, 12);
            this.picb.Margin = new System.Windows.Forms.Padding(0);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(191, 176);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb.TabIndex = 0;
            this.picb.TabStop = false;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(206, 12);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(350, 23);
            this.pbar.Step = 30;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.pbar, "Barra de progresso\r\n");
            // 
            // btnAcressentar
            // 
            this.btnAcressentar.Location = new System.Drawing.Point(206, 41);
            this.btnAcressentar.Name = "btnAcressentar";
            this.btnAcressentar.Size = new System.Drawing.Size(75, 23);
            this.btnAcressentar.TabIndex = 2;
            this.btnAcressentar.Text = "Acresentar";
            this.toolTip1.SetToolTip(this.btnAcressentar, "Irá acrescentar valor a barra de progresso\r\n");
            this.btnAcressentar.UseVisualStyleBackColor = true;
            this.btnAcressentar.Click += new System.EventHandler(this.btnAcressentar_Click);
            // 
            // btn10
            // 
            this.btn10.AutoSize = true;
            this.btn10.Location = new System.Drawing.Point(287, 41);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(43, 17);
            this.btn10.TabIndex = 3;
            this.btn10.TabStop = true;
            this.btn10.Text = "+10";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.AutoSize = true;
            this.btn20.Location = new System.Drawing.Point(336, 41);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(43, 17);
            this.btn20.TabIndex = 4;
            this.btn20.TabStop = true;
            this.btn20.Text = "+20";
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.AutoSize = true;
            this.btn30.Location = new System.Drawing.Point(385, 41);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(43, 17);
            this.btn30.TabIndex = 5;
            this.btn30.TabStop = true;
            this.btn30.Text = "+30";
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // rtxt
            // 
            this.rtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt.Location = new System.Drawing.Point(206, 70);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(348, 118);
            this.rtxt.TabIndex = 6;
            this.rtxt.Text = "";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // tv1
            // 
            this.tv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv1.HotTracking = true;
            this.tv1.LineColor = System.Drawing.Color.SteelBlue;
            this.tv1.Location = new System.Drawing.Point(12, 194);
            this.tv1.Name = "tv1";
            treeNode13.Name = "fpPrimeiro";
            treeNode13.Text = "Filho principal";
            treeNode14.Name = "fpSegundo";
            treeNode14.Text = "Filho Segundo";
            treeNode15.Name = "rPrimeira";
            treeNode15.Text = "Principal";
            treeNode16.Name = "rSegunda";
            treeNode16.Text = "Segunda";
            this.tv1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            this.tv1.ShowNodeToolTips = true;
            this.tv1.Size = new System.Drawing.Size(191, 173);
            this.tv1.TabIndex = 7;
            this.tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // navegador
            // 
            this.navegador.IsWebBrowserContextMenuEnabled = false;
            this.navegador.Location = new System.Drawing.Point(209, 242);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(347, 250);
            this.navegador.TabIndex = 8;
            this.navegador.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnNavegar
            // 
            this.btnNavegar.Location = new System.Drawing.Point(479, 203);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(75, 23);
            this.btnNavegar.TabIndex = 9;
            this.btnNavegar.Text = "Navegar";
            this.toolTip1.SetToolTip(this.btnNavegar, "Irá acrescentar valor a barra de progresso\r\n");
            this.btnNavegar.UseVisualStyleBackColor = true;
            this.btnNavegar.Click += new System.EventHandler(this.btnNavegar_Click);
            // 
            // txbLink
            // 
            this.txbLink.Location = new System.Drawing.Point(209, 203);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(264, 20);
            this.txbLink.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 504);
            this.Controls.Add(this.txbLink);
            this.Controls.Add(this.btnNavegar);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.tv1);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnAcressentar);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.picb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picb;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Button btnAcressentar;
        private System.Windows.Forms.RadioButton btn10;
        private System.Windows.Forms.RadioButton btn20;
        private System.Windows.Forms.RadioButton btn30;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.WebBrowser navegador;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.TextBox txbLink;
    }
}

