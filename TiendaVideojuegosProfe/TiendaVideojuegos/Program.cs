using TiendaVideojuegos.Enums;
using TiendaVideojuegos.Models;

namespace TiendaVideojuegos
{
    public class Program
    {
        static void Main()
        {
            Tienda.CargarDatos();

            Videojuego counter = new("Counter Strike", Plataforma.PC, 15, 30);
            Videojuego er = new("Elden Ring", Plataforma.Xbox, 35, 65);
            Videojuego tlou2 = new("The last of us 2", Plataforma.PlayStation, 70, 100);
            Videojuego shr = new("Silent Hill 2 Remake", Plataforma.PC, 50, 120);

            Tienda.AgregarVideojuego(counter);
            Tienda.AgregarVideojuego(er);
            Tienda.AgregarVideojuego(tlou2);
            Tienda.AgregarVideojuego(shr);

            Tienda.GuardarDatos();

            Tienda.MostrarCatalogo();

        }
    }
}