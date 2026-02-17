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
            comboBoxTipoAnimal.Location = new Point(207, 88);
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
            labelElegirAnimal.Location = new Point(21, 91);
            labelElegirAnimal.Name = "labelElegirAnimal";
            labelElegirAnimal.Size = new Size(89, 15);
            labelElegirAnimal.TabIndex = 2;
            labelElegirAnimal.Text = "Eliga el animal: ";
            // 
            // textBoxNombreAnimal
            // 
            textBoxNombreAnimal.Location = new Point(207, 153);
            textBoxNombreAnimal.Name = "textBoxNombreAnimal";
            textBoxNombreAnimal.Size = new Size(144, 23);
            textBoxNombreAnimal.TabIndex = 3;
            // 
            // labelNombreAnimal
            // 
            labelNombreAnimal.AutoSize = true;
            labelNombreAnimal.Location = new Point(21, 161);
            labelNombreAnimal.Name = "labelNombreAnimal";
            labelNombreAnimal.Size = new Size(109, 15);
            labelNombreAnimal.TabIndex = 4;
            labelNombreAnimal.Text = "Nombre de animal:";
            // 
            // textBoxEdadAnimal
            // 
            textBoxEdadAnimal.Location = new Point(207, 216);
            textBoxEdadAnimal.Name = "textBoxEdadAnimal";
            textBoxEdadAnimal.Size = new Size(144, 23);
            textBoxEdadAnimal.TabIndex = 5;
            // 
            // labelEdadAnimal
            // 
            labelEdadAnimal.AutoSize = true;
            labelEdadAnimal.Location = new Point(21, 224);
            labelEdadAnimal.Name = "labelEdadAnimal";
            labelEdadAnimal.Size = new Size(97, 15);
            labelEdadAnimal.TabIndex = 6;
            labelEdadAnimal.Text = "Edad del animal: ";
            labelEdadAnimal.Click += label1_Click;
            // 
            // buttonAgregarAnimal
            // 
            buttonAgregarAnimal.Location = new Point(524, 183);
            buttonAgregarAnimal.Name = "buttonAgregarAnimal";
            buttonAgregarAnimal.Size = new Size(144, 23);
            buttonAgregarAnimal.TabIndex = 7;
            buttonAgregarAnimal.Text = "Agregar Animal";
            buttonAgregarAnimal.UseVisualStyleBackColor = true;
            buttonAgregarAnimal.Click += buttonAgregarAnimal_Click;
            // 
            // buttonBuscarAnimal
            // 
            buttonBuscarAnimal.Location = new Point(524, 238);
            buttonBuscarAnimal.Name = "buttonBuscarAnimal";
            buttonBuscarAnimal.Size = new Size(144, 23);
            buttonBuscarAnimal.TabIndex = 9;
            buttonBuscarAnimal.Text = "Buscar Animal";
            buttonBuscarAnimal.UseVisualStyleBackColor = true;
            buttonBuscarAnimal.Click += buttonBuscarAnimal_Click;
            // 
            // buttonVisualizarAnimal
            // 
            buttonVisualizarAnimal.Location = new Point(524, 119);
            buttonVisualizarAnimal.Name = "buttonVisualizarAnimal";
            buttonVisualizarAnimal.Size = new Size(144, 23);
            buttonVisualizarAnimal.TabIndex = 10;
            buttonVisualizarAnimal.Text = "Mostrar Animal";
            buttonVisualizarAnimal.UseVisualStyleBackColor = true;
            buttonVisualizarAnimal.Click += buttonVisualizarAnimal_Click;
            // 
            // labelContadorAnimal
            // 
            labelContadorAnimal.AutoSize = true;
            labelContadorAnimal.Location = new Point(21, 281);
            labelContadorAnimal.Name = "labelContadorAnimal";
            labelContadorAnimal.Size = new Size(123, 15);
            labelContadorAnimal.TabIndex = 11;
            labelContadorAnimal.Text = "Contador de animales";
            // 
            // labelControlConteoAnimal
            // 
            labelControlConteoAnimal.AutoSize = true;
            labelControlConteoAnimal.Location = new Point(250, 281);
            labelControlConteoAnimal.Name = "labelControlConteoAnimal";
            labelControlConteoAnimal.Size = new Size(13, 15);
            labelControlConteoAnimal.TabIndex = 12;
            labelControlConteoAnimal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Text = "Form1";
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
