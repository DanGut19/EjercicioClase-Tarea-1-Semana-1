using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase_Tarea_1_Semana_1
{
    internal class SuperHeroe
    {

        public string nombre { get; set; }

        public string identidadsecreta { get; set; }

        public string ciudad { get; set; }

        public bool puedevolar { get; set; }

        public string superpoder { get; set; }

        public SuperHeroe()
        {
            nombre = nombre;
            identidadsecreta = identidadsecreta;
            ciudad = ciudad;
            puedevolar = false;
            superpoder = superpoder;
        }

        /*public SuperHeroe(string nombre) 
        {

            nombre = nombre;
            puedevolar = true;


        }*/

        public void Imprimir()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"nombre: {nombre}");
            Console.WriteLine($"identidadsecreta: {identidadsecreta}");
            Console.WriteLine($"ciudad: {ciudad}");
            Console.WriteLine($"puedevolar: {puedevolar}");
            Console.WriteLine($"superpoderes: {superpoder}");
        }

    }
}
