using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zoologico_Manager
{
    public partial class FormBuscarAnimal : Form
    {

       
        public FormBuscarAnimal(   )
        {
            InitializeComponent();
            
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //regreso al formulario principal
            Form1 formPrincipal2 = new Form1();
            formPrincipal2.Show();
        }
    }
}
