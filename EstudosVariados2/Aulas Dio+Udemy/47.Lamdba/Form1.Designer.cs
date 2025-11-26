namespace _47.Lamdba
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
            btnExecutar = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(248, 159);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(159, 52);
            btnExecutar.TabIndex = 0;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(12, 9);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(134, 37);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 223);
            Controls.Add(lbResultado);
            Controls.Add(btnExecutar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecutar;
        private Label lbResultado;
    }
}
