namespace DemoCSharpFundamentals
{
    public class DateType
    {
        // Tipos de datos
        // Números enteros
        sbyte sShortNumber = 127;                   //  8 bits de -128 a 127
        byte byteNumber = 255;                      // 8 bits de 0 a 255
        short shortNumber = 32767;                  // 16 bits de -32768 a 32767
        ushort uShortNumber = 65535;                // 16 bits de 0 a 65535
        int intNumber = 2147483647;                 // 32 bits de -2147483648 a 2147483647
        uint uintNumber = 4294967295;               // 32 bits de 0 a 4294967295
        long longNumber = 9223372036854775807;      // 64 bits de -9223372036854775808 a 9223372036854775807
        ulong ulongNumber = 18446744073709551615;   // 64 bits de 0 a 18446744073709551615

        // Números decimales
        float floatNumber = 10.5f;                  // 32 bits de 1.5 x 10-45 a 3.4 x 10-38
        double doubleNumber = 10.32324324234d;      // 64 bits de 5.0 x 10-324 a 1.7 x 10-308
        decimal decimalNumber = 10.5m;              // 128 bits de 1.0 x 10-28 a 7.9 x 10-28
        
        // Caracteres y cadenas
        char caracther = 'a';                       // 16 bits, un caracter, comillas simples
        string cadena = "Hello";                    // Cadena de caracteres, comillas dobles

        // Booleanos y objetos
        bool IsBool = true;                         // true o false
        object objectTest = new object();           // Cualquier tipo de dato
        
        dynamic dynamicTest = 10;                   // Cualquier tipo de dato, se define en tiempo de ejecución      
    }
}
