using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zoologico_Manager
{
    public partial class Form1 : Form
    {

        //delimito con el vector el numero de animales para crear
        Animal[] animales = new Animal[50];
        int contadorAnimales = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarAnimal_Click(object sender, EventArgs e)
        {
            //primero valido que haya espacio en el vector para agregar un nuevo animal
            if (contadorAnimales >= animales.Length)
            {
                MessageBox.Show("No se pueden agregar más animales. Zoologico lleno");
                return;
            }

            //para que si seleccione un animal 
            if (comboBoxTipoAnimal.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de animal.");
                return;
            }

            //obtengo los datos para que el animal se cree con todos los campos 
            if ((textBoxNombreAnimal.Text == "") || (textBoxEdadAnimal.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos para agregar un animal.");
                return;
            }

            string tipo = comboBoxTipoAnimal.SelectedItem.ToString();
            string nombre = textBoxNombreAnimal.Text;
            int edad = Convert.ToInt32(textBoxEdadAnimal.Text);

            //creo el animal dependiendo del tipo seleccionado
            Animal nuevoAnimal = null;

            switch (tipo)
            {
                case "Leon":
                    nuevoAnimal = new Leon(nombre, edad, 25, 15);
                    break;
                case "Elefante":
                    nuevoAnimal = new Elefante(nombre, edad, 20, 10);
                    break;
                case "Pez":
                    nuevoAnimal = new Pez(nombre, edad, 10, 5);
                    break;
                case "Loro":
                    nuevoAnimal = new Loro(nombre, edad, 5, 3);
                    break;
                default:
                    MessageBox.Show("Tipo de animal no reconocido.");
                    return;
            }

            //actualizo el contador 
            animales[contadorAnimales] = nuevoAnimal;
            contadorAnimales++;

            //actualizo el lable
            labelControlConteoAnimal.Text = contadorAnimales.ToString();
            MessageBox.Show("Animal agregado de manera correcta");

            //limpieza de los campos
            comboBoxTipoAnimal.SelectedItem = null;
            textBoxNombreAnimal.Clear();
            textBoxEdadAnimal.Clear();


        }

        private void buttonVisualizarAnimal_Click(object sender, EventArgs e)
        {
            //oculto el formulario actual para mostrar el nuevo formulario
            this.Hide();
            FormVisualizarAnimal formVisualizarAnimal = new FormVisualizarAnimal(animales, contadorAnimales);

            //para que la informacion de la otra ventana no lo borre al regresar
            formVisualizarAnimal.ShowDialog();

            //muestro de nuevo el formulario original
            this.Show();
        }

        private void buttonBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuscarAnimal formBuscarAnimal = new FormBuscarAnimal();
            formBuscarAnimal.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelControlConteoAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
