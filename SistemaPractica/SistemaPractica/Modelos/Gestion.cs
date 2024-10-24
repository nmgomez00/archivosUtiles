using SistemaPractica.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPractica.Modelos
{
    public static class Gestion
    {
        static List<VideoJuego> VideoJuegos = new List<VideoJuego>();
        static string Archivo = "Videojuegos.txt";
        static public void Agregar(VideoJuego videoJuego)
        {
            VideoJuegos.Add(videoJuego);
            Console.WriteLine("Videojuego agregado con exito");
            GuardarJuego(videoJuego);
        }
        static public void Mostrar()
        {
            if (VideoJuegos.Count == 0)
            {
                Console.WriteLine("No hay videojuegos registrados");
            }
            else
            {
                Console.WriteLine("\nLista de videojuegos");
                foreach (var videojuego in VideoJuegos)
                {
                    Console.WriteLine(videojuego);
                }
            }
        }
        static public void Modificar(string nombre, decimal precio, int stock)
        {
            var videojuego = VideoJuegos.Find(m => m.Nombre == nombre);
            if (videojuego == null)
            {
                Console.WriteLine($"Videojuego '{nombre}' no encontrado.");
            }
            else
            {
                videojuego.Precio = precio;
                videojuego.Stock = stock;
                Console.WriteLine($"Videojuego '{nombre}' modificado.");
                GuardarDatos();
            }
        }
        static public void Eliminar(string nombre)
        {
            var videojuego = VideoJuegos.Find(m => m.Nombre == nombre);
            if (videojuego == null)
            {
                Console.WriteLine($"Videojuego '{nombre}' no encontrado.");
            }
            else
            {
                VideoJuegos.Remove(videojuego);
                Console.WriteLine($"Videojuego '{nombre}' modificado.");
                GuardarDatos();
            }
        }
        static void Guardar(VideoJuego juego)
        {
            using StreamWriter writer = new(Archivo, true);
            writer.WriteLine(juego);
        }

        static void GuardarDatos()
        {
            using StreamWriter writer = new(Archivo);
            foreach (var juego in VideoJuegos)
            {
                writer.WriteLine(juego);
            }
        }

        static public void CargarDatos()
        {
            if (File.Exists(Archivo))
            {
                foreach (var linea in File.ReadLines(Archivo))
                {
                    string[] d = linea.Split(",");

                    string nombre = d[0];
                    Plataforma plataforma = (Plataforma)Enum.Parse(typeof(Plataforma), d[1]);

                    decimal precio = decimal.Parse(d[2]);

                    int stock = int.Parse(d[3]);

                    VideoJuego juego = new VideoJuego(nombre, plataforma, precio, stock);
                    VideoJuegos.Add(juego);
                }
                Console.WriteLine("Datos cargados correctamente.");
            }
        }
    }
}
