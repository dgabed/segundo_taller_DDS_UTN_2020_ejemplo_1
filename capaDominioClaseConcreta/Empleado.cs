using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominioClaseConcreta
{
    public class Empleado : Impuesto
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

        public virtual double calcularSueldo()
        {
            return this.sueldoBasico;
        }

        public double calcularImpuesto()
        {
            return this.sueldoBasico * 0.05;
        }
    }
}
