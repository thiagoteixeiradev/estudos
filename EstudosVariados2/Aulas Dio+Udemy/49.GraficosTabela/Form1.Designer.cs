namespace _49.GraficosTabela
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
            label1 = new Label();
            txbY = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txbX = new TextBox();
            btnAtualizarGrafico = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Grafico";
            // 
            // txbY
            // 
            txbY.Location = new Point(130, 72);
            txbY.Name = "txbY";
            txbY.Size = new Size(100, 23);
            txbY.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(422, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 3;
            label2.Text = "Valor de X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 39);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 4;
            label3.Text = "Valor de Y";
            // 
            // txbX
            // 
            txbX.Location = new Point(12, 72);
            txbX.Name = "txbX";
            txbX.Size = new Size(106, 23);
            txbX.TabIndex = 5;
            // 
            // btnAtualizarGrafico
            // 
            btnAtualizarGrafico.Location = new Point(18, 101);
            btnAtualizarGrafico.Name = "btnAtualizarGrafico";
            btnAtualizarGrafico.Size = new Size(212, 41);
            btnAtualizarGrafico.TabIndex = 6;
            btnAtualizarGrafico.Text = "Atualizar Gráfico";
            btnAtualizarGrafico.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(212, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAtualizarGrafico);
            Controls.Add(txbX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txbY);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbY;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txbX;
        private Button btnAtualizarGrafico;
        private DataGridView dataGridView1;
    }
}
