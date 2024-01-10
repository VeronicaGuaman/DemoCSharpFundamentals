namespace DemoCSharpFundamentals
{
    //Clase abstracta
    //explicación: es una clase que no se puede instanciar, es decir, no se puede crear un objeto de ese tipo
    //Puede ser heredada por otras clases
    public abstract class ClaseAbstracta
    {
        public string Nombre;
        public abstract void MetodoAbstracto();

        public void Metodo()
        {
            Console.WriteLine("Método con implementación");
        }
        public int MetodoConRetorno()
        {
            return 1;
        }   
    }

    //Ejemplo de herencia de una clase abstracta
    // Puede ser implementada por otras clases, o no ser implementada
    public class Veronica : ClaseAbstracta
    {
        public override void MetodoAbstracto()
        {
            Console.WriteLine("Método abstracto implementado");
        }
    }

    //Interfaz
    //explicación: es una clase que no se puede instanciar, es decir, no se puede crear un objeto de ese tipo
    //Puede ser implementada por otras clases
    //todos los metodos son publicos y abstractos
    public interface IContrato
    {
        void Limpiar();
        void Pagar();
        void RespetarVecinos();
    }

    public interface IPagar
    {
        void PagarAtiempo();
    }
    //Ejemplo de implementación de una interfaz
    public class ArrendatarioVeronica : IContrato
    {
        public void Limpiar()
        {
            Console.WriteLine("Veronica limpia");
        }

        public void Pagar()
        {
            Console.WriteLine("Veronica paga");
        }

        public void RespetarVecinos()
        {
            Console.WriteLine("Veronica respeta a sus vecinos");
        }
    }

    public class ArrendatarioMary : IContrato
    {
        public void Limpiar()
        {
            Console.WriteLine("Mary limpia");
            Console.WriteLine("Mary limpia solo los sabados");
        }

        public void Pagar()
        {
            Console.WriteLine("Mary paga");
            Console.WriteLine("Mary paga Tarde");
        }

        public void RespetarVecinos()
        {
            Console.WriteLine("Mary respeta a sus vecinos");
        }
    }


    public interface IInterface { }
    //ejemplo de herencia múltiple
    public class ClaseHijaInterfaz : ClaseAbstracta, IInterface
    {
        public override void MetodoAbstracto()
        {
            throw new NotImplementedException();
        }

        public void MetodoInterfaz()
        {
            throw new NotImplementedException();
        }
    }

    //diferencia entre clase abstracta y una interfaz
    //una clase abstracta puede tener métodos con implementación y una interfaz no
    //una clase puede heredar de una sola clase abstracta, pero puede implementar varias interfaces
    //una clase abstracta puede heredar de una clase abstracta o implementar una interfaz
    //una interfaz puede heredar de una o varias interfaces
    //una interfaz no puede heredar de una clase abstracta
    //una interfaz no puede heredar de una clase

}
