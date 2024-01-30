using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase_Tarea_1_Semana_1
{
    internal class SuperPoder
    {

        public string nombre {get; set;}

        public string descripcion { get; set; }

        public double nivel { get; set; }

        public SuperPoder() {

            nombre = nombre;
            descripcion = descripcion;
            double nivel = 10;

        }

        /*public SuperPoder(double nivel) 
        {

            double = nivel;
        
        }*/

        public void Imprimir()
        {
            /*Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"nombre: {nombre}");*/
            Console.WriteLine($"descripcion: {descripcion}");
            Console.WriteLine($"nivel: {nivel}");
        }


    }
}
