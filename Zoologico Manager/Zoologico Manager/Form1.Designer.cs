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
            comboBox1 = new ComboBox();
            labelTitulo = new Label();
            labelElegirAnimal = new Label();
            textBoxNombreAnimal = new TextBox();
            labelNombreAnimal = new Label();
            textBoxEdadAnimal = new TextBox();
            labelEdadAnimal = new Label();
            buttonAgregarAnimal = new Button();
            listBox1 = new ListBox();
            buttonBuscarAnimal = new Button();
            buttonVisualizarAnimal = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Leon", "Loro", "Pez", "Elefante" });
            comboBox1.Location = new Point(207, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(334, 30);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(111, 15);
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
            textBoxNombreAnimal.Size = new Size(121, 23);
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
            textBoxEdadAnimal.Size = new Size(121, 23);
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
            buttonAgregarAnimal.Location = new Point(207, 300);
            buttonAgregarAnimal.Name = "buttonAgregarAnimal";
            buttonAgregarAnimal.Size = new Size(144, 23);
            buttonAgregarAnimal.TabIndex = 7;
            buttonAgregarAnimal.Text = "Agregar Animal";
            buttonAgregarAnimal.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(489, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(227, 214);
            listBox1.TabIndex = 8;
            // 
            // buttonBuscarAnimal
            // 
            buttonBuscarAnimal.Location = new Point(467, 324);
            buttonBuscarAnimal.Name = "buttonBuscarAnimal";
            buttonBuscarAnimal.Size = new Size(119, 23);
            buttonBuscarAnimal.TabIndex = 9;
            buttonBuscarAnimal.Text = "Buscar Animal";
            buttonBuscarAnimal.UseVisualStyleBackColor = true;
            // 
            // buttonVisualizarAnimal
            // 
            buttonVisualizarAnimal.Location = new Point(610, 324);
            buttonVisualizarAnimal.Name = "buttonVisualizarAnimal";
            buttonVisualizarAnimal.Size = new Size(106, 23);
            buttonVisualizarAnimal.TabIndex = 10;
            buttonVisualizarAnimal.Text = "Mostrar Animal";
            buttonVisualizarAnimal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVisualizarAnimal);
            Controls.Add(buttonBuscarAnimal);
            Controls.Add(listBox1);
            Controls.Add(buttonAgregarAnimal);
            Controls.Add(labelEdadAnimal);
            Controls.Add(textBoxEdadAnimal);
            Controls.Add(labelNombreAnimal);
            Controls.Add(textBoxNombreAnimal);
            Controls.Add(labelElegirAnimal);
            Controls.Add(labelTitulo);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label labelTitulo;
        private Label labelElegirAnimal;
        private TextBox textBoxNombreAnimal;
        private Label labelNombreAnimal;
        private TextBox textBoxEdadAnimal;
        private Label labelEdadAnimal;
        private Button buttonAgregarAnimal;
        private ListBox listBox1;
        private Button buttonBuscarAnimal;
        private Button buttonVisualizarAnimal;
    }
}
