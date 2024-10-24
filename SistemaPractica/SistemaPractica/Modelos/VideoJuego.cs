using SistemaPractica.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPractica.Modelos
{
    public class VideoJuego
    {
        public string Nombre { get; set ;}
        public Plataforma Plataforma { get;  set; }
        public decimal Precio { get; set; }
        public int Stock { get;  set; }
        
        public VideoJuego(string nombre, Plataforma plataforma, decimal precio, int stock)
        {
            Nombre = nombre;
            Plataforma = plataforma;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Nombre},{Plataforma},{Precio},{Stock}";
        }

    }
}
