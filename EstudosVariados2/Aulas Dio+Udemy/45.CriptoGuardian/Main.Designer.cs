namespace _45.CriptoGuardian
{
    partial class CriptoGuardian
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbResultado = new Label();
            txbKey = new TextBox();
            btnEncript = new Button();
            btnExPublicKey = new Button();
            btnDescript = new Button();
            btnInportPublicKey = new Button();
            btnCriarChaves = new Button();
            btnPrivateKey = new Button();
            SuspendLayout();
            // 
            // lbResultado
            // 
            lbResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(12, 9);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(476, 94);
            lbResultado.TabIndex = 0;
            lbResultado.Text = "Chave não definida.";
            lbResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbKey
            // 
            txbKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbKey.Location = new Point(55, 100);
            txbKey.Name = "txbKey";
            txbKey.Size = new Size(389, 29);
            txbKey.TabIndex = 1;
            // 
            // btnEncript
            // 
            btnEncript.Location = new Point(12, 135);
            btnEncript.Name = "btnEncript";
            btnEncript.Size = new Size(150, 61);
            btnEncript.TabIndex = 2;
            btnEncript.Text = "Criptogafar arquivo";
            btnEncript.UseVisualStyleBackColor = true;
            btnEncript.Click += btnEncript_Click;
            // 
            // btnExPublicKey
            // 
            btnExPublicKey.Location = new Point(12, 202);
            btnExPublicKey.Name = "btnExPublicKey";
            btnExPublicKey.Size = new Size(150, 61);
            btnExPublicKey.TabIndex = 3;
            btnExPublicKey.Text = "Exportar Chave Pública";
            btnExPublicKey.UseVisualStyleBackColor = true;
            btnExPublicKey.Click += btnExPublicKey_Click;
            // 
            // btnDescript
            // 
            btnDescript.Location = new Point(184, 135);
            btnDescript.Name = "btnDescript";
            btnDescript.Size = new Size(150, 61);
            btnDescript.TabIndex = 4;
            btnDescript.Text = "Descriptografar Arquivo";
            btnDescript.UseVisualStyleBackColor = true;
            btnDescript.Click += btnDescript_Click;
            // 
            // btnInportPublicKey
            // 
            btnInportPublicKey.Location = new Point(184, 202);
            btnInportPublicKey.Name = "btnInportPublicKey";
            btnInportPublicKey.Size = new Size(150, 61);
            btnInportPublicKey.TabIndex = 5;
            btnInportPublicKey.Text = "Importar Chave Pública";
            btnInportPublicKey.UseVisualStyleBackColor = true;
            btnInportPublicKey.Click += btnInportPublicKey_Click;
            // 
            // btnCriarChaves
            // 
            btnCriarChaves.Location = new Point(350, 135);
            btnCriarChaves.Name = "btnCriarChaves";
            btnCriarChaves.Size = new Size(150, 61);
            btnCriarChaves.TabIndex = 6;
            btnCriarChaves.Text = "Criar Chaves";
            btnCriarChaves.UseVisualStyleBackColor = true;
            btnCriarChaves.Click += btnCriarChaves_Click;
            // 
            // btnPrivateKey
            // 
            btnPrivateKey.Location = new Point(350, 202);
            btnPrivateKey.Name = "btnPrivateKey";
            btnPrivateKey.Size = new Size(150, 61);
            btnPrivateKey.TabIndex = 7;
            btnPrivateKey.Text = "Obter Chave Privada";
            btnPrivateKey.UseVisualStyleBackColor = true;
            btnPrivateKey.Click += btnPrivateKey_Click;
            // 
            // CriptoGuardian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 272);
            Controls.Add(btnPrivateKey);
            Controls.Add(btnCriarChaves);
            Controls.Add(btnInportPublicKey);
            Controls.Add(btnDescript);
            Controls.Add(btnExPublicKey);
            Controls.Add(btnEncript);
            Controls.Add(txbKey);
            Controls.Add(lbResultado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CriptoGuardian";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultado;
        private TextBox txbKey;
        private Button btnEncript;
        private Button btnExPublicKey;
        private Button btnDescript;
        private Button btnInportPublicKey;
        private Button btnCriarChaves;
        private Button btnPrivateKey;
    }
}
