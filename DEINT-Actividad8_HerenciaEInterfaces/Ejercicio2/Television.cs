using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio2
{
    internal class Television: Electrodomestico
    {
        private const Double RESOLUCION = 20;
        private const Boolean TDT = false;
        public Double Resolucion { get; set; }
        public Boolean Tdt { get; set; }

        public Television(): base()
        {
            Resolucion = RESOLUCION;
            Tdt = TDT;
        }

        public Television(Double precio, Double peso) : base(precio, peso)
        {
            Resolucion = RESOLUCION;
            Tdt = TDT;
        }

        public Television(String color, Char consumo, Double precio_base, Double peso, Double resolucion, Boolean tdt) : base(color, consumo, precio_base, peso)
        {
            Resolucion = resolucion;
            Tdt = tdt;
        }

        public override void precioFinal()
        {
            base.precioFinal();

            if (Resolucion >= 40) {
                Precio_base *= 1.3;
            }

            if (Tdt) {
                Precio_base += 50;
            }

        }

        public override string ToString()
        {
            return $"Television -> {base.ToString()}, Resolucion: {Resolucion}¨, TDT: {Tdt}";
        }
    }
}
