using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDominio;

namespace capaUsuarioConsola
{
    class Gestor
    {
        private ArrayList lista;
        private List<Empleado> listaGenEmpleados;

        public Gestor()
        {
            lista = new ArrayList();
            for (int i = 0; i < 5; i++)
                lista.Add(new Administrativo(i + 1, "Administrativo: " + (i + 1), 30000, 8));

            for(int i = 5; i<10; i++)
                lista.Add(new Profesional(i + 1, "Profesional: " + (i + 1), 60000,20000));

            listaGenEmpleados = new List<Empleado>();
            for (int i = 0; i < 5; i++)
                listaGenEmpleados.Add(new Administrativo(i + 1, "Administrativo: " + (i + 1), 30000, 8));

            for (int i = 5; i < 10; i++)
                listaGenEmpleados.Add(new Profesional(i + 1, "Profesional: " + (i + 1), 60000, 20000));
        }

        public void conFor()
        {
            Empleado e;
            for(int i = 0; i<lista.Count; i++)
            {
                e = (Empleado)lista[i];
                Console.WriteLine(e.getNombre());
            }
        }

        public void conForGen()
        {
            Empleado e;
            for (int i = 0; i < listaGenEmpleados.Count; i++)
            {
                e = listaGenEmpleados[i];
                Console.WriteLine(e.getNombre());
            }
        }

        public void conIterator()
        {
            Empleado e;
            IEnumerator iterador = lista.GetEnumerator();

            while(iterador.MoveNext())
            {
                e = (Empleado)iterador.Current;
                Console.WriteLine(e.getNombre());
            }
        }

        public void conIteratorGen()
        {
            Empleado e;
            IEnumerator<Empleado> iterador = listaGenEmpleados.GetEnumerator();

            while (iterador.MoveNext())
            {
                e = iterador.Current;
                Console.WriteLine(e.getNombre());
            }
        }

        public void conForEach()
        {
            foreach(Empleado e in listaGenEmpleados)
            {
                Console.WriteLine(e.getNombre());
            }
        }

    }
}
