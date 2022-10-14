using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad8_HerenciaEInterfaces.Ejercicio2
{
    internal class Electrodomestico
    {
        private const Color COLOR = Color.Blanco;
        private const Char CONSUMO = 'F';
        private const Double PRECIO_BASE = 100;
        private const Double PESO = 5;

        public Color Color { get; set; }
        public Char Consumo { get; set; }
        public Double Precio_base { get; set; }
        private Double Peso { get; set; }

        public Electrodomestico()
        {
            Color = COLOR;
            Consumo = CONSUMO;
            Precio_base = PRECIO_BASE;
            Peso = PESO;
        }

        public Electrodomestico(double precio_base, double peso)
        {
            Color = COLOR;
            Consumo = CONSUMO;
            Precio_base = precio_base;
            Peso = peso;
        }

        public Electrodomestico(string color, char consumo, double precio_base, double peso)
        {
            Color = comprobarColor(color);
            Consumo = comprobarConsumoEnergia(consumo);
            Precio_base = precio_base;
            Peso = peso;
        }

        private char comprobarConsumoEnergia(char letra)
        {
            if (letra >= 'A' && letra <= 'F')
            {
                return letra;
            }
            else
            {
                return CONSUMO;
            }
        }

        private Color comprobarColor(string color) {
            color = color.ToLower();

            switch(color){
                case "blanco":
                    return Color.Blanco;
                case "negro":
                    return Color.Negro;
                case "rojo":
                    return Color.Rojo;
                case "azul":
                    return Color.Azul;
                case "gris":
                    return Color.Gris;
                default:
                    return COLOR;
            }

        }

        public virtual void precioFinal()
        {
            switch (Consumo)
            {
                case 'A':
                    Precio_base += 100;
                    break;
                case 'B':
                    Precio_base += 80;
                    break;
                case 'C':
                    Precio_base += 60;
                    break;
                case 'D':
                    Precio_base += 50;
                    break;
                case 'E':
                    Precio_base += 30;
                    break;
                case 'F':
                    Precio_base += 10;
                    break;
            }

            if (Peso >= 0 && Peso <= 19) {
                
                Precio_base += 10;
            
            } else if (Peso >= 20 && Peso <= 49) {
                
                Precio_base += 50;
            
            } else if (Peso >= 50 && Peso <= 79) {
                
                Precio_base += 80;
            
            } else if (Peso >= 80) {
                
                Precio_base += 100;
            
            }

        }
    }
}
