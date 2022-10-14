using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio3
{
    internal interface IEntregable
    {
        public void entregar(); //Cambia el atributo entregado a true.
        public void devolver(); //Cambia el atributo entregado a false.
        public Boolean isEntregado(); //Devuelve el estado del atributo entregado.
    }
}
