using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_practica_pregunta_3
{
    internal class Program
    {
        public string nom;
        public int cantidad;
        public double precio_uni;

        public void Solicitar()
        {
            Console.WriteLine("Ingrese el nombre del producto : ");
            nom = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad : ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el producto unitario: ");
            precio_uni = double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Solicitar();

            double total = (pro.cantidad * pro.precio_uni);


            Console.WriteLine("-----Resumen de compra------");
            Console.WriteLine("Nombre del producto : " + pro.nom);
            Console.WriteLine("Cantidad : " + pro.cantidad);
            Console.WriteLine("Precio unitario : " + pro.precio_uni);

            Console.WriteLine("Total a pagar : " + total);
            Console.WriteLine("------------------------------------");
        }
    }
}
