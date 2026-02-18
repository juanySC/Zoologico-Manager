namespace Zoologico_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxTipoAnimal = new ComboBox();
            labelTitulo = new Label();
            labelElegirAnimal = new Label();
            textBoxNombreAnimal = new TextBox();
            labelNombreAnimal = new Label();
            textBoxEdadAnimal = new TextBox();
            labelEdadAnimal = new Label();
            buttonAgregarAnimal = new Button();
            buttonBuscarAnimal = new Button();
            buttonVisualizarAnimal = new Button();
            labelContadorAnimal = new Label();
            labelControlConteoAnimal = new Label();
            SuspendLayout();
            // 
            // comboBoxTipoAnimal
            // 
            comboBoxTipoAnimal.FormattingEnabled = true;
            comboBoxTipoAnimal.Items.AddRange(new object[] { "Leon", "Loro", "Pez", "Elefante" });
            comboBoxTipoAnimal.Location = new Point(250, 96);
            comboBoxTipoAnimal.Name = "comboBoxTipoAnimal";
            comboBoxTipoAnimal.Size = new Size(144, 23);
            comboBoxTipoAnimal.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(298, 23);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(206, 30);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Zoologico Manager";
            // 
            // labelElegirAnimal
            // 
            labelElegirAnimal.AutoSize = true;
            labelElegirAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelElegirAnimal.Location = new Point(29, 91);
            labelElegirAnimal.Name = "labelElegirAnimal";
            labelElegirAnimal.Size = new Size(148, 25);
            labelElegirAnimal.TabIndex = 2;
            labelElegirAnimal.Text = "Eliga el animal: ";
            // 
            // textBoxNombreAnimal
            // 
            textBoxNombreAnimal.Location = new Point(250, 161);
            textBoxNombreAnimal.Name = "textBoxNombreAnimal";
            textBoxNombreAnimal.Size = new Size(144, 23);
            textBoxNombreAnimal.TabIndex = 3;
            // 
            // labelNombreAnimal
            // 
            labelNombreAnimal.AutoSize = true;
            labelNombreAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreAnimal.Location = new Point(21, 161);
            labelNombreAnimal.Name = "labelNombreAnimal";
            labelNombreAnimal.Size = new Size(182, 25);
            labelNombreAnimal.TabIndex = 4;
            labelNombreAnimal.Text = "Nombre de animal:";
            // 
            // textBoxEdadAnimal
            // 
            textBoxEdadAnimal.Location = new Point(250, 224);
            textBoxEdadAnimal.Name = "textBoxEdadAnimal";
            textBoxEdadAnimal.Size = new Size(144, 23);
            textBoxEdadAnimal.TabIndex = 5;
            // 
            // labelEdadAnimal
            // 
            labelEdadAnimal.AutoSize = true;
            labelEdadAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdadAnimal.Location = new Point(21, 224);
            labelEdadAnimal.Name = "labelEdadAnimal";
            labelEdadAnimal.Size = new Size(162, 25);
            labelEdadAnimal.TabIndex = 6;
            labelEdadAnimal.Text = "Edad del animal: ";
            labelEdadAnimal.Click += label1_Click;
            // 
            // buttonAgregarAnimal
            // 
            buttonAgregarAnimal.BackColor = SystemColors.MenuHighlight;
            buttonAgregarAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregarAnimal.Location = new Point(250, 361);
            buttonAgregarAnimal.Name = "buttonAgregarAnimal";
            buttonAgregarAnimal.Size = new Size(168, 45);
            buttonAgregarAnimal.TabIndex = 7;
            buttonAgregarAnimal.Text = "Agregar Animal";
            buttonAgregarAnimal.UseVisualStyleBackColor = false;
            buttonAgregarAnimal.Click += buttonAgregarAnimal_Click;
            // 
            // buttonBuscarAnimal
            // 
            buttonBuscarAnimal.BackColor = SystemColors.MenuHighlight;
            buttonBuscarAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarAnimal.Location = new Point(524, 208);
            buttonBuscarAnimal.Name = "buttonBuscarAnimal";
            buttonBuscarAnimal.Size = new Size(175, 39);
            buttonBuscarAnimal.TabIndex = 9;
            buttonBuscarAnimal.Text = "Buscar Animal";
            buttonBuscarAnimal.UseVisualStyleBackColor = false;
            buttonBuscarAnimal.Click += buttonBuscarAnimal_Click;
            // 
            // buttonVisualizarAnimal
            // 
            buttonVisualizarAnimal.BackColor = SystemColors.MenuHighlight;
            buttonVisualizarAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVisualizarAnimal.Location = new Point(524, 119);
            buttonVisualizarAnimal.Name = "buttonVisualizarAnimal";
            buttonVisualizarAnimal.Size = new Size(175, 40);
            buttonVisualizarAnimal.TabIndex = 10;
            buttonVisualizarAnimal.Text = "Mostrar Animal";
            buttonVisualizarAnimal.UseVisualStyleBackColor = false;
            buttonVisualizarAnimal.Click += buttonVisualizarAnimal_Click;
            // 
            // labelContadorAnimal
            // 
            labelContadorAnimal.AutoSize = true;
            labelContadorAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContadorAnimal.Location = new Point(21, 281);
            labelContadorAnimal.Name = "labelContadorAnimal";
            labelContadorAnimal.Size = new Size(206, 25);
            labelContadorAnimal.TabIndex = 11;
            labelContadorAnimal.Text = "Contador de animales";
            // 
            // labelControlConteoAnimal
            // 
            labelControlConteoAnimal.AutoSize = true;
            labelControlConteoAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControlConteoAnimal.Location = new Point(298, 281);
            labelControlConteoAnimal.Name = "labelControlConteoAnimal";
            labelControlConteoAnimal.Size = new Size(23, 25);
            labelControlConteoAnimal.TabIndex = 12;
            labelControlConteoAnimal.Text = "0";
            labelControlConteoAnimal.Click += labelControlConteoAnimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(labelControlConteoAnimal);
            Controls.Add(labelContadorAnimal);
            Controls.Add(buttonVisualizarAnimal);
            Controls.Add(buttonBuscarAnimal);
            Controls.Add(buttonAgregarAnimal);
            Controls.Add(labelEdadAnimal);
            Controls.Add(textBoxEdadAnimal);
            Controls.Add(labelNombreAnimal);
            Controls.Add(textBoxNombreAnimal);
            Controls.Add(labelElegirAnimal);
            Controls.Add(labelTitulo);
            Controls.Add(comboBoxTipoAnimal);
            Name = "Form1";
            Text = "Zoologico";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoAnimal;
        private Label labelTitulo;
        private Label labelElegirAnimal;
        private TextBox textBoxNombreAnimal;
        private Label labelNombreAnimal;
        private TextBox textBoxEdadAnimal;
        private Label labelEdadAnimal;
        private Button buttonAgregarAnimal;
        private Button buttonBuscarAnimal;
        private Button buttonVisualizarAnimal;
        private Label labelContadorAnimal;
        private Label labelControlConteoAnimal;
    }
}
