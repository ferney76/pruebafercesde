|using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaGit
{
    public class Calculos
    {
        //crear atributos (Campos)
        public short nUno, nDos;

        // creamos el metodo sumar
        short sumarNumeros = 0;

        public void sumar(short numeroUno,short numeroDos)
        {
            sumarNumeros =(short) (numeroUno + numeroDos);
        }

        public void mostrarResultados()
        {
            Console.WriteLine("Total: " + sumarNumeros);
               
        }

        public void metodouno()
        {
            Console.WriteLine("Total: " + sumarNumeros);
            
        }

        public void metododos()
        {
            Console.WriteLine("Total: " + sumarNumeros);

        }

        public void metodotres()
        {
            Console.WriteLine("Total: " + sumarNumeros);

        }
    }
}
