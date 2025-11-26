namespace _48.CapturarTeclas
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
            lbMain = new Label();
            btnX = new Button();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lbMain
            // 
            lbMain.AutoSize = true;
            lbMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMain.Location = new Point(16, 26);
            lbMain.Name = "lbMain";
            lbMain.Size = new Size(155, 25);
            lbMain.TabIndex = 0;
            lbMain.Text = "Aperte uma tecla";
            // 
            // btnX
            // 
            btnX.Location = new Point(12, 178);
            btnX.Name = "btnX";
            btnX.Size = new Size(101, 49);
            btnX.TabIndex = 1;
            btnX.Text = "TeclaX";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click_1;
            btnX.KeyPress += Form1_KeyPress;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(340, 178);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(101, 49);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Tecla Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            btnEnter.KeyPress += Form1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 239);
            Controls.Add(btnEnter);
            Controls.Add(btnX);
            Controls.Add(lbMain);
            Name = "Form1";
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMain;
        private Button btnX;
        private Button btnEnter;
    }
}
