using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio3
{
    internal class Serie: IEntregable
    {
        private const String TITULO = "TituloDefault";
        private const Int16 NUMTEMPORADAS = 3;
        private const Boolean ENTREGADO = false;
        private const String GENERO = "GeneroDefault";
        private const String CREADOR = "CreadorDefault";

        public String Titulo { get; set; }
        public Int16 NumTemporadas { get; set; }
        public Boolean Entregado { get; set; }
        public String Genero { get; set; }
        public String Creador { get; set; }

        public Serie()
        {
            Titulo = TITULO;
            NumTemporadas = NUMTEMPORADAS;
            Entregado = ENTREGADO;
            Genero = GENERO;
            Creador = CREADOR;
        }

        public Serie(String titulo, String creador)
        {
            Titulo = titulo;
            NumTemporadas = NUMTEMPORADAS;
            Entregado = ENTREGADO;
            Genero = GENERO;
            Creador = creador;
        }

        public Serie(String titulo, Int16 numTemporadas, String genero,String creador)
        {
            Titulo = titulo;
            NumTemporadas = numTemporadas;
            Entregado = ENTREGADO;
            Genero = genero;
            Creador = creador;
        }

        public override string ToString()
        {
            return $"Serie -> Titulo: {Titulo}, NumTemporadas: {NumTemporadas}, Entregado: {Entregado}, Genero: {Genero}, Creador: {Creador}";
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
