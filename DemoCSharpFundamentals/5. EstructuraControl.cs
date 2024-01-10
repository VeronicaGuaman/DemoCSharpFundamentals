namespace DemoCSharpFundamentals
{
    internal class EstructuraControl
    {
        // sentencia if 
        public void EstructuraIf()
        {
            int numeroUno = 10;
            int numeroDos = 20;

            if (numeroUno > numeroDos)
            {
                Console.WriteLine("a es mayor que b");
            }
            else if (numeroUno == numeroDos)
            { 
                Console.WriteLine("a es igual que b");
            }
            else
            {
                Console.WriteLine("b es mayor o igual que a");
            }

            if(numeroUno< numeroDos)
                Console.WriteLine("a es menor que b");
            else if (numeroUno == numeroDos)
                Console.WriteLine("a es igual que b");
            else
                Console.WriteLine("b es menor que a");

            //operador ternario
            string mensaje = (numeroUno > numeroDos) ? "a es mayor que b" : "b es mayor o igual que a";
            int edad = 16;

            int edadMinima = (numeroUno > numeroDos) ? 18 : 20;
            //bool menorEdad = 
        }

        //Switch
        public void EstructuraSwitch()
        {
            int dia = 3;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Día inválido");
                    break;
            }
        }

        //switch expression
        public void EstructuraSwitchExpression()
        {
            int dia = 3;

            string nombreDia = dia switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Día inválido"
            };

            Console.WriteLine(nombreDia);
        }

    }
}
