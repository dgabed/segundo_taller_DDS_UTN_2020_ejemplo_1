using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    public abstract class Empleado
    {
        protected int legajo;
        protected String nombre;
        protected double sueldoBasico;

        public Empleado(int legajo, String nombre, double sueldoBasico)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.sueldoBasico = sueldoBasico;
        }

        public Empleado()
        {
            this.legajo = 0;
            this.nombre = "";
            this.sueldoBasico = 0;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getSueldoBasico()
        {
            return this.sueldoBasico;
        }

        public abstract double calcularSueldo();
    }
}
