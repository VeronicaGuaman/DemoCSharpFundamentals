namespace DemoCSharpFundamentals
{
    public static class Operaciones_Expresiones
    {
        public static void Operaciones()
        {
            int numeroUno = 5;
            int numeroDos = 3;

            // Operadores aritméticos
            int suma = numeroUno + numeroDos;        // suma = 8
            int resta = numeroUno - numeroDos;       // resta = 2
            int multiplicacion = numeroUno * numeroDos;  // multiplicacion = 15
            int division = numeroUno / numeroDos;    // division = 1 (en C# la división de enteros produce un entero)

            // Operadores de asignación
            int resultado = 10;
            resultado += 5;   // resultado = resultado + 5;  // resultado = 15
            resultado = resultado - 5;  // resultado = 10
            resultado -= 6;

            // Operadores de comparación
            bool esIgual = (numeroUno == numeroDos);    // esIgual = false
            bool esMayor = (numeroUno >= numeroDos);     // esMayor = true

        }

        public static void Expresiones()
        {
            // Expresiones
            int a = 10;
            int b = 20;
            int c = a + b * 2;
            int d = (a + b) * 2;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
