namespace Ejercicio3.Forms
{
    partial class MinutosSegundosForm
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
            resultadoSegundosLabel = new Label();
            convertirMinutosSegundosButton = new Button();
            minutosTextBox = new TextBox();
            indicacionMinutosSegundosLabel = new Label();
            minutosSegundosLabel = new Label();
            SuspendLayout();
            // 
            // resultadoSegundosLabel
            // 
            resultadoSegundosLabel.AutoSize = true;
            resultadoSegundosLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoSegundosLabel.Location = new Point(74, 302);
            resultadoSegundosLabel.Name = "resultadoSegundosLabel";
            resultadoSegundosLabel.Size = new Size(651, 25);
            resultadoSegundosLabel.TabIndex = 16;
            resultadoSegundosLabel.Text = "Cuando ingrese el número presione el botón convertir para ver el resultado.";
            // 
            // convertirMinutosSegundosButton
            // 
            convertirMinutosSegundosButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            convertirMinutosSegundosButton.Location = new Point(348, 215);
            convertirMinutosSegundosButton.Name = "convertirMinutosSegundosButton";
            convertirMinutosSegundosButton.Size = new Size(129, 32);
            convertirMinutosSegundosButton.TabIndex = 15;
            convertirMinutosSegundosButton.Text = "convertir";
            convertirMinutosSegundosButton.UseVisualStyleBackColor = true;
            convertirMinutosSegundosButton.Click += convertirMinutosSegundosButton_Click;
            // 
            // minutosTextBox
            // 
            minutosTextBox.BorderStyle = BorderStyle.FixedSingle;
            minutosTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minutosTextBox.Location = new Point(359, 158);
            minutosTextBox.Name = "minutosTextBox";
            minutosTextBox.Size = new Size(100, 33);
            minutosTextBox.TabIndex = 14;
            minutosTextBox.KeyPress += minutosTextBox_KeyPress;
            // 
            // indicacionMinutosSegundosLabel
            // 
            indicacionMinutosSegundosLabel.AutoSize = true;
            indicacionMinutosSegundosLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionMinutosSegundosLabel.Location = new Point(272, 113);
            indicacionMinutosSegundosLabel.Name = "indicacionMinutosSegundosLabel";
            indicacionMinutosSegundosLabel.Size = new Size(275, 25);
            indicacionMinutosSegundosLabel.TabIndex = 13;
            indicacionMinutosSegundosLabel.Text = "Ingrese la cantidad de minutos:";
            // 
            // minutosSegundosLabel
            // 
            minutosSegundosLabel.AutoSize = true;
            minutosSegundosLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            minutosSegundosLabel.Location = new Point(244, 59);
            minutosSegundosLabel.Name = "minutosSegundosLabel";
            minutosSegundosLabel.Size = new Size(352, 30);
            minutosSegundosLabel.TabIndex = 12;
            minutosSegundosLabel.Text = "Convertir de minutos en segundos";
            // 
            // MinutosSegundosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultadoSegundosLabel);
            Controls.Add(convertirMinutosSegundosButton);
            Controls.Add(minutosTextBox);
            Controls.Add(indicacionMinutosSegundosLabel);
            Controls.Add(minutosSegundosLabel);
            Name = "MinutosSegundosForm";
            Text = "MinutosSegundosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoSegundosLabel;
        private Button convertirMinutosSegundosButton;
        private TextBox minutosTextBox;
        private Label indicacionMinutosSegundosLabel;
        private Label minutosSegundosLabel;
    }
}