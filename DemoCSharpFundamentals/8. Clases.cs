namespace DemoCSharpFundamentals
{
    // Nivel de acceso, puede, ser publica, privada, protegida, etc.
    public class PersonaClase()
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        protected int Edad { get; set; }

        public void Respira() { }

        private void Come() { }
    }

    // public - Acceso desde cualquier parte, ejemplo otro proyecto, otra dll, etc.
    // internal - Acceso desde el mismo ensamblado, ejemplo un proyecto, una dll, etc.    
    // protected - Acceso desde la misma clase o clases derivadas, ejemplo herencia
    // private - Acceso desde la misma clase, ejemplo encapsulamiento
    // protected internal - Acceso desde la misma clase, clases derivadas o mismo ensamblado, ejemplo herencia
    // private protected - Acceso desde la misma clase o clases derivadas del mismo ensamblado, ejemplo herencia

    // clase estatica
    public static class CalcularOperaciones
    {
        public static int Suma()
        {
            return 1 + 3;
        }
        public static void Resta()
        {

        }

        public static void Multiplicacion()
        {

        }
    }
}
