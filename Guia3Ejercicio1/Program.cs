using System;
public class EjemplodePi1
{
    public static void Main()
    {
        double valordePi = Math.PI;
        Console.WriteLine("El valor de pi en origial es " + valordePi);
        Console.WriteLine();
        double truncate = Math.Truncate(valordePi);
        Console.WriteLine("El valor truncado es de: " + truncate);
        Console.WriteLine();
        double piRedondhacArriba = Math.Ceiling(valordePi);
        Console.WriteLine("El valor redondeado hacia arriba es: " + piRedondhacArriba);
        Console.WriteLine();
        double piRedondhacAbajo = Math.Floor(valordePi);
        Console.WriteLine("El valor redondeado hacia abajo es: " + piRedondhacAbajo);
        Console.WriteLine();
        Console.WriteLine("Hecho por Merlin Sujey Duarte Argueta");

    }
}
