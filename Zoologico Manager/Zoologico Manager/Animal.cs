using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zoologico_Manager
{
    //clase padre
    internal class Animal
    {

        //atributos
        private string nombre;
        private int edad;
        private int salud;
        private int hambre;

        //constructor
        public Animal(string nombre, int edad, int salud, int hambre)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Salud = salud; // salud inicial
            this.Hambre = hambre;  
        }

        //metodos
        public virtual void EmitirSonido()
        {
            MessageBox.Show($"{Nombre} emite un sonido.");
        }

        public virtual void Alimentar()
        {

            this.Hambre -= 15; // reducir el hambre al alimentar
            this.Salud += 5; // aumentar la salud al alimentar
            MessageBox.Show($"Alimentando a {Nombre}...");

        }

        //getters and setters
        public string Nombre{ get { return nombre; } set { nombre = value; } }

        public int Edad{ get {return edad; } set {edad = value; } }

        //modifico salud ya que se necesita para poder alimentar al animal 
        public int Salud
        {
            get { return salud; }
            set { 
                //condicion para que permanezca entre 0 y 100
                if (value < 0)
                {
                    salud = 0;
                }
                else if (value > 100)
                {
                    salud = 100;
                }
                else
                {
                    salud = value;
                }
            }
        }

        //dependiendo del hambre del animal se podra alimentar o no
        public int Hambre
        {
            get { return hambre; }
            set {
                //condiciones para que permanezca entre 0 y 100
                if (value < 0)
                {
                    hambre = 0;
                }
                else if (value > 100)
                {
                    hambre = 100;
                }
                else
                {
                    hambre = value;
                }
            }
        }

    }
}
