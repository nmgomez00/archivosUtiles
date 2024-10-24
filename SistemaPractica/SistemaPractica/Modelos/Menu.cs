using SistemaPractica.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPractica.Modelos
{
    static public class Menu
    {
        private static List<Action> Acciones = new List<Action>
       {
           AgregarVideojuego,
           MostrarVideoJuegos,
           ModificarVideoJuegos,
           EliminarVideoJuego
       };
        public static void MostrarMenu()
        {
            GestionVideojuegos.CargarDatos();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n --- Menu de videojuegos ---\n" +
                    "1. Agregar Videojuego \n" +
                    "2. Mostrar Videojuego \n" +
                    "3. Modificar Videojuego\n" +
                    "4. Eliminar Videojuego \n"  +
                    "5. Salir \n");
                Console.WriteLine("Seleccone una opcion");
                string opcion = Console.ReadLine();
                int indice;
                if (int.TryParse(opcion, out indice) && indice >= 1 && indice <= Acciones.Count + 1)
                {
                    if (indice == Acciones.Count + 1)
                    {
                        salir = true;
                    }
                    else
                    {
                        Acciones[indice - 1].Invoke();
                    }
                }
            }
        }
        static VideoJuego CrearVideoJuego()
        {
            Console.WriteLine("Escriba el nombre del videojuego:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Seleccone la plataforma: ");
            foreach (var plataforma in Enum.GetValues(typeof(Plataforma)))
            {
                Console.WriteLine($".{(int)plataforma}. {plataforma}");
            }
            int  seleccion = int.Parse(Console.ReadLine());
            Plataforma plataformaSeleccion = (Plataforma)seleccion;

            Console.Write("Ingrese el precio del videojuego: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el stock del videojuego: ");
            int stock = int.Parse(Console.ReadLine());

            VideoJuego nuevoVideojuego = new VideoJuego(nombre, plataformaSeleccion, precio, stock);
            
            
            return nuevoVideojuego;
        }
        static public void AgregarVideojuego()
        {
            var NuevoVideojuego = CrearVideoJuego();
            GestionVideojuegos.AgregarVideoJuego(NuevoVideojuego);
        }
        static void MostrarVideoJuegos() => GestionVideojuegos.MostrarVideoJuegos();
        static void ModificarVideoJuegos()
        {
            Console.WriteLine("Ingrese el nombre del videojuego:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo precio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo stock:");
            int stock = int.Parse(Console.ReadLine());

            GestionVideojuegos.ModificarVideoJuego(nombre, precio, stock);
        }
        static void EliminarVideoJuego()
        {
            Console.WriteLine("Ingrese el nombre de la videojuego:");
            string nombre = Console.ReadLine();
            GestionVideojuegos.EliminarVideoJuego(nombre);
        }

    }
}

