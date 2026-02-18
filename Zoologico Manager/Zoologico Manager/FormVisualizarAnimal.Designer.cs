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
            buttonAlimentarAnimal = new Button();
            buttonEmitirSonido = new Button();
            buttonDetalles = new Button();
            labelEtiquetaSonido = new Label();
            labelCambioSonido = new Label();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = SystemColors.MenuHighlight;
            buttonRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(584, 369);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(139, 41);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // listBoxListaAnimales
            // 
            listBoxListaAnimales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxListaAnimales.FormattingEnabled = true;
            listBoxListaAnimales.Location = new Point(34, 41);
            listBoxListaAnimales.Name = "listBoxListaAnimales";
            listBoxListaAnimales.Size = new Size(463, 254);
            listBoxListaAnimales.TabIndex = 1;
            // 
            // buttonAlimentarAnimal
            // 
            buttonAlimentarAnimal.BackColor = SystemColors.MenuHighlight;
            buttonAlimentarAnimal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlimentarAnimal.Location = new Point(584, 55);
            buttonAlimentarAnimal.Name = "buttonAlimentarAnimal";
            buttonAlimentarAnimal.Size = new Size(139, 62);
            buttonAlimentarAnimal.TabIndex = 2;
            buttonAlimentarAnimal.Text = "Alimentar animal";
            buttonAlimentarAnimal.UseVisualStyleBackColor = false;
            buttonAlimentarAnimal.Click += buttonAlimentarAnimal_Click;
            // 
            // buttonEmitirSonido
            // 
            buttonEmitirSonido.BackColor = SystemColors.MenuHighlight;
            buttonEmitirSonido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEmitirSonido.Location = new Point(584, 149);
            buttonEmitirSonido.Name = "buttonEmitirSonido";
            buttonEmitirSonido.Size = new Size(139, 39);
            buttonEmitirSonido.TabIndex = 3;
            buttonEmitirSonido.Text = "Emitir sonido";
            buttonEmitirSonido.UseVisualStyleBackColor = false;
            buttonEmitirSonido.Click += buttonEmitirSonido_Click;
            // 
            // buttonDetalles
            // 
            buttonDetalles.BackColor = SystemColors.MenuHighlight;
            buttonDetalles.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDetalles.Location = new Point(584, 235);
            buttonDetalles.Name = "buttonDetalles";
            buttonDetalles.Size = new Size(139, 38);
            buttonDetalles.TabIndex = 4;
            buttonDetalles.Text = "Ver detalles";
            buttonDetalles.UseVisualStyleBackColor = false;
            // 
            // labelEtiquetaSonido
            // 
            labelEtiquetaSonido.AutoSize = true;
            labelEtiquetaSonido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEtiquetaSonido.Location = new Point(34, 352);
            labelEtiquetaSonido.Name = "labelEtiquetaSonido";
            labelEtiquetaSonido.Size = new Size(65, 20);
            labelEtiquetaSonido.TabIndex = 5;
            labelEtiquetaSonido.Text = "Sonido: ";
            // 
            // labelCambioSonido
            // 
            labelCambioSonido.AutoSize = true;
            labelCambioSonido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCambioSonido.Location = new Point(125, 356);
            labelCambioSonido.Name = "labelCambioSonido";
            labelCambioSonido.Size = new Size(27, 20);
            labelCambioSonido.TabIndex = 6;
            labelCambioSonido.Text = "\" \"";
            // 
            // FormVisualizarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCambioSonido);
            Controls.Add(labelEtiquetaSonido);
            Controls.Add(buttonDetalles);
            Controls.Add(buttonEmitirSonido);
            Controls.Add(buttonAlimentarAnimal);
            Controls.Add(listBoxListaAnimales);
            Controls.Add(buttonRegresar);
            Name = "FormVisualizarAnimal";
            Text = "FormVisualizarAnimal";
            Load += FormVisualizarAnimal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private ListBox listBoxListaAnimales;
        private Button buttonAlimentarAnimal;
        private Button buttonEmitirSonido;
        private Button buttonDetalles;
        private Label labelEtiquetaSonido;
        private Label labelCambioSonido;
    }
}