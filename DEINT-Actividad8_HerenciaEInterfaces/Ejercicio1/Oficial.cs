using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio1
{
    internal class Oficial: Operario
    {
        public Oficial(String nombre) : base(nombre)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} -> Oficial";
        }
    }
}
