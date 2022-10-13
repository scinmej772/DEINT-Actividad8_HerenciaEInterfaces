using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio1
{
    internal class Tecnico: Operario
    {
        public Tecnico(String nombre) : base(nombre)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} -> Tecnico";
        }
    }
}
