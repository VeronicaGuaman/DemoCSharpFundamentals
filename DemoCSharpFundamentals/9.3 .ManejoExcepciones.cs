namespace DemoCSharpFundamentals
{
    public class ManejoExcepciones
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"El numero ingresado es {numero}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }

        public void Ejemplo1()
        {
            try
            {
                int numeroUno = 10;
                int numeroDos = 0;
                int division = numeroUno / numeroDos;

                Console.WriteLine($"Resultado división: {division}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
