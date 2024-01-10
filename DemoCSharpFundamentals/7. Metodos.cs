namespace DemoCSharpFundamentals
{
    class Metodos
    {
        // 1. Métodos
        // 1.1. Métodos sin retorno
        public static void MetodoSinRetorno() 
        {
            Console.WriteLine("Hola mundo");
        }
               
        
        // 1.2. Métodos con retorno
        public int MetodoConRetorno()
        {
            //invocar metodo
            return 1;
        }

        // 1.3. Métodos con parámetros
        public int MetodoConParametros(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }

        // 1.4. Métodos con parámetros opcionales
        public int MetodoConParametrosOpcionales(int numeroUno, int numeroDos = 5)  //Los parametros opcionales deben ir al final
        {
            return numeroUno + numeroDos;
        }
        
        // 1.7. Métodos con parámetros de salida
        //explicacion: los parametros de salida se utilizan para retornar mas de un valor
        // ¿como se usa? se debe declarar el parametro con la palabra reservada out, y dentro del metodo se debe asignar un valor a la variable
        // se invoca al metodo de la siguiente manera:
        // int numeroUno;
        // int numeroDos;
        // MetodoConParametrosDeSalida(out numeroUno, out numeroDos);
        public void MetodoConParametrosDeSalida(out int numeroUno, out int numeroDos)
        {
            numeroUno = 1;
            numeroDos = 2;
        }
        // 1.8. Métodos con parámetros de tipo var
        
        // 1.12. Métodos con parámetros de tipo genérico
        public void MetodoConParametrosGenericos<T>(T parametro)
        {
            Console.WriteLine(parametro);
        }

        // 1.13. Métodos con parámetros de tipo genérico y restricciones
        public void MetodoConParametrosGenericosYRestricciones<T>(T parametro) where T : class
        {
            Console.WriteLine(parametro);
        }

        //sobrecarga de metodos
        public void Add(int numeroUno)
        {
            Console.WriteLine(numeroUno);
        }

        public void Add(int numeroNumero, int edad)
        {
            Console.WriteLine("Hola Mundo");
        }

        //Metodos con variables locales
        public void MetodoConVariablesLocales()
        {
            int numeroUno = 1;
            int numeroDos = 2;
            Console.WriteLine(numeroUno + numeroDos);
        }

        public void MetodoConVariablesLocalesDos()
        {
            int numeroUno;
            //Console.WriteLine(numeroUno + numeroDos);
        }
    }
}
