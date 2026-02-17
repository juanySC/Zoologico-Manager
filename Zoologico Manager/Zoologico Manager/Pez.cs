using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    public class Pez: Animal
    {

      

        //constructor
        public Pez(string nombre, int edad, int salud, int hambre) :
            base(nombre, edad, salud, hambre)
        {
           
        }
        //metodos que hereda desde animal 
        public override void EmitirSonido()
        {
            //sonido exclusivo del pez
            MessageBox.Show($"{Nombre} emite un sonido de pez: glu glu");
        }
        public override void Alimentar()
        {
            
            this.Hambre -= 10; // reducir el hambre al alimentar al pez
            this.Salud += 5; // aumentar la salud al alimentar al pez
            MessageBox.Show($"{Nombre} se alimenta de algas y pequeños insectos.");
        }
       
    }
}
