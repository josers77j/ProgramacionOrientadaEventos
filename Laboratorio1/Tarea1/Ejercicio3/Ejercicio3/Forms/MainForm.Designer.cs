namespace Ejercicio3.Forms
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
            ejercicio3Label = new Label();
            indicacionLabel = new Label();
            convertirDiasHorasButton = new Button();
            convertirHorasMinutosButton = new Button();
            convertirMinutosSegundosButton = new Button();
            SuspendLayout();
            // 
            // ejercicio3Label
            // 
            ejercicio3Label.AutoSize = true;
            ejercicio3Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ejercicio3Label.Location = new Point(337, 45);
            ejercicio3Label.Name = "ejercicio3Label";
            ejercicio3Label.Size = new Size(112, 30);
            ejercicio3Label.TabIndex = 0;
            ejercicio3Label.Text = "Ejercicio 3";
            // 
            // indicacionLabel
            // 
            indicacionLabel.AutoSize = true;
            indicacionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionLabel.Location = new Point(198, 100);
            indicacionLabel.Name = "indicacionLabel";
            indicacionLabel.Size = new Size(382, 25);
            indicacionLabel.TabIndex = 1;
            indicacionLabel.Text = "Seleccione la conversión que desea realizar:";
            // 
            // convertirDiasHorasButton
            // 
            convertirDiasHorasButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            convertirDiasHorasButton.Location = new Point(75, 201);
            convertirDiasHorasButton.Name = "convertirDiasHorasButton";
            convertirDiasHorasButton.Size = new Size(166, 88);
            convertirDiasHorasButton.TabIndex = 2;
            convertirDiasHorasButton.Text = "días\r\nen\r\nhoras";
            convertirDiasHorasButton.UseVisualStyleBackColor = true;
            convertirDiasHorasButton.Click += convertirDiasHorasButton_Click;
            // 
            // convertirHorasMinutosButton
            // 
            convertirHorasMinutosButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            convertirHorasMinutosButton.Location = new Point(314, 201);
            convertirHorasMinutosButton.Name = "convertirHorasMinutosButton";
            convertirHorasMinutosButton.Size = new Size(166, 88);
            convertirHorasMinutosButton.TabIndex = 3;
            convertirHorasMinutosButton.Text = "horas\r\nen\r\nminutos";
            convertirHorasMinutosButton.UseVisualStyleBackColor = true;
            convertirHorasMinutosButton.Click += convertirHorasMinutosButton_Click;
            // 
            // convertirMinutosSegundosButton
            // 
            convertirMinutosSegundosButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            convertirMinutosSegundosButton.Location = new Point(548, 201);
            convertirMinutosSegundosButton.Name = "convertirMinutosSegundosButton";
            convertirMinutosSegundosButton.Size = new Size(166, 88);
            convertirMinutosSegundosButton.TabIndex = 4;
            convertirMinutosSegundosButton.Text = "minutos\r\nen\r\nsegundos";
            convertirMinutosSegundosButton.UseVisualStyleBackColor = true;
            convertirMinutosSegundosButton.Click += convertirMinutosSegundosButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convertirMinutosSegundosButton);
            Controls.Add(convertirHorasMinutosButton);
            Controls.Add(convertirDiasHorasButton);
            Controls.Add(indicacionLabel);
            Controls.Add(ejercicio3Label);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ejercicio3Label;
        private Label indicacionLabel;
        private Button convertirDiasHorasButton;
        private Button convertirHorasMinutosButton;
        private Button convertirMinutosSegundosButton;
    }
}