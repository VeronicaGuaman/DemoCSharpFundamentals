
using DemoCSharpFundamentals;
// 1.2. Comentarios

// Este es un comentario de una linea

/*
 * * Este es un comentario
 * * de varias lineas
 * */

// 5. Enumerable
//EnumDemo.Run();


// 4. Operaciones y expresiones
//Operaciones_Expresiones.Operaciones();

// 5. Estructuras de control

// 6. Arreglos y listas

// 7. Metodos
//Metodos metodos = new Metodos();
//metodos.MetodoSobrecargado(2, 5);


//9.4 Programación asíncrona

//ProgramacionAsincrona.PedidoPizza();
//ProgramacionAsincrona.PedidoHamburguesa();

//ProgramacionAsincrona.PedidoPizzaAsync();
//ProgramacionAsincrona.PedidoHamburguesaAsync();

//Otro Ejemplo de Progamación asincrona
//Console.WriteLine("Inicio de la aplicación.");
//// Iniciamos un proceso principal
//ProductoServicio.ProcesarProductos();
//// Mientras el proceso principal se ejecuta, el hilo principal puede realizar otras tareas
//Console.WriteLine("Haciendo otras tareas mientras el proceso principal se ejecuta.");
//// Simulamos la realización de una venta en otro hilo
//await Task.Run(() => ProductoServicio.RealizarVenta("Laptop", 1));
//// Esperamos un momento para permitir que las operaciones asíncronas se completen
//Thread.Sleep(3000);
//// Mostramos el inventario después de las operaciones
//ProductoServicio.MostrarInventario();
//Console.WriteLine("Fin de la aplicación.");

// Otro ejemplo de programación asincrona
//var stopwatch = new Stopwatch();
//AsincroniaEjemploTres asincroniaEjemploTres = new AsincroniaEjemploTres();
//stopwatch.Start();
//await asincroniaEjemploTres.EjecutarTareas();
//stopwatch.Stop();
//Console.WriteLine($"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds/1000} segundos");


//9.5 Delegados
//Delegados delegados = new Delegados();

//delegados.EjemploDelegado();

// 9.6 Delegados con Lambda

Metodos metodos = new Metodos();

//int respuesta =  metodos.MetodoConParametros(1,4);
//int respuesta =  metodos.MetodoConParametrosOpcionales(1);
//llamar a un metodo con parametros de salida
//metodos.MetodoConParametrosGenericosYRestricciones<string>("Hola mundo");

//PersonaClase veronica = new PersonaClase();
//veronica.Nombre = "Veronica";
//veronica.Apellido = "guaman";
//veronica.Respira();

//PersonaClase mary = new PersonaClase();
//mary.Nombre = "Mary";
//mary.Apellido = "León";

//int suma = CalcularOperaciones.Suma();


//contructor
ConstructorClase constructor = new ConstructorClase();

constructor.Nombre = "Veronica";
constructor.Apellido = "Guaman";

ConstructorClase Vero = new ConstructorClase("Veronica", "Guaman");

Console.ReadKey();

