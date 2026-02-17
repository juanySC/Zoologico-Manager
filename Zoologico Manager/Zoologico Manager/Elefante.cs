using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico_Manager
{
    //herencia desde animal y hereda sus metodos y atributos
    public class Elefante: Animal
    {
      

        //constructor
        public Elefante(string nombre, int edad, int salud, int hambre) :
            base(nombre, edad, salud, hambre)  
        {
            
        }
        //metodos que hereda desde animal 
        public override void EmitirSonido()
        {
            //sonido especial del elefante
            MessageBox.Show($"{Nombre} emite un sonido de elefante: Ruuuu");
        }

        public override void Alimentar()
        {
            this.Hambre -= 20; // reducir el hambre al alimentar al elefante
            this.Salud += 10; // aumentar la salud al alimentar al elefante
            MessageBox.Show($"{Nombre} se alimenta de hierba y frutas.");
        }

       
        
    }
}
