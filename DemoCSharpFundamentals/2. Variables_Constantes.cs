using System.Text;

namespace DemoCSharpFundamentals
{
    internal class Variables_Constantes
    {
        public void Ejemplo()
        {
            string nombreEjemplo = string.Empty;
            int dias = 365;
            bool esProfe = true;
            DateTime fecha = DateTime.Now;

            nombreEjemplo = "Andrea";
            dias = 366;
            esProfe = false;
            fecha = new DateTime(2024, 1, 8);


            // --------------- Constantes -----------------
            const double PI = 3.1416;
            const int VALOR = 10;
            const string mensaje = "Mensaje por defecto";

            //PI = 3.14;                          // Error
            //VALOR = 20;                         // Error
            //mensaje = "Mensaje modificado";     // Error

            // --------------- Var y Dinamic -----------------
            //var - se define en tiempo de compilación
            //var apellido;
            var apellidoVar = "Guaman";
            //apellidoVar = 10;

            var edad = 10;

            //dinamic - se define en tiempo de ejecución
            dynamic apellido = "Guaman";
        }

        //Conversiones
        public void Conversiones()
        {
            // Conversión implícita
            int a = 10;
            double b = Convert.ToDouble(a);   // Conversión implícita de int a double

            // Conversión explícita
            double c = 9.8;
            int d = (int)c; // Conversión explícita de double a int

            // Conversión con clases wrapper
            int e = 10;
            double f = Convert.ToDouble(e); // Conversión de int a double con la clase wrapper Convert

            // Conversión con métodos Parse
            string g = "10";
            int h = int.Parse(g); // Conversión de string a int con el método Parse

            int nariableEjemplo = 10;
            string j = nariableEjemplo.ToString(); // Conversión de int a string con el método ToString

            // Conversión con métodos TryParse           
            //bool conversionExitosa = int.TryParse(i, out j); // Conversión de string a int con el método TryParse
        }


        public void ManejoStrings()
        {
            string nombre = "Verónica";
            const string SALUDO = "Hola";

            // Concatenación
            string saludoCompleto = SALUDO + " " + nombre;                  // Hola Verónica
            string saludoCompleto2 = string.Concat(SALUDO, " ", nombre);    // Hola Verónica
            string saludoOpcion2 = $"{SALUDO} {nombre} FELIZ AÑO NUEVO";                    // Hola Verónica FELIZ AÑO NUEVO
            string saludoOpcion3 = string.Format("{0} {1}", SALUDO, nombre);// Hola Verónica

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(SALUDO);
            stringBuilder.Append("Te saluda el curso de CF");
        }
    }
}
