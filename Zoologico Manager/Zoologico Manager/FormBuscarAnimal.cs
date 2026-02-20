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
        //pasando ahora la lista de animales para mostrarla en el formulario de busqueda
        private Animal[] animales;
        private int cantidadAnimales;


        public FormBuscarAnimal(Animal[] animalito, int contadorAnimal)
        {
            InitializeComponent();
            //inicializo el vector de animales y la cantidad de animales para mostrar en el formulario de busqueda
            this.animales = animalito;
            this.cantidadAnimales = contadorAnimal;

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //regreso al formulario principal
            Form1 formPrincipal2 = new Form1();
            formPrincipal2.Show();
        }

        private void buttonBuscarAnimal_Click(object sender, EventArgs e)
        {

            listBoxResultadoBuscar.Items.Clear();

            string tipoBusqueda = comboBoxRecibirTipo.SelectedItem?.ToString();
            string nombreBusqueda = textBoxRecibirNombre.Text.Trim(); //ignora espacios par abuscar lo mas parecido
            //hago validaciones como que se halla seleccionado un tipo 

            if (comboBoxRecibirTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de animal o ingrese un nombre para buscar.");
                return;
            }

            //para el nombre entonces le hago validaxion para que solo acepte letras
            if (textBoxRecibirNombre.Text == "") 
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar o seleccione un tipo de animal.");
            }

            if (!nombreBusqueda.All(char.IsLetter))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return;
            }

           

            //bandera
            bool encontrar = false;

            //lo recorro con un ciclo for 
            for (int i = 0; i < cantidadAnimales; i++)
            {
                Animal animal = animales[i];

                bool coincideTipo = string.IsNullOrEmpty(tipoBusqueda) || animal.GetType().Name == tipoBusqueda;
                bool concideNombre = string.IsNullOrEmpty(nombreBusqueda) || animal.Nombre.ToLower() == nombreBusqueda;

                //comparando si coincide para devolver el resultado
                if (coincideTipo && concideNombre)
                {
                    listBoxResultadoBuscar.Items.Add($"Tipo: {animal.GetType().Name}, Nombre: {animal.Nombre}, Edad: {animal.Edad}, Salud: {animal.Salud}, Hambre: {animal.Hambre}");
                    encontrar = true;
                }
            }

            //si no se encontro a ningun animal
            if (!encontrar)
            {
                MessageBox.Show("No se encontró ningún animal");

            }
        }
    }
}
