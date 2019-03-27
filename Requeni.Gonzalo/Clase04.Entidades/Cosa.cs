using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public string Mostrar()
        {
            return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToString();
        }

        public static string Mostrar(Cosa algo)
        {
            return algo.Mostrar();
        }

        public void EstablecerValor(int numero)
        {
            this.entero = numero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = 10;
            this.fecha = DateTime.Now;
            this.cadena = "sin valor";
        }

        public Cosa(int numero) :this()
        {
            this.entero = numero;
        }

        public Cosa(int numero, DateTime fecha) :this(numero)
        {
            this.fecha = fecha;
        }

        public Cosa(int numero, DateTime fecha, string cadena) :this(numero,fecha)
        {
            this.cadena = cadena;
        }
    }
}
