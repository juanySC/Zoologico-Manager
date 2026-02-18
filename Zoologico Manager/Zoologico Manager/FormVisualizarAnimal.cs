using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zoologico_Manager
{
    public partial class FormVisualizarAnimal : Form
    {
        //colocando el vector de animales para poder buscar en el formulario
        private Animal[] listaAnimales;
        private int recibidosAnimales;
        public FormVisualizarAnimal(Animal[] animales, int contador)
        {
            InitializeComponent();
            this.listaAnimales = animales;
            this.recibidosAnimales = contador;

            //metodo para llenarlo 
            mostrarListaAnimales();
        }

        private void mostrarListaAnimales()
        {
            listBoxListaAnimales.Items.Clear();

            //recorro para poder imprimir todos los animales que hay en el vector
            for (int i = 0; i < recibidosAnimales; i++) 
            {
                //muestro la informacion basica del animal: tipo, nombre y edad
                listBoxListaAnimales.Items.Add($"{listaAnimales[i].GetType().Name} - {listaAnimales[i].Nombre} - {listaAnimales[i].Edad} años");
            }
            
        }

        private void buttonDetalle_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            //regreso al formulario principal sin borrar los dato
            
        }

        private void FormVisualizarAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
