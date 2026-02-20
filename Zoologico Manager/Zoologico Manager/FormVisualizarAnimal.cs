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
                listBoxListaAnimales.Items.Add(
                   $"{listaAnimales[i].GetType().Name} - {listaAnimales[i].Nombre} - {listaAnimales[i].Edad} años | Salud: {listaAnimales[i].Salud} | Hambre: {listaAnimales[i].Hambre}"
       );
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

        private void buttonAlimentarAnimal_Click(object sender, EventArgs e)
        {
            //voy actualizar salud y hambre del animal seleccionado
            //primero que seleccione un animal para que el boton haga su trabajo 
            if (listBoxListaAnimales.SelectedIndex != -1)
            {
                int indiceSeleccionado = listBoxListaAnimales.SelectedIndex;
                // alimento al animal seleccionado
                listaAnimales[indiceSeleccionado].Alimentar();
                //actualizo la lista para mostrar los cambios en salud y hambre
                mostrarListaAnimales();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún animal");
            }

        }

        private void buttonEmitirSonido_Click(object sender, EventArgs e)
        {
            //actualizare el label para mostrar el sonido del animal seleccionado
            if (listBoxListaAnimales.SelectedIndex != -1)
            {
                int indiceSeleccionado = listBoxListaAnimales.SelectedIndex;
                labelCambioSonido.Text = listaAnimales[indiceSeleccionado].EmitirSonido();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún animal");
            }
        }

        private void buttonDetalles_Click(object sender, EventArgs e)
        {
            //actualizare los labels para mostrar los detalles del animal seleccionado
            if (listBoxListaAnimales.SelectedIndex != -1)
            {
                int indiceSeleccionado = listBoxListaAnimales.SelectedIndex;
                //cambio todos los labels 
                Animal animal = listaAnimales[indiceSeleccionado];
                labelMostrarTipo.Text = animal.GetType().Name;
                labelMostrarNombre.Text = animal.Nombre;
                labelMostrarEdad.Text = animal.Edad.ToString();
                labelMostrarSalud.Text = animal.Salud.ToString();
                labelMostrarHambre.Text = animal.Hambre.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún animal");
            }
        }
    }
}
