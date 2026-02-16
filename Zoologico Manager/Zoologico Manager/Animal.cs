using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zoologico_Manager
{
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
            this.nombre = nombre;
            this.edad = edad;
            this.salud = salud; // salud inicial
            this.hambre = hambre;  
        }

        //metodos
        public virtual void EmitirSonido()
        {
            Console.WriteLine($"{nombre} hace un sonido.");
        }

        public virtual void Alimentar()
        {

            MessageBox.Show($"Alimentando a {nombre}...");
            hambre -= 20; // reducir el hambre al alimentar
            salud += 10; // aumentar la salud al alimentar

        }

        //getters and setters
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
