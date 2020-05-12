using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    public class Administrativo : Empleado
    {
        private int horasExtra;

        public Administrativo(int legajo, String nombre, double sueldoBasico, int horasExtra): base(legajo, nombre, sueldoBasico)
        {
            this.horasExtra = horasExtra;
        }

        public override double calcularSueldo()
        {
            return this.sueldoBasico + this.horasExtra * this.sueldoBasico * 0.05;
            //throw new NotImplementedException();
        }
       
    }
}
