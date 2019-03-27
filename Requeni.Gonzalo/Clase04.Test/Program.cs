using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04.Entidades;

namespace Clase04.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cosa obj = new Cosa();
            obj.EstablecerValor(5);
            obj.EstablecerValor("hola");
            obj.EstablecerValor(DateTime.Now);

            Console.WriteLine(Cosa.Mostrar(obj));
            Console.ReadLine();
        }
    }
}
