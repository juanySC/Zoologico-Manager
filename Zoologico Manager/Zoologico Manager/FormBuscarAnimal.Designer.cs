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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarAnimal));
            buttonRegresar = new Button();
            listBoxResultadoBuscar = new ListBox();
            comboBoxRecibirTipo = new ComboBox();
            labelTipo = new Label();
            label1 = new Label();
            labelNombreBuscar = new Label();
            textBoxRecibirNombre = new TextBox();
            buttonBuscarAnimal = new Button();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = SystemColors.MenuHighlight;
            buttonRegresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(647, 382);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(129, 42);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // listBoxResultadoBuscar
            // 
            listBoxResultadoBuscar.FormattingEnabled = true;
            listBoxResultadoBuscar.Location = new Point(35, 84);
            listBoxResultadoBuscar.Name = "listBoxResultadoBuscar";
            listBoxResultadoBuscar.Size = new Size(416, 244);
            listBoxResultadoBuscar.TabIndex = 1;
            // 
            // comboBoxRecibirTipo
            // 
            comboBoxRecibirTipo.FormattingEnabled = true;
            comboBoxRecibirTipo.Items.AddRange(new object[] { "Leon", "Loro", "Pez", "Elefante" });
            comboBoxRecibirTipo.Location = new Point(602, 91);
            comboBoxRecibirTipo.Name = "comboBoxRecibirTipo";
            comboBoxRecibirTipo.Size = new Size(129, 23);
            comboBoxRecibirTipo.TabIndex = 2;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(512, 94);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(48, 20);
            labelTipo.TabIndex = 3;
            labelTipo.Text = "Tipo: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(477, 29);
            label1.Name = "label1";
            label1.Size = new Size(299, 20);
            label1.TabIndex = 4;
            label1.Text = "Eliga la las opciones para buscar al animal";
            // 
            // labelNombreBuscar
            // 
            labelNombreBuscar.AutoSize = true;
            labelNombreBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreBuscar.Location = new Point(512, 157);
            labelNombreBuscar.Name = "labelNombreBuscar";
            labelNombreBuscar.Size = new Size(71, 20);
            labelNombreBuscar.TabIndex = 5;
            labelNombreBuscar.Text = "Nombre:";
            // 
            // textBoxRecibirNombre
            // 
            textBoxRecibirNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxRecibirNombre.Location = new Point(602, 157);
            textBoxRecibirNombre.Name = "textBoxRecibirNombre";
            textBoxRecibirNombre.Size = new Size(129, 27);
            textBoxRecibirNombre.TabIndex = 6;
            // 
            // buttonBuscarAnimal
            // 
            buttonBuscarAnimal.BackColor = SystemColors.MenuHighlight;
            buttonBuscarAnimal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarAnimal.Location = new Point(564, 246);
            buttonBuscarAnimal.Name = "buttonBuscarAnimal";
            buttonBuscarAnimal.Size = new Size(141, 41);
            buttonBuscarAnimal.TabIndex = 7;
            buttonBuscarAnimal.Text = "Buscar";
            buttonBuscarAnimal.UseVisualStyleBackColor = false;
            buttonBuscarAnimal.Click += buttonBuscarAnimal_Click;
            // 
            // FormBuscarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuscarAnimal);
            Controls.Add(textBoxRecibirNombre);
            Controls.Add(labelNombreBuscar);
            Controls.Add(label1);
            Controls.Add(labelTipo);
            Controls.Add(comboBoxRecibirTipo);
            Controls.Add(listBoxResultadoBuscar);
            Controls.Add(buttonRegresar);
            Name = "FormBuscarAnimal";
            Text = "FormBuscarAnimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private ListBox listBoxResultadoBuscar;
        private ComboBox comboBoxRecibirTipo;
        private Label labelTipo;
        private Label label1;
        private Label labelNombreBuscar;
        private TextBox textBoxRecibirNombre;
        private Button buttonBuscarAnimal;
    }
}