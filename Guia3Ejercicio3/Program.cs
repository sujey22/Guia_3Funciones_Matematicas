using System;

class SumadeCuadrados
{
    public static void Main()
    {
        int num = 20;
        int suma = 0;

        for (int i = 1;i <= num; i++)
        {
            int cuadrado = i*i;
            suma += cuadrado;
        }

        Console.WriteLine("La suma acumulada de los cuadrados de los primeros 20 digitos es: " + suma);
        Console.WriteLine();
        Console.WriteLine("Hecho por Merlin Sujey Duarte Argueta");

    }
}
