namespace _24.Forms_Detalhes
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.btnSecundario = new System.Windows.Forms.Button();
            this.btnSegundaThread = new System.Windows.Forms.Button();
            this.btnFormNome = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmDev = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmVersao = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMenu = new System.Windows.Forms.ToolStripComboBox();
            this.txbPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipal.Location = new System.Drawing.Point(13, 43);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(363, 116);
            this.lbPrincipal.TabIndex = 0;
            this.lbPrincipal.Text = "Principal";
            this.lbPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecundario
            // 
            this.btnSecundario.Location = new System.Drawing.Point(135, 201);
            this.btnSecundario.Name = "btnSecundario";
            this.btnSecundario.Size = new System.Drawing.Size(117, 67);
            this.btnSecundario.TabIndex = 1;
            this.btnSecundario.Text = "Janela Secundaria";
            this.btnSecundario.UseVisualStyleBackColor = true;
            this.btnSecundario.Click += new System.EventHandler(this.btnSecundario_Click);
            // 
            // btnSegundaThread
            // 
            this.btnSegundaThread.Location = new System.Drawing.Point(12, 201);
            this.btnSegundaThread.Name = "btnSegundaThread";
            this.btnSegundaThread.Size = new System.Drawing.Size(117, 67);
            this.btnSegundaThread.TabIndex = 2;
            this.btnSegundaThread.Text = "Janela Secundaria (Thread)";
            this.btnSegundaThread.UseVisualStyleBackColor = true;
            this.btnSegundaThread.Click += new System.EventHandler(this.btnSegundaThread_Click);
            // 
            // btnFormNome
            // 
            this.btnFormNome.Location = new System.Drawing.Point(258, 201);
            this.btnFormNome.Name = "btnFormNome";
            this.btnFormNome.Size = new System.Drawing.Size(117, 67);
            this.btnFormNome.TabIndex = 3;
            this.btnFormNome.Text = "Pegar Nome";
            this.btnFormNome.UseVisualStyleBackColor = true;
            this.btnFormNome.Click += new System.EventHandler(this.btnFormNome_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mAjuda,
            this.cbMenu,
            this.txbPesquisar});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(388, 31);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovo,
            this.mAbrir,
            this.toolStripSeparator1,
            this.mSair});
            this.mArquivo.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(62, 27);
            this.mArquivo.Text = "Arquivo";
            // 
            // menuNovo
            // 
            this.menuNovo.Name = "menuNovo";
            this.menuNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNovo.Size = new System.Drawing.Size(180, 22);
            this.menuNovo.Text = "Novo";
            this.menuNovo.Click += new System.EventHandler(this.menuNovo_Click);
            // 
            // mAbrir
            // 
            this.mAbrir.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAbrir.Name = "mAbrir";
            this.mAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mAbrir.Size = new System.Drawing.Size(180, 22);
            this.mAbrir.Text = "Abrir";
            this.mAbrir.Click += new System.EventHandler(this.mAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mSair
            // 
            this.mSair.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSair.Name = "mSair";
            this.mSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mSair.Size = new System.Drawing.Size(180, 22);
            this.mSair.Text = "Sair";
            this.mSair.Click += new System.EventHandler(this.mSair_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(50, 23);
            this.mAjuda.Text = "Ajuda";
            // 
            // mSobre
            // 
            this.mSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmDev,
            this.sbmVersao});
            this.mSobre.Name = "mSobre";
            this.mSobre.Size = new System.Drawing.Size(180, 22);
            this.mSobre.Text = "Sobre";
            // 
            // sbmDev
            // 
            this.sbmDev.Name = "sbmDev";
            this.sbmDev.Size = new System.Drawing.Size(180, 22);
            this.sbmDev.Text = "Desenvolvedor";
            this.sbmDev.Click += new System.EventHandler(this.sbmDev_Click);
            // 
            // sbmVersao
            // 
            this.sbmVersao.Name = "sbmVersao";
            this.sbmVersao.Size = new System.Drawing.Size(180, 22);
            this.sbmVersao.Text = "Versão";
            this.sbmVersao.Click += new System.EventHandler(this.sbmVersao_Click);
            // 
            // cbMenu
            // 
            this.cbMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(121, 23);
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txbPesquisar.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(100, 27);
            this.txbPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisar_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 280);
            this.Controls.Add(this.btnFormNome);
            this.Controls.Add(this.btnSegundaThread);
            this.Controls.Add(this.btnSecundario);
            this.Controls.Add(this.lbPrincipal);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "FormMain";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.Button btnSecundario;
        private System.Windows.Forms.Button btnSegundaThread;
        private System.Windows.Forms.Button btnFormNome;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuNovo;
        private System.Windows.Forms.ToolStripMenuItem mAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mSair;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mSobre;
        private System.Windows.Forms.ToolStripMenuItem sbmDev;
        private System.Windows.Forms.ToolStripMenuItem sbmVersao;
        private System.Windows.Forms.ToolStripComboBox cbMenu;
        private System.Windows.Forms.ToolStripTextBox txbPesquisar;
    }
}