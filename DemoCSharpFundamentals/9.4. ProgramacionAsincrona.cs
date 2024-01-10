using System.Threading.Tasks;

namespace DemoCSharpFundamentals
{
    public static class ProgramacionAsincrona
    {
        public static void PedidoPizza()
        {
            Console.WriteLine("Inicio del pedido de pizza");
            Thread.Sleep(5000); //simula un proceso que toma 5 segundos, es sincrono
            Console.WriteLine("Fin del pedido de pizza");
        }

        public static void PedidoHamburguesa()
        {
            Console.WriteLine("Inicio del pedido de hamburguesa");
            Thread.Sleep(6000); //simula un proceso que toma 6 segundos, es sincrono
            Console.WriteLine("Fin del pedido de hamburguesa");
        }

        //ejemplo de programacion sincrona async
        public static async Task PedidoPizzaAsync()
        {
            Console.WriteLine("Inicio del pedido de pizza");
            await Task.Delay(5000); //simula un proceso que toma 5 segundos, es asincrono
            //La operación igual se demora los 5 segundos, pero el hilo principal no se bloquea, es decir lo hace de una forma eficiente
            Console.WriteLine("Fin del pedido de pizza");
        }

        public static async Task PedidoHamburguesaAsync()
        {
            Console.WriteLine("Inicio del pedido de hamburguesa");
            await Task.Delay(6000); //simula un proceso que toma 6 segundos, es asincrono
            Console.WriteLine("Fin del pedido de hamburguesa");
        }
    }

    class Producto
    {
        public string Nombre { get; set; }
        public int CantidadEnStock { get; set; }
    }

    public class ProductoServicio
    {
        static List<Producto> inventario = new List<Producto>();

        public static void ProcesarProductos()
        {
            Console.WriteLine("Proceso principal iniciado.");

            // Cargamos algunos productos al inventario
            inventario.Add(new Producto { Nombre = "Laptop", CantidadEnStock = 10 });
            inventario.Add(new Producto { Nombre = "Teléfono", CantidadEnStock = 20 });

            // Simulamos la carga asíncrona de productos
            Task.Run(() => CargarProductosAsync());  //para ejecutar de forma asincrona un metodo sincrono  

            Console.WriteLine("Proceso principal continuando con otras tareas.");
        }

        public static async Task CargarProductosAsync()
        {
            Console.WriteLine("Iniciando carga asíncrona de productos.");
            await Task.Delay(2000); // Simulación de una operación asíncrona que lleva tiempo
            Console.WriteLine("Carga asíncrona de productos completada."); // se ejecuta cuando termina el await
        }

        public static void RealizarVenta(string nombreProducto, int cantidad)
        {
            Console.WriteLine($"Iniciando venta de {cantidad} unidades de {nombreProducto}...");
            Thread.Sleep(2000); // Simulación de una operación que lleva tiempo
            Producto producto = inventario.Find(p => p.Nombre == nombreProducto);
            if (producto != null && producto.CantidadEnStock >= cantidad)
            {
                producto.CantidadEnStock -= cantidad;
                Console.WriteLine($"Venta de {cantidad} unidades de {nombreProducto} completada.");
            }
            else
            {
                Console.WriteLine($"No hay suficientes unidades de {nombreProducto} en stock para la venta.");
            }
        }

        public static void MostrarInventario()
        {
            Console.WriteLine("\nInventario actualizado:");
            foreach (var producto in inventario)
            {
                Console.WriteLine($"{producto.Nombre}: {producto.CantidadEnStock} unidades");
            }
        }
    }


    public class AsincroniaEjemploTres
    {
        // los metodos asincronos deben ser llamados en metodos asincronos
        public async Task EjecutarTareas()
        {
            await TareaUno();
            await TareaDos();
            await TareaTres();

            // Cada tarea es independiente, no depende de la otra
            //var tareas = new List<Task>();{
            //    tareas.Add(TareaUno());
            //    tareas.Add(TareaDos());
            //    tareas.Add(TareaTres());
            //}

            //await Task.WhenAll(tareas);
            Console.WriteLine("Todas las tareas han finalizado");
            
        }

        public async Task TareaUno()
        {
            await Task.Delay(1000);
            Console.WriteLine("Tarea Uno");
        }
        public async Task TareaDos()
        {
            await Task.Delay(1000);
            Console.WriteLine("Tarea Dos");
        }
        public async Task TareaTres()
        {
            await Task.Delay(1000);
            Console.WriteLine("Tarea Tres");
        }
    }



}
