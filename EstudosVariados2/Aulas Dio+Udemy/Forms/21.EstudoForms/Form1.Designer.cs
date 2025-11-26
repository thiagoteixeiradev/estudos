namespace EstudoForms
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnCores = new System.Windows.Forms.Button();
            this.btnFontes = new System.Windows.Forms.Button();
            this.btnEnviroment = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(9, 284);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(120, 47);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 9);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(614, 219);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Início";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(135, 284);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(120, 47);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Gerar Numero Randomico";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(261, 284);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(120, 47);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "TimeSpan";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(387, 284);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(120, 47);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnCores
            // 
            this.btnCores.Location = new System.Drawing.Point(513, 284);
            this.btnCores.Name = "btnCores";
            this.btnCores.Size = new System.Drawing.Size(120, 47);
            this.btnCores.TabIndex = 5;
            this.btnCores.Text = "Cores";
            this.btnCores.UseVisualStyleBackColor = true;
            this.btnCores.Click += new System.EventHandler(this.btnCores_Click);
            // 
            // btnFontes
            // 
            this.btnFontes.Location = new System.Drawing.Point(9, 231);
            this.btnFontes.Name = "btnFontes";
            this.btnFontes.Size = new System.Drawing.Size(120, 47);
            this.btnFontes.TabIndex = 6;
            this.btnFontes.Text = "Fontes";
            this.btnFontes.UseVisualStyleBackColor = true;
            this.btnFontes.Click += new System.EventHandler(this.btnFontes_Click);
            // 
            // btnEnviroment
            // 
            this.btnEnviroment.Location = new System.Drawing.Point(135, 231);
            this.btnEnviroment.Name = "btnEnviroment";
            this.btnEnviroment.Size = new System.Drawing.Size(120, 47);
            this.btnEnviroment.TabIndex = 7;
            this.btnEnviroment.Text = "Enviroment";
            this.btnEnviroment.UseVisualStyleBackColor = true;
            this.btnEnviroment.Click += new System.EventHandler(this.btnEnviroment_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.Location = new System.Drawing.Point(261, 231);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(120, 47);
            this.btnApplication.TabIndex = 8;
            this.btnApplication.Text = "Applicattion";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 343);
            this.Controls.Add(this.btnApplication);
            this.Controls.Add(this.btnEnviroment);
            this.Controls.Add(this.btnFontes);
            this.Controls.Add(this.btnCores);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnCores;
        private System.Windows.Forms.Button btnFontes;
        private System.Windows.Forms.Button btnEnviroment;
        private System.Windows.Forms.Button btnApplication;
    }
}

