namespace Zoologico_Manager
{
    partial class FormVisualizarAnimal
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
            buttonSonido = new Button();
            buttonAlimentar = new Button();
            buttonDetalle = new Button();
            SuspendLayout();
            // 
            // buttonSonido
            // 
            buttonSonido.Location = new Point(217, 335);
            buttonSonido.Name = "buttonSonido";
            buttonSonido.Size = new Size(75, 23);
            buttonSonido.TabIndex = 0;
            buttonSonido.Text = "Sonido";
            buttonSonido.UseVisualStyleBackColor = true;
            // 
            // buttonAlimentar
            // 
            buttonAlimentar.Location = new Point(317, 335);
            buttonAlimentar.Name = "buttonAlimentar";
            buttonAlimentar.Size = new Size(75, 23);
            buttonAlimentar.TabIndex = 1;
            buttonAlimentar.Text = "Alimentar";
            buttonAlimentar.UseVisualStyleBackColor = true;
            // 
            // buttonDetalle
            // 
            buttonDetalle.Location = new Point(433, 338);
            buttonDetalle.Name = "buttonDetalle";
            buttonDetalle.Size = new Size(86, 23);
            buttonDetalle.TabIndex = 2;
            buttonDetalle.Text = "Detalles";
            buttonDetalle.TextAlign = ContentAlignment.BottomLeft;
            buttonDetalle.UseVisualStyleBackColor = true;
            buttonDetalle.Click += buttonDetalle_Click;
            // 
            // FormVisualizarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDetalle);
            Controls.Add(buttonAlimentar);
            Controls.Add(buttonSonido);
            Name = "FormVisualizarAnimal";
            Text = "FormVisualizarAnimal";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSonido;
        private Button buttonAlimentar;
        private Button buttonDetalle;
    }
}