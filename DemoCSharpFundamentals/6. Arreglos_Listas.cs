namespace DemoCSharpFundamentals
{
    internal class Arreglos_Listas
    {
        public void Arreglos()
        {
            // Arreglos
            // explicación: un arreglo es una estructura de datos que almacena una colección de elementos del mismo tipo
            // en C# los arreglos son de tamaño fijo, es decir, una vez que se crea el arreglo no se puede cambiar su tamaño
            
            int[] arreglo = new int[5];
            arreglo = new int[] { 1, 2, 3, 4, 5 };

            int[] empleadosIds = new int[5];
            empleadosIds[0] = 1;
            empleadosIds[1] = 2;

            int primerEmpleadoId = empleadosIds[0];
            int segundoEmpleadoId = empleadosIds[1];


            //rrecorer arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
            }

        }

        //Colecciones, Listas
        public void Listas() 
        { 
            // Listas
            // explicación: una lista es una estructura de datos que almacena una colección de elementos del mismo tipo
            // en C# las listas son de tamaño variable, es decir, se pueden agregar o eliminar elementos en tiempo de ejecución
            // no necesitan un tamaño inicial
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            lista.Remove(3);

            //rrecorer lista
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            //Usar métodos de la lista
            lista.Clear();                              //limpiar lista
            bool contieneElemento = lista.Contains(1);  //verificar si contiene un elemento
            lista.IndexOf(1);                           //obtener el indice de un elemento
            lista.Insert(0, 1);                         //insertar un elemento en un indice especifico
            lista.Remove(1);                            //remover un elemento
            lista.RemoveAt(0);                          //remover un elemento en un indice especifico
            int numeroElementos = lista.Count();        //obtener la cantidad de elementos
            lista.Sort();                               //ordenar la lista
        }
    }
}
