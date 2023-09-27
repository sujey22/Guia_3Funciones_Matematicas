using System;

public class EjemplodeEuler2
{
    public static void Main()
    {
        double valordeE = Math.E;
        Console.WriteLine("El valor de euler en origial es " + valordeE);
        Console.WriteLine();
        double eulerRedondeado = Math.Round(valordeE, 10);
        Console.WriteLine("El valor de euler redondeado a 10 posiciones es: " + eulerRedondeado);
        Console.WriteLine();
        Console.WriteLine("Hecho por Merlin Sujey Duarte Argueta");

    }
}
