namespace Ejercicio3.Forms
{
    partial class HorasMinutosForm
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
            resultadoMinutosLabel = new Label();
            convertirHorasMinutosButton = new Button();
            horasTextBox = new TextBox();
            indicacionHorasMinutosLabel = new Label();
            horasMinutosLabel = new Label();
            SuspendLayout();
            // 
            // resultadoMinutosLabel
            // 
            resultadoMinutosLabel.AutoSize = true;
            resultadoMinutosLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoMinutosLabel.Location = new Point(73, 307);
            resultadoMinutosLabel.Name = "resultadoMinutosLabel";
            resultadoMinutosLabel.Size = new Size(651, 25);
            resultadoMinutosLabel.TabIndex = 11;
            resultadoMinutosLabel.Text = "Cuando ingrese el número presione el botón convertir para ver el resultado.";
            // 
            // convertirHorasMinutosButton
            // 
            convertirHorasMinutosButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            convertirHorasMinutosButton.Location = new Point(329, 222);
            convertirHorasMinutosButton.Name = "convertirHorasMinutosButton";
            convertirHorasMinutosButton.Size = new Size(129, 32);
            convertirHorasMinutosButton.TabIndex = 10;
            convertirHorasMinutosButton.Text = "convertir";
            convertirHorasMinutosButton.UseVisualStyleBackColor = true;
            convertirHorasMinutosButton.Click += convertirHorasMinutosButton_Click;
            // 
            // horasTextBox
            // 
            horasTextBox.BorderStyle = BorderStyle.FixedSingle;
            horasTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            horasTextBox.Location = new Point(345, 164);
            horasTextBox.Name = "horasTextBox";
            horasTextBox.Size = new Size(100, 33);
            horasTextBox.TabIndex = 9;
            horasTextBox.KeyPress += horasTextBox_KeyPress;
            // 
            // indicacionHorasMinutosLabel
            // 
            indicacionHorasMinutosLabel.AutoSize = true;
            indicacionHorasMinutosLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionHorasMinutosLabel.Location = new Point(265, 122);
            indicacionHorasMinutosLabel.Name = "indicacionHorasMinutosLabel";
            indicacionHorasMinutosLabel.Size = new Size(254, 25);
            indicacionHorasMinutosLabel.TabIndex = 8;
            indicacionHorasMinutosLabel.Text = "Ingrese la cantidad de horas:";
            // 
            // horasMinutosLabel
            // 
            horasMinutosLabel.AutoSize = true;
            horasMinutosLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            horasMinutosLabel.Location = new Point(238, 68);
            horasMinutosLabel.Name = "horasMinutosLabel";
            horasMinutosLabel.Size = new Size(312, 30);
            horasMinutosLabel.TabIndex = 7;
            horasMinutosLabel.Text = "Convertir de horas en minutos";
            // 
            // HorasMinutosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultadoMinutosLabel);
            Controls.Add(convertirHorasMinutosButton);
            Controls.Add(horasTextBox);
            Controls.Add(indicacionHorasMinutosLabel);
            Controls.Add(horasMinutosLabel);
            Name = "HorasMinutosForm";
            Text = "HorasMinutosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoMinutosLabel;
        private Button convertirHorasMinutosButton;
        private TextBox horasTextBox;
        private Label indicacionHorasMinutosLabel;
        private Label horasMinutosLabel;
    }
}