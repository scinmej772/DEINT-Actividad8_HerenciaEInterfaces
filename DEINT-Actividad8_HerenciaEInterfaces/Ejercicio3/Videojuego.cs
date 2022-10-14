using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio3
{
    internal class Videojuego: IEntregable
    {
        private const String TITULO = "TituloDefault";
        private const Int16 HORASESTIMADAS = 10;
        private const Boolean ENTREGADO = false;
        private const String GENERO = "GeneroDefault";
        private const String COMPANYIA = "CreadorDefault";

        public String Titulo { get; set; }
        public Int16 HorasEstimadas { get; set; }
        public Boolean Entregado { get; set; }
        public String Genero { get; set; }
        public String Companyia { get; set; }

        public Videojuego()
        {
            Titulo = TITULO;
            HorasEstimadas = HORASESTIMADAS;
            Entregado = ENTREGADO;
            Genero = GENERO;
            Companyia = COMPANYIA;
        }

        public Videojuego(String titulo, String creador)
        {
            Titulo = titulo;
            HorasEstimadas = HORASESTIMADAS;
            Entregado = ENTREGADO;
            Genero = GENERO;
            Companyia = creador;
        }

        public Videojuego(String titulo, Int16 horasEstimadas, String genero, String creador)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = ENTREGADO;
            Genero = genero;
            Companyia = creador;
        }

        public override string ToString()
        {
            return $"VideoJuego -> Titulo: {Titulo}, HorasEstimadas: {HorasEstimadas}h, Entregado: {Entregado}, Genero: {Genero}, Compañia: {Companyia}";
        }

        public void entregar()
        {
            Entregado = true;
        }

        public void devolver()
        {
            Entregado = false;
        }

        public bool isEntregado()
        {
            return Entregado;
        }
    }
}
