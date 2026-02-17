using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    internal class Loro: Animal
    {
        //atributos
        private string colorPlumas;


        //constructor
        public Loro(string nombre, int edad, int salud, int hambre, string colorPlumas) :
            base(nombre, edad, salud, hambre)
        {
            this.colorPlumas = colorPlumas;
        }
        //metodos que hereda desde animal 
        public override void EmitirSonido()
        {
            base.EmitirSonido();
            MessageBox.Show($"{Nombre} emite un sonido de loro: ¡Hola!");
        }
        public override void Alimentar()
        {
            base.Alimentar();
            this.Hambre -= 5; // reducir el hambre al alimentar al loro
            this.Salud += 3; // aumentar la salud al alimentar al loro
            MessageBox.Show($"{Nombre} se alimenta de semillas y frutas.");
        }
        //getters and setters
        public string ColorPlumas { get { return colorPlumas; } set { colorPlumas = value; } }
    }
}
