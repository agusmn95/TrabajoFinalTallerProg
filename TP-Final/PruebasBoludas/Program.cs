using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasBoludas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime iInicio = DateTime.Now;
            double iSegundosRestantes = (DateTime.Now - iInicio).TotalSeconds;
            while (iSegundosRestantes < 10)
            {
                Console.WriteLine(iSegundosRestantes);
                iSegundosRestantes = (DateTime.Now - iInicio).TotalSeconds;
                Console.Clear();
            }
            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
