namespace _46.AsyncExemplo
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
            lbResultado = new ListBox();
            btnExecutar = new Button();
            btnExecutarAsync = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lbResultado
            // 
            lbResultado.FormattingEnabled = true;
            lbResultado.ItemHeight = 15;
            lbResultado.Location = new Point(12, 8);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(456, 484);
            lbResultado.TabIndex = 0;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(474, 12);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(150, 53);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // btnExecutarAsync
            // 
            btnExecutarAsync.Location = new Point(474, 71);
            btnExecutarAsync.Name = "btnExecutarAsync";
            btnExecutarAsync.Size = new Size(150, 53);
            btnExecutarAsync.TabIndex = 2;
            btnExecutarAsync.Text = "Executar Async";
            btnExecutarAsync.UseVisualStyleBackColor = true;
            btnExecutarAsync.Click += btnExecutarAsync_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(474, 130);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(150, 53);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 504);
            Controls.Add(btnLimpar);
            Controls.Add(btnExecutarAsync);
            Controls.Add(btnExecutar);
            Controls.Add(lbResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbResultado;
        private Button btnExecutar;
        private Button btnExecutarAsync;
        private Button btnLimpar;
    }
}
