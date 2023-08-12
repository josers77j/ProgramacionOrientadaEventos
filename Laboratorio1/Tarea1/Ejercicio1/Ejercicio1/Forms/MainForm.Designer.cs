namespace Ejercicio1.Forms
{
    partial class MainForm
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
            Ejercicio1Label = new Label();
            indicacionLabel = new Label();
            resultadoLabel = new Label();
            numeroTextBox = new TextBox();
            factorialSignoLabel = new Label();
            calcularButton = new Button();
            SuspendLayout();
            // 
            // Ejercicio1Label
            // 
            Ejercicio1Label.AutoSize = true;
            Ejercicio1Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ejercicio1Label.Location = new Point(345, 35);
            Ejercicio1Label.Name = "Ejercicio1Label";
            Ejercicio1Label.Size = new Size(112, 30);
            Ejercicio1Label.TabIndex = 0;
            Ejercicio1Label.Text = "Ejercicio 1";
            // 
            // indicacionLabel
            // 
            indicacionLabel.AutoSize = true;
            indicacionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionLabel.Location = new Point(190, 79);
            indicacionLabel.Name = "indicacionLabel";
            indicacionLabel.Size = new Size(388, 25);
            indicacionLabel.TabIndex = 1;
            indicacionLabel.Text = "Ingrese un número para calcular su factorial:";
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoLabel.Location = new Point(74, 280);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(642, 25);
            resultadoLabel.TabIndex = 2;
            resultadoLabel.Text = "Cuando ingrese el número presione el botón calcular para ver el resultado.";
            resultadoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numeroTextBox
            // 
            numeroTextBox.BorderStyle = BorderStyle.FixedSingle;
            numeroTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numeroTextBox.Location = new Point(357, 139);
            numeroTextBox.MaxLength = 2;
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(100, 33);
            numeroTextBox.TabIndex = 3;
            numeroTextBox.KeyPress += numeroTextBox_KeyPress;
            // 
            // factorialSignoLabel
            // 
            factorialSignoLabel.AutoSize = true;
            factorialSignoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            factorialSignoLabel.Location = new Point(493, 141);
            factorialSignoLabel.Name = "factorialSignoLabel";
            factorialSignoLabel.Size = new Size(17, 25);
            factorialSignoLabel.TabIndex = 4;
            factorialSignoLabel.Text = "!";
            // 
            // calcularButton
            // 
            calcularButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            calcularButton.Location = new Point(363, 195);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(88, 36);
            calcularButton.TabIndex = 5;
            calcularButton.Text = "calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcularButton);
            Controls.Add(factorialSignoLabel);
            Controls.Add(numeroTextBox);
            Controls.Add(resultadoLabel);
            Controls.Add(indicacionLabel);
            Controls.Add(Ejercicio1Label);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Ejercicio1Label;
        private Label indicacionLabel;
        private Label resultadoLabel;
        private TextBox numeroTextBox;
        private Label factorialSignoLabel;
        private Button calcularButton;
    }
}