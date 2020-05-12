using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaUsuarioConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Gestor g = new Gestor();

            Console.WriteLine("Muestra lista con For: ");
            g.conFor();
            Console.ReadLine();

            Console.WriteLine("Muestra lista genérica con For: ");
            g.conForGen();
            Console.ReadLine();

            Console.WriteLine("Muestra lista con Iterador: ");
            g.conIterator();
            Console.ReadLine();

            Console.WriteLine("Muestra lista genérica con Iterador: ");
            g.conIteratorGen();
            Console.ReadLine();

            Console.WriteLine("Muestra lista genérica con ForEach: ");
            g.conForEach();
            Console.ReadLine();

        }
    }
}
