// See https://aka.ms/new-console-template for more information
using EjercicioClase_Tarea_1_Semana_1;



Console.WriteLine("Hello, World!");

SuperHeroe superHeroe = new SuperHeroe();
superHeroe.nombre = "batman";
superHeroe.identidadsecreta = "bruce wayne";
superHeroe.ciudad = "ciudad gothica";
superHeroe.superpoder = "no tiene";
superHeroe.Imprimir();
SuperPoder superPoder = new SuperPoder();
/*superPoder.nombre = "super fuerza";*/
superPoder.descripcion = "utiliza herramientas";
superPoder.Imprimir();
