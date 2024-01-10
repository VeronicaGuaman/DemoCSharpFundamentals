namespace DemoCSharpFundamentals
{
    public class Delegados
    {
       //ejemplo basico de delegados
       //palabra reservada =>  delegate
       //sintaxis: [nivel de acceso] delegate [tipo de retorno] [nombreDelegado]([Parámetros] opcional);
        public delegate void MiDelegado(string mensaje);

        public void EjemploDelegado()
        {
            //Asignacion del delegado
            MiDelegado delegado = MensajeBienvenida;
            delegado("Juan");

            Console.WriteLine("Asignacion del otro delegado");
            //Asignacion de otro método al delegado
            delegado = MensajeDespedida;
            delegado("Vero");

            //asignacion de un metodo que recibe un delegado como parametro de entrada
            //MetodoDelegado(delegado, "Juan"); //se puede asignar cualquier metodo que tenga la misma firma que el delegado
        }

        public void MensajeBienvenida(string nombre)
        {
            Console.WriteLine($"Bienvenido {nombre}");
        }

        public void MensajeDespedida(string nombre)
        {
            Console.WriteLine($"Hasta Luego {nombre}");
        }

        //metodo que recibe un delegado como parametro de entrada
        public void MetodoDelegado(MiDelegado delegado, string nombre)
        {
            delegado(nombre);
        }
        //ejemplo de delegado con retorno, este no podría asignarse al delegado anterior
        public string MensajePersonalizado(string nombre)
        {
            return($"Hola {nombre}");
        }
    }
}
