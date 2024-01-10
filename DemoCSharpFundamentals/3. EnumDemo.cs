namespace DemoCSharpFundamentals;
public enum DiasDeLaSemana
{
    Lunes,
    Martes,
    Miércoles,
    Jueves,
    Viernes,
    Sábado,
    Domingo
}

public class EjemploEnum
{ 
    string lunes = "Lunes";
    string martes = "Martes";

    string diaIngresasdo = "Sábado";

    public void Comparacion() { 
        if(diaIngresasdo == lunes)
            Console.WriteLine("Es lunes");

        if (diaIngresasdo == "Lunes")
        {
            Console.WriteLine("Es lunes");
        }

        if (diaIngresasdo == DiasDeLaSemana.Lunes.ToString())
            Console.WriteLine("Es lunes");
    }
    
}

enum EstadoCivil
{
    //Por defecto el primer valor es 0
    Soltero = 200,
    Casado = 8,
    Divorciado = 9,
    Viudo = 10
}

public class EjemploEnumUno
{

}
static class EnumDemo
{
    public static void Run()
    {
        // 2. Enumerable
        EstadoCivil estadoCivil = EstadoCivil.Soltero;
        int estadoCivilInt = (int)estadoCivil;
        string estadoCivilString = estadoCivil.ToString();

        Console.WriteLine(estadoCivil);
        Console.WriteLine(estadoCivilInt);
        Console.WriteLine(estadoCivilString);

        // 3. Enumerables
        DiasDeLaSemana dia = DiasDeLaSemana.Lunes;
        Console.WriteLine(dia);
        Console.WriteLine((int)dia);
        Console.WriteLine(dia.ToString());
    }

}