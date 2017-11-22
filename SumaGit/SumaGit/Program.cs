using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello Mundo");

            Console.WriteLine("Numero Uno");
            //con esta linae se lleva el dato
            short numUno = short.Parse(Console.ReadLine());

            Console.WriteLine("NUmero Dos");
            short numDos = short.Parse(Console.ReadLine());

            //instanciar la clase
            Calculos realizarOperacion = new Calculos();
            realizarOperacion.nUno = numUno;
           // realizarOperacion.nDos = numDos;

            Console.WriteLine(realizarOperacion.nUno + " " + realizarOperacion.nDos);
            realizarOperacion.sumar(realizarOperacion.nUno, realizarOperacion.nDos);
            realizarOperacion.mostrarResultados();
            Console.ReadLine();
        }
    }
}
