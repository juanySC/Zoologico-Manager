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
            buttonRegresar = new Button();
            listBoxListaAnimales = new ListBox();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = SystemColors.MenuHighlight;
            buttonRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(331, 356);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(121, 41);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // listBoxListaAnimales
            // 
            listBoxListaAnimales.FormattingEnabled = true;
            listBoxListaAnimales.Location = new Point(159, 57);
            listBoxListaAnimales.Name = "listBoxListaAnimales";
            listBoxListaAnimales.Size = new Size(463, 259);
            listBoxListaAnimales.TabIndex = 1;
            // 
            // FormVisualizarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxListaAnimales);
            Controls.Add(buttonRegresar);
            Name = "FormVisualizarAnimal";
            Text = "FormVisualizarAnimal";
            Load += FormVisualizarAnimal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegresar;
        private ListBox listBoxListaAnimales;
    }
}