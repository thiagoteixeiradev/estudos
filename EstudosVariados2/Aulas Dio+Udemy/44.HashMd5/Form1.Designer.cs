namespace _44.HashMd5
{
    partial class Form1
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
            btnCriptografa = new Button();
            btnComparar = new Button();
            lbResultado = new Label();
            txbEntrada = new TextBox();
            textBox2 = new TextBox();
            txbSaida = new TextBox();
            txbObjArmazenado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCriptografa
            // 
            btnCriptografa.Location = new Point(57, 181);
            btnCriptografa.Name = "btnCriptografa";
            btnCriptografa.Size = new Size(124, 68);
            btnCriptografa.TabIndex = 0;
            btnCriptografa.Text = "Criptografar";
            btnCriptografa.UseVisualStyleBackColor = true;
            btnCriptografa.Click += btnCriptografa_Click;
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(187, 181);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(124, 68);
            btnComparar.TabIndex = 1;
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(124, 252);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(134, 37);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "Resultado";
            // 
            // txbEntrada
            // 
            txbEntrada.Location = new Point(12, 25);
            txbEntrada.Multiline = true;
            txbEntrada.Name = "txbEntrada";
            txbEntrada.Size = new Size(378, 72);
            txbEntrada.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 105);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 72);
            textBox2.TabIndex = 4;
            // 
            // txbSaida
            // 
            txbSaida.Location = new Point(12, 103);
            txbSaida.Multiline = true;
            txbSaida.Name = "txbSaida";
            txbSaida.Size = new Size(378, 72);
            txbSaida.TabIndex = 5;
            // 
            // txbObjArmazenado
            // 
            txbObjArmazenado.Location = new Point(12, 291);
            txbObjArmazenado.Name = "txbObjArmazenado";
            txbObjArmazenado.Size = new Size(378, 23);
            txbObjArmazenado.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(23, 317);
            label1.Name = "label1";
            label1.Size = new Size(367, 39);
            label1.TabIndex = 7;
            label1.Text = "Use este campo para armazenar um objeto para comprara  a hash";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 340);
            Controls.Add(label1);
            Controls.Add(txbObjArmazenado);
            Controls.Add(txbSaida);
            Controls.Add(textBox2);
            Controls.Add(txbEntrada);
            Controls.Add(lbResultado);
            Controls.Add(btnComparar);
            Controls.Add(btnCriptografa);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "HashMd5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriptografa;
        private Button btnComparar;
        private Label lbResultado;
        private TextBox txbEntrada;
        private TextBox textBox2;
        private TextBox txbSaida;
        private TextBox txbObjArmazenado;
        private Label label1;
    }
}
