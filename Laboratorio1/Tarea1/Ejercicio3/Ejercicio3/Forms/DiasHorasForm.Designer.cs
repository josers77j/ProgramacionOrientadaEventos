namespace Ejercicio3.Forms
{
    partial class DiasHorasForm
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
            indicacionDiasHorasLabel = new Label();
            diasHorasLabel = new Label();
            diasTextBox = new TextBox();
            convertirDiasHorasButton = new Button();
            resultadoHorasLabel = new Label();
            SuspendLayout();
            // 
            // indicacionDiasHorasLabel
            // 
            indicacionDiasHorasLabel.AutoSize = true;
            indicacionDiasHorasLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionDiasHorasLabel.Location = new Point(274, 96);
            indicacionDiasHorasLabel.Name = "indicacionDiasHorasLabel";
            indicacionDiasHorasLabel.Size = new Size(241, 25);
            indicacionDiasHorasLabel.TabIndex = 3;
            indicacionDiasHorasLabel.Text = "Ingrese la cantidad de días:";
            // 
            // diasHorasLabel
            // 
            diasHorasLabel.AutoSize = true;
            diasHorasLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            diasHorasLabel.Location = new Point(263, 40);
            diasHorasLabel.Name = "diasHorasLabel";
            diasHorasLabel.Size = new Size(270, 30);
            diasHorasLabel.TabIndex = 2;
            diasHorasLabel.Text = "Convertir de días en horas";
            // 
            // diasTextBox
            // 
            diasTextBox.BorderStyle = BorderStyle.FixedSingle;
            diasTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            diasTextBox.Location = new Point(343, 138);
            diasTextBox.Name = "diasTextBox";
            diasTextBox.Size = new Size(100, 33);
            diasTextBox.TabIndex = 4;
            diasTextBox.KeyPress += diasTextBox_KeyPress;
            // 
            // convertirDiasHorasButton
            // 
            convertirDiasHorasButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            convertirDiasHorasButton.Location = new Point(327, 196);
            convertirDiasHorasButton.Name = "convertirDiasHorasButton";
            convertirDiasHorasButton.Size = new Size(129, 32);
            convertirDiasHorasButton.TabIndex = 5;
            convertirDiasHorasButton.Text = "convertir";
            convertirDiasHorasButton.UseVisualStyleBackColor = true;
            convertirDiasHorasButton.Click += convertirDiasHorasButton_Click;
            // 
            // resultadoHorasLabel
            // 
            resultadoHorasLabel.AutoSize = true;
            resultadoHorasLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoHorasLabel.Location = new Point(68, 285);
            resultadoHorasLabel.Name = "resultadoHorasLabel";
            resultadoHorasLabel.Size = new Size(651, 25);
            resultadoHorasLabel.TabIndex = 6;
            resultadoHorasLabel.Text = "Cuando ingrese el número presione el botón convertir para ver el resultado.";
            // 
            // DiasHorasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultadoHorasLabel);
            Controls.Add(convertirDiasHorasButton);
            Controls.Add(diasTextBox);
            Controls.Add(indicacionDiasHorasLabel);
            Controls.Add(diasHorasLabel);
            Name = "DiasHorasForm";
            Text = "DiasHorasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label indicacionDiasHorasLabel;
        private Label diasHorasLabel;
        private TextBox diasTextBox;
        private Button convertirDiasHorasButton;
        private Label resultadoHorasLabel;
    }
}