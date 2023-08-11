namespace Ejercicio2.Forms
{
    partial class Ejercicio2Form
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
            resultLabel = new Label();
            resultTextBox = new TextBox();
            calculateButton = new Button();
            secondNumberTextBox = new TextBox();
            firstNumberTextBox = new TextBox();
            secondNumberLabel = new Label();
            firstNumberLabel = new Label();
            label1 = new Label();
            LimpiarButton = new Button();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultLabel.Location = new Point(415, 381);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(111, 28);
            resultLabel.TabIndex = 15;
            resultLabel.Text = "Resultado:";
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.FixedSingle;
            resultTextBox.Location = new Point(532, 382);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(70, 27);
            resultTextBox.TabIndex = 14;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.Location = new Point(290, 279);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 40);
            calculateButton.TabIndex = 13;
            calculateButton.Text = "Sumar";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.MouseLeave += calculateButton_MouseLeave;
            // 
            // secondNumberTextBox
            // 
            secondNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            secondNumberTextBox.Location = new Point(389, 200);
            secondNumberTextBox.Name = "secondNumberTextBox";
            secondNumberTextBox.Size = new Size(125, 27);
            secondNumberTextBox.TabIndex = 12;
            secondNumberTextBox.KeyPress += secondNumberTextBox_KeyPress;
            // 
            // firstNumberTextBox
            // 
            firstNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNumberTextBox.Location = new Point(389, 101);
            firstNumberTextBox.Name = "firstNumberTextBox";
            firstNumberTextBox.Size = new Size(125, 27);
            firstNumberTextBox.TabIndex = 11;
            firstNumberTextBox.KeyPress += firstNumberTextBox_KeyPress;
            // 
            // secondNumberLabel
            // 
            secondNumberLabel.AutoSize = true;
            secondNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            secondNumberLabel.Location = new Point(206, 199);
            secondNumberLabel.Name = "secondNumberLabel";
            secondNumberLabel.Size = new Size(177, 28);
            secondNumberLabel.TabIndex = 10;
            secondNumberLabel.Text = "Segundo Número";
            // 
            // firstNumberLabel
            // 
            firstNumberLabel.AutoSize = true;
            firstNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNumberLabel.Location = new Point(206, 100);
            firstNumberLabel.Name = "firstNumberLabel";
            firstNumberLabel.Size = new Size(158, 28);
            firstNumberLabel.TabIndex = 9;
            firstNumberLabel.Text = "Primer Número";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 32);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 8;
            label1.Text = "Suma de dos números";
            // 
            // LimpiarButton
            // 
            LimpiarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LimpiarButton.Location = new Point(439, 279);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(105, 40);
            LimpiarButton.TabIndex = 16;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.MouseHover += LimpiarButton_MouseHover;
            // 
            // Ejercicio2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LimpiarButton);
            Controls.Add(resultLabel);
            Controls.Add(resultTextBox);
            Controls.Add(calculateButton);
            Controls.Add(secondNumberTextBox);
            Controls.Add(firstNumberTextBox);
            Controls.Add(secondNumberLabel);
            Controls.Add(firstNumberLabel);
            Controls.Add(label1);
            Name = "Ejercicio2Form";
            Text = "Ejercicio2Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private TextBox resultTextBox;
        private Button calculateButton;
        private TextBox secondNumberTextBox;
        private TextBox firstNumberTextBox;
        private Label secondNumberLabel;
        private Label firstNumberLabel;
        private Label label1;
        private Button LimpiarButton;
    }
}