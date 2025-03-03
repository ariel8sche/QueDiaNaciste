using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace QueDiaNaciste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            string nacimiento;
            Console.Write("\nIngrese el Dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el Mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el Año de nacimiento: ");
            año = int.Parse(Console.ReadLine());
            DateTime fecha = new DateTime(año, mes, dia);
            //Console.WriteLine(fecha.ToString("dddd", new CultureInfo("es-ES")));
            nacimiento = fecha.ToString("dddd", new CultureInfo("es-ES"));
            Console.WriteLine("\nEl dia de la semana en que naciste es: " + nacimiento);
        }
    }
}

