using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    internal class Leon: Animal
    {
        //atributos
        private int largoMelena;
        //constructor
        public Leon(string nombre, int edad, int salud, int hambre, int largoMelena) :
            base(nombre, edad, salud, hambre)
        {
            this.largoMelena = largoMelena;
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
        //getters and setters
        public int LargoMelena { get { return largoMelena; } 
            set { 
                //restingiendo largo de melena
                if (value < 0)
                {
                    largoMelena = 0;
                }
                else if (value > 50)
                {
                    largoMelena = 50;
                }
                else
                {
                    largoMelena = value;
                }
            }
        }
    }
}
