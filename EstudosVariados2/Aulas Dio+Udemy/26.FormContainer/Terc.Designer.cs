namespace _26.FormContainer
{
    partial class Terc
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
            this.btnRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRec
            // 
            this.btnRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRec.Location = new System.Drawing.Point(77, 106);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(180, 64);
            this.btnRec.TabIndex = 0;
            this.btnRec.Text = "Janela 2";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // Terc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 214);
            this.Controls.Add(this.btnRec);
            this.Name = "Terc";
            this.Text = "Terc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRec;
    }
}