using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    public class Leon: Animal
    {
        
        //constructor
        public Leon(string nombre, int edad, int salud, int hambre) :
            base(nombre, edad, salud, hambre)
        {
         
        }
        //metodos que hereda desde animal 
        public override void EmitirSonido()
        {
            //sonido especial del leon
            MessageBox.Show($"{Nombre} emite un sonido de león: ¡Rauw!");
        }
        public override void Alimentar()
        {
            this.Hambre -= 25; // reducir el hambre al alimentar al león
            this.Salud += 15; // aumentar la salud al alimentar al león
            MessageBox.Show($"{Nombre} se alimenta de carne.");
        }
        
    }
}
