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

                //asigno parte visual con la logica
                string tipo = comboBoxTipoAnimal.SelectedItem.ToString();
                string nombre = textBoxNombreAnimal.Text;
                int edad = Convert.ToInt16(textBoxEdadAnimal.Text);
                contadorAnimales++; //incremento para los animales 
             


            }
        }
    }
}
