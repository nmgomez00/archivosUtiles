using TiendaVideojuegos.Enums;

namespace TiendaVideojuegos.Models
{
    public static class Tienda
    {
        static List<Videojuego> catalogo = new();
        static string ArchivoCatalogo = "catalogo.txt";

        public static void AgregarVideojuego(Videojuego videojuego)
        {
            catalogo.Add(videojuego);

            GuardarDato(videojuego);
        }

        public static void MostrarCatalogo()
        {
            Console.WriteLine("\nCatálogo de videojuegos: ");
            Console.WriteLine("--- Nombre | Plataforma | Precio | Stock ---");
            if (catalogo.Count > 0)
            {
                foreach (var juego in catalogo)
                {
                    Console.WriteLine(juego);
                }
            }
            else
            {
                Console.WriteLine("No hay video juegos dentro del catálogo.");
            }
        }

        public static void ActualizarVideojuego(string nombre, decimal nuevoPrecio, int nuevoStock)
        {
            var juego = catalogo.Find(j => j.Nombre == nombre);
            if (juego != null)
            {
                juego.Precio = nuevoPrecio;
                juego.Stock = nuevoStock;

                GuardarDatos();

                Console.WriteLine("El juego se actualizó correctamente.");
            }
            else
            {
                Console.WriteLine("El videojuego no se encontró en el catálogo.");
            }
        }

        public static void EliminarVideojuego(string nombre)
        {
            var juego = catalogo.Find(j => j.Nombre == nombre);
            if (juego != null)
            {
                catalogo.Remove(juego);

                GuardarDatos();

                Console.WriteLine("El juego se eliminó correctamente.");
            }
            else
            {
                Console.WriteLine("El videojuego no se encontró en el catálogo.");
            }
        }

        public static void CargarDatos()
        {
            if (File.Exists(ArchivoCatalogo))
            {
                var lineas = File.ReadAllLines(ArchivoCatalogo);

                foreach(var linea in lineas)
                {
                    var datos = linea.Split(", ");
                    string nombre = datos[0];
                    // parsear un string a tipo Enum.
                    Plataforma plataforma = (Plataforma)Enum.Parse(typeof(Plataforma), datos[1]);

                    decimal precio = decimal.Parse(datos[2]);
                    int stock = int.Parse(datos[3]);

                    Videojuego juego = new(nombre, plataforma, precio, stock);
                    catalogo.Add(juego);
                }
            }
        }

        public static void GuardarDato(Videojuego juego)
        {
            using StreamWriter writer = new StreamWriter(ArchivoCatalogo, true);
            writer.WriteLine(juego);
        }

        public static void GuardarDatos()
        {
            //using StreamWriter writer = new StreamWriter(ArchivoCatalogo);
            //foreach (var juego in catalogo)
            //{
            //    writer.WriteLine(juego);
            //}

            List<string> lineas = catalogo.Select(j => j.Precio.ToString()).ToList();
            File.WriteAllLines(ArchivoCatalogo, lineas);
        }
    }
}
