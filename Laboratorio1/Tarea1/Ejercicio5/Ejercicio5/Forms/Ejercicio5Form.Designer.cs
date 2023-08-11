namespace Ejercicio5.Forms
{
    partial class Ejercicio5Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrimerNumeroTextBox = new System.Windows.Forms.TextBox();
            this.SegundoNumeroTextBox = new System.Windows.Forms.TextBox();
            this.CompararButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(267, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca dos numeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(330, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(329, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Numero";
            // 
            // PrimerNumeroTextBox
            // 
            this.PrimerNumeroTextBox.Location = new System.Drawing.Point(292, 170);
            this.PrimerNumeroTextBox.Name = "PrimerNumeroTextBox";
            this.PrimerNumeroTextBox.Size = new System.Drawing.Size(209, 23);
            this.PrimerNumeroTextBox.TabIndex = 4;
            // 
            // SegundoNumeroTextBox
            // 
            this.SegundoNumeroTextBox.Location = new System.Drawing.Point(292, 230);
            this.SegundoNumeroTextBox.Name = "SegundoNumeroTextBox";
            this.SegundoNumeroTextBox.Size = new System.Drawing.Size(209, 23);
            this.SegundoNumeroTextBox.TabIndex = 5;
            // 
            // CompararButton
            // 
            this.CompararButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CompararButton.FlatAppearance.BorderSize = 0;
            this.CompararButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompararButton.ForeColor = System.Drawing.Color.White;
            this.CompararButton.Location = new System.Drawing.Point(324, 292);
            this.CompararButton.Name = "CompararButton";
            this.CompararButton.Size = new System.Drawing.Size(150, 40);
            this.CompararButton.TabIndex = 6;
            this.CompararButton.Text = "Comparar";
            this.CompararButton.UseVisualStyleBackColor = false;
            this.CompararButton.Click += new System.EventHandler(this.CompararButton_Click);
            // 
            // Ejercicio5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompararButton);
            this.Controls.Add(this.SegundoNumeroTextBox);
            this.Controls.Add(this.PrimerNumeroTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ejercicio5Form";
            this.Text = "Ejercicio5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PrimerNumeroTextBox;
        private TextBox SegundoNumeroTextBox;
        private Button CompararButton;
    }
}