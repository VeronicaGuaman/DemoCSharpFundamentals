namespace DemoCSharpFundamentals
{
    public class Persona
    {
        //atributos
        public required string Nombre { get; set; }   //get y set son metodos especiales para acceder a los atributos
        public string? Apellido { get; set; }         //get: obtener el valor del atributo
        public int? Edad { get; set; }                //set: asignar un valor al atributo
        public string EdadReal { get;} = "20";      //? indica que el atributo puede ser nulo

        //metodos
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido} y tengo {Edad} años y mi edad real es {EdadReal}");
        }

    }

    public class Empleado : Persona
    {
        private string Direccion { get; set; }
        public void Informacion()
        {
            Nombre = "Juan";
            Apellido = "Perez";
            Edad = 20;
            Direccion = "Av. Siempre viva 123";
        }
    }
}
