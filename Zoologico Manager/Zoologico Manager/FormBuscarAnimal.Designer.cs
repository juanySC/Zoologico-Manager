namespace Zoologico_Manager
{
    partial class FormBuscarAnimal
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
            buttonRegresar = new Button();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = SystemColors.MenuHighlight;
            buttonRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(419, 370);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(129, 42);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // FormBuscarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegresar);
            Name = "FormBuscarAnimal";
            Text = "FormBuscarAnimal";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegresar;
    }
}