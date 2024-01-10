using static DemoCSharpFundamentals.DelegadosLambda;

namespace DemoCSharpFundamentals
{
    public class DelegadosLambda
    {
        public delegate int TestDelegado(int a, int b);

        private TestDelegado testDelegado;
        public void Ejemplo()
        {
            testDelegado = (a, b) => a + b;
            Console.WriteLine(testDelegado(5, 10));

            testDelegado = delegate (int a, int b) { return a - b; };
            Console.WriteLine(testDelegado(10, 5));

            testDelegado = (a, b) =>
            {
                int resultado = a * b;
                return resultado;
            };

            //ejemplo 1
            //Func es un delegado generico que puede recibir hasta 16 parametros, usamos func cuando necesitamos un valor de retorno
            //el ultimo parametro es el tipo de retorno
            //el resto de parametros son los parametros de entrada

            Func<int, int> cuadrado = x => x * x;                           //cuando solo hay una linea de codigo, no es necesario usar llaves
            Console.WriteLine($"El cuadrado de 5 es: {cuadrado(5)}");

            //ejemplo 2
            Func<int, int, int> suma = (x, y) => x + y;            
            Console.WriteLine($"La suma de 5 y 10 es: {suma(5, 10)}");

            //ejemplo 3
            Func<int, int, int> resta = (x, y) =>
            {
                int resultado = x - y;
                return resultado;
            };
            Console.WriteLine($"La resta de 10 y 5 es: {resta(10, 5)}");



            //ejemplo 4
            //Action es un delegado generico que puede recibir hasta 16 parametros, usamos action cuando no necesitamos un valor de retorno

            Action<string> saludar = nombre => Console.WriteLine($"Hola {nombre}");
            saludar("Juan");

            //ejemplo 5
            Action<string, string> saludar2 = (nombre, apellido) => Console.WriteLine($"Hola {nombre} {apellido}");
            saludar2("Juan", "Perez");

            //ejemplo 6
            Action<string, string> saludar3 = (nombre, apellido) =>
            {
                Console.WriteLine($"Hola {nombre} {apellido}");
            };
            saludar3("Juan", "Perez");
        }
    }
}
