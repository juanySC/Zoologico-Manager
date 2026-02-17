using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    internal class Pez: Animal
    {

        //atributos
                private string tipoAgua;

        //constructor
        public Pez(string nombre, int edad, int salud, int hambre, string tipoAgua) :
            base(nombre, edad, salud, hambre)
        {
            this.tipoAgua = tipoAgua;
        }
        //metodos que hereda desde animal 
        public override void EmitirSonido()
        {
            base.EmitirSonido();
            MessageBox.Show($"{Nombre} emite un sonido de pez: Blub blub");
        }
        public override void Alimentar()
        {
            base.Alimentar();
            this.Hambre -= 10; // reducir el hambre al alimentar al pez
            this.Salud += 5; // aumentar la salud al alimentar al pez
            MessageBox.Show($"{Nombre} se alimenta de algas y pequeños insectos.");
        }
        //getters and setters
        public string TipoAgua { get { return tipoAgua; } set { tipoAgua = value; } }
    }
}
