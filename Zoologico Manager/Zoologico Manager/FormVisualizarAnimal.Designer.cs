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
            labelDetalles = new Label();
            labelNombre = new Label();
            labelMostrarNombre = new Label();
            labelEdad = new Label();
            labelMostrarEdad = new Label();
            labelTipo = new Label();
            labelMostrarTipo = new Label();
            labelHambre = new Label();
            labelMostrarHambre = new Label();
            labelSalud = new Label();
            labelMostrarSalud = new Label();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = SystemColors.MenuHighlight;
            buttonRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(618, 382);
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
            buttonAlimentarAnimal.Location = new Point(34, 350);
            buttonAlimentarAnimal.Name = "buttonAlimentarAnimal";
            buttonAlimentarAnimal.Size = new Size(166, 38);
            buttonAlimentarAnimal.TabIndex = 2;
            buttonAlimentarAnimal.Text = "Alimentar animal";
            buttonAlimentarAnimal.UseVisualStyleBackColor = false;
            buttonAlimentarAnimal.Click += buttonAlimentarAnimal_Click;
            // 
            // buttonEmitirSonido
            // 
            buttonEmitirSonido.BackColor = SystemColors.MenuHighlight;
            buttonEmitirSonido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEmitirSonido.Location = new Point(235, 348);
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
            buttonDetalles.Location = new Point(401, 350);
            buttonDetalles.Name = "buttonDetalles";
            buttonDetalles.Size = new Size(139, 38);
            buttonDetalles.TabIndex = 4;
            buttonDetalles.Text = "Ver detalles";
            buttonDetalles.UseVisualStyleBackColor = false;
            buttonDetalles.Click += buttonDetalles_Click;
            // 
            // labelEtiquetaSonido
            // 
            labelEtiquetaSonido.AutoSize = true;
            labelEtiquetaSonido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEtiquetaSonido.Location = new Point(528, 41);
            labelEtiquetaSonido.Name = "labelEtiquetaSonido";
            labelEtiquetaSonido.Size = new Size(65, 20);
            labelEtiquetaSonido.TabIndex = 5;
            labelEtiquetaSonido.Text = "Sonido: ";
            // 
            // labelCambioSonido
            // 
            labelCambioSonido.AutoSize = true;
            labelCambioSonido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCambioSonido.Location = new Point(535, 72);
            labelCambioSonido.Name = "labelCambioSonido";
            labelCambioSonido.Size = new Size(27, 20);
            labelCambioSonido.TabIndex = 6;
            labelCambioSonido.Text = "\" \"";
            // 
            // labelDetalles
            // 
            labelDetalles.AutoSize = true;
            labelDetalles.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetalles.Location = new Point(636, 110);
            labelDetalles.Name = "labelDetalles";
            labelDetalles.Size = new Size(65, 20);
            labelDetalles.TabIndex = 7;
            labelDetalles.Text = "Detalles";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(545, 180);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(75, 20);
            labelNombre.TabIndex = 8;
            labelNombre.Text = "Nombre: ";
            // 
            // labelMostrarNombre
            // 
            labelMostrarNombre.AutoSize = true;
            labelMostrarNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMostrarNombre.Location = new Point(636, 180);
            labelMostrarNombre.Name = "labelMostrarNombre";
            labelMostrarNombre.Size = new Size(27, 20);
            labelMostrarNombre.TabIndex = 9;
            labelMostrarNombre.Text = "\" \"";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdad.Location = new Point(546, 217);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(47, 20);
            labelEdad.TabIndex = 10;
            labelEdad.Text = "Edad:";
            // 
            // labelMostrarEdad
            // 
            labelMostrarEdad.AutoSize = true;
            labelMostrarEdad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMostrarEdad.Location = new Point(636, 217);
            labelMostrarEdad.Name = "labelMostrarEdad";
            labelMostrarEdad.Size = new Size(27, 20);
            labelMostrarEdad.TabIndex = 11;
            labelMostrarEdad.Text = "\" \"";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(545, 146);
            labelTipo.Name = "labelTipo";
            labelTipo.RightToLeft = RightToLeft.No;
            labelTipo.Size = new Size(48, 20);
            labelTipo.TabIndex = 12;
            labelTipo.Text = "Tipo: ";
            // 
            // labelMostrarTipo
            // 
            labelMostrarTipo.AutoSize = true;
            labelMostrarTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMostrarTipo.Location = new Point(636, 146);
            labelMostrarTipo.Name = "labelMostrarTipo";
            labelMostrarTipo.Size = new Size(27, 20);
            labelMostrarTipo.TabIndex = 13;
            labelMostrarTipo.Text = "\" \"";
            // 
            // labelHambre
            // 
            labelHambre.AutoSize = true;
            labelHambre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHambre.Location = new Point(546, 255);
            labelHambre.Name = "labelHambre";
            labelHambre.Size = new Size(69, 20);
            labelHambre.TabIndex = 14;
            labelHambre.Text = "Hambre:";
            // 
            // labelMostrarHambre
            // 
            labelMostrarHambre.AutoSize = true;
            labelMostrarHambre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMostrarHambre.Location = new Point(636, 255);
            labelMostrarHambre.Name = "labelMostrarHambre";
            labelMostrarHambre.Size = new Size(27, 20);
            labelMostrarHambre.TabIndex = 15;
            labelMostrarHambre.Text = "\" \"";
            // 
            // labelSalud
            // 
            labelSalud.AutoSize = true;
            labelSalud.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSalud.Location = new Point(546, 293);
            labelSalud.Name = "labelSalud";
            labelSalud.Size = new Size(51, 20);
            labelSalud.TabIndex = 16;
            labelSalud.Text = "Salud:";
            // 
            // labelMostrarSalud
            // 
            labelMostrarSalud.AutoSize = true;
            labelMostrarSalud.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMostrarSalud.Location = new Point(636, 293);
            labelMostrarSalud.Name = "labelMostrarSalud";
            labelMostrarSalud.Size = new Size(27, 20);
            labelMostrarSalud.TabIndex = 17;
            labelMostrarSalud.Text = "\" \"";
            // 
            // FormVisualizarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMostrarSalud);
            Controls.Add(labelSalud);
            Controls.Add(labelMostrarHambre);
            Controls.Add(labelHambre);
            Controls.Add(labelMostrarTipo);
            Controls.Add(labelTipo);
            Controls.Add(labelMostrarEdad);
            Controls.Add(labelEdad);
            Controls.Add(labelMostrarNombre);
            Controls.Add(labelNombre);
            Controls.Add(labelDetalles);
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
        private Label labelDetalles;
        private Label labelNombre;
        private Label labelMostrarNombre;
        private Label labelEdad;
        private Label labelMostrarEdad;
        private Label labelTipo;
        private Label labelMostrarTipo;
        private Label labelHambre;
        private Label labelMostrarHambre;
        private Label labelSalud;
        private Label labelMostrarSalud;
    }
}