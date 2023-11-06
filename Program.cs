using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioParcialito.models;

namespace ejercicioParcialito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            producto producto = new producto();
            Dictionary<string, List<producto>> ListaProductos = new Dictionary<string, List<producto>>();

            while (true)
            {
                Console.WriteLine("BIENVENIDOS A LA TIENDA DE TECNOLOGIA DE LA UES");
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1- Menu de productos de la tienda");
                Console.WriteLine("2- Agregar una compra");
                Console.WriteLine("3- Lista de compra");
                Console.WriteLine("4- Buscar compra");
                Console.WriteLine("5- Salir del programa");

                ;
                string respuesta = "";
                string opcion = Console.ReadLine();
                switch (opcion)
                {

                    case "1":
                        Console.WriteLine("PlayStation 5 || precio : 800");
                        Console.WriteLine("Iphone 15 || precio : 1,500");
                        Console.WriteLine("Mouse HyperX || precio : 49.50");
                        Console.WriteLine("Teclado Razer || precio : 50.00");
                        break;

                    case "2":
                        producto.pedirDatos();

                        break;
                    case "3":
                        producto.mostrarInformacion();
                        break;
                    case "4":
                        producto.buscarTicket();



                        break;
                    case "5":
                        do
                        {
                            Console.WriteLine("Desea salir del programa? \n Apriete S para SI , \n cualquier otra letra pra NO");
                            respuesta = Console.ReadLine();

                        } while (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase));

                        break;
                }
            }
        }
    }
}
