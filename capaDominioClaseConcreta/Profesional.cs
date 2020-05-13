using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominioClaseConcreta
{
    public class Profesional : Empleado
    {
        private double plus;

        public Profesional(int legajo, String nombre, double sueldoBasico, double plus) : base(legajo, nombre, sueldoBasico)
        {
            this.plus = plus;

        }

        public override double calcularSueldo()
        {
            return this.getSueldoBasico() + plus;
        }
    }
}
