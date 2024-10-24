
/*
 Práctica
Juan está emocionado con la idea de modernizar su tienda de videojuegos. 
Hace un tiempo, el mercado de videojuegos se ha expandido mucho y 
los clientes buscan siempre las mejores ofertas. A veces Juan se 
confunde con los precios o pierde el control del inventario, lo que
le ha causado problemas con algunos clientes que buscan juegos que 
ya no tiene o con precios mal actualizados. Además, su cuaderno está
tan lleno de tachones que no sabe cuántas unidades tiene de cada juego.

Por esta razón, le pide a un programador amigo que lo ayude a crear
un sistema sencillo pero efectivo para automatizar el proceso de gestión
de su tienda. "Necesito que este sistema me permita agregar, eliminar
actualizar y mostrar los videojuegos de mi catálogo de manera fácil y rápida", explica Juan.

Al implementar este sistema, Juan podrá dejar atrás el cuaderno y
usar su computadora para gestionar los juegos, asegurándose de que 
siempre tendrá la información correcta a mano. Además, la persistencia
en un archivo le permitirá que, aunque se apague la computadora o haya
un fallo, su catálogo esté siempre guardado y pueda recuperarse al instante.

Funcionalidades Principales:
Agregar Videojuego: Juan quiere poder añadir un nuevo videojuego
al catálogo con el nombre, la plataforma (que solo puede ser 
PlayStation, Xbox o PC), el precio y la cantidad de unidades en stock.
Mostrar el Catálogo: Juan debe poder ver toda la lista de juegos
disponibles con sus detalles.
Actualizar Videojuego: Si el precio cambia o recibe más stock,
debe poder modificar la información del juego existente.
Eliminar Videojuego: Si decide dejar de vender un juego, debe
poder quitarlo del catálogo.
Guardado en Archivo: Todo debe quedar registrado en un archivo 
para que, si el sistema se reinicia, no pierda la información.
Este sistema debe ser sencillo de usar para alguien como Juan,
que no tiene experiencia con computadoras avanzadas, pero efectivo
para llevar el control de su inventario sin errores.
 */

using SistemaPractica.Modelos;

class Program
{
    public static void Main()
    {
        Menu.MostrarMenu();
    }
}