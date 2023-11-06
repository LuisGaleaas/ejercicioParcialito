using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioParcialito.models
{
    class producto
    {
        public int numTicket { get; set; }
        public string nombreCliente { get; set; }
        public string nombreProducto { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double totalxProducto { get; set; }
        public double precioCompra { get; set; }


        private Dictionary<string, double> productos = new Dictionary<string, double>
    {
        { "PlayStation 5", 800.0 },
        { "Iphone 15", 1500.0 },
        { "Mouse HyperX", 49.5 },
        { "Teclado Razer", 50.00}
    };

        public void mostrarDatosProductos()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.Key} || precio : ${producto.Value}");
            }
        }

        public void pedirDatos()
        {
            Console.WriteLine("Ingrese su numero de ticket");
            numTicket = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del producto que desea ordenar");
            nombreProducto = Console.ReadLine();


            if (productos.TryGetValue(nombreProducto, out double precioProducto))
            {
                precio = precioProducto;
            }
            else
            {
                Console.WriteLine("Producto no encontrado en la lista.");
            }
        }

        public void mostrarInformacion()
        {
            Console.WriteLine($"Numeo de ticket -> {this.numTicket}");
            Console.WriteLine($"Nombre del cliente -> {this.nombreCliente}");
            Console.WriteLine($"Cantidad de producto a comprar -> {this.cantidad}");
            Console.WriteLine($"Nombre del producto comprado -> {this.nombreProducto}");
            Console.WriteLine($"Precio del producto -> ${this.precio}");
            Console.WriteLine($"Precio total de la compra -> ${this.precio * this.cantidad}");
        }
        public void buscarTicket()
        {
            int buscar = 0;
            Console.WriteLine("Ingrese el ticket a buscar");
            buscar = int.Parse(Console.ReadLine());
            if (numTicket == buscar)
            {
                mostrarInformacion();
            }
        }

    }
}
