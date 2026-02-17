using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    //herencia desde animal y hereda sus metodos y atributos
    internal class Elefante: Animal
    {
        //atributos
        private int largoColmillos;
        private int largoTrompa;

        //constructor
        public Elefante(string nombre, int edad, int salud, int hambre, int largoColmillos, int largoTrompa) :
            base(nombre, edad, salud, hambre)  
        {
            this.largoColmillos = largoColmillos;
            this.largoTrompa = largoTrompa;
        }
        //metodos que hereda desde animal 
        public override void EmitirSonido()
        {
            base.EmitirSonido();
            MessageBox.Show($"{Nombre} emite un sonido de elefante: Ruuuu");
        }

        public override void Alimentar()
        {
            base.Alimentar();
            this.Hambre -= 20; // reducir el hambre al alimentar al elefante
            this.Salud += 10; // aumentar la salud al alimentar al elefante
            MessageBox.Show($"{Nombre} se alimenta de hierba y frutas.");
        }

        //getters and setters
        public int LargoColmillos { get { return largoColmillos; }
            set { 
                //restingiendo largo del colmillo
                if (value < 0)
                {
                    largoColmillos = 0;
                }
                else if (value > 30)
                {
                    largoColmillos = 30;
                }
                else
                {
                    largoColmillos = value;
                }
            } }
        public int LargoTrompa { get { return largoTrompa; } 
            set { 
                //restriengiendo largo de trompa
                if (value < 0)
                {
                    largoTrompa = 0;
                }
                else if (value > 25)
                {
                    largoTrompa = 25;
                }
                else
                {
                    largoTrompa = value;
                }
            } }
    }
}
