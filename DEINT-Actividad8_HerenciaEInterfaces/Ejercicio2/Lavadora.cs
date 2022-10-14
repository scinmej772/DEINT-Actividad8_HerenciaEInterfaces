using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio2
{
    internal class Lavadora: Electrodomestico
    {
        private const Double CARGA = 5;
        public Double Carga { get; set; }

        public Lavadora(): base()
        {
            Carga = CARGA;
        }

        public Lavadora(Double precio, Double peso) : base(precio, peso)
        {
            Carga = CARGA;
        }

        public Lavadora(String color, Char consumo, Double precio_base, Double peso, Double carga): base(color, consumo, precio_base, peso)
        {
            Carga = carga;
        }

        public override void precioFinal()
        {
            base.precioFinal();

            if (Carga >= 30) {
                Precio_base += 50;
            }

        }

    }
}
