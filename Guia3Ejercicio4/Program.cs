using System;
using System.Data;


//Math.Cbrt(double) Metodo


public class RaizCu
{
   public static void Main()
    {
        Console.WriteLine("Calculadora de ecuaciones de raíces de segundo grado");

        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());
       
        double discri = b * b - 4 * a * c;
        if (discri > 0)
        {
            double raiz1 = (-b + Math.Sqrt(discri)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(discri)) / (2 * a);
            Console.WriteLine("La ecuación cuadrática tiene dos puntos de intersección distintos con el eje x , y :");
            Console.WriteLine("El valor de Raíz 1 es: " + raiz1);
            Console.WriteLine("El valor de Raíz 2 es: " + raiz2);
        }
        else if (discri == 0)
        {
            double raiz = -b / (2 * a);
            Console.WriteLine("La ecuación cuadrática de los puntos son iguales:");
            Console.WriteLine("El valor de la Raíz es: " + raiz);
        }
        else
        {
            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(-discri) / (2 * a);
            Console.WriteLine("La ecuacion cuadratica tiene la mismas solución en la parte real, pero en la parte imaginaria son signos opuestos: ");
            Console.WriteLine("El valor de Raíz 1 es: " + parteReal + " + " + parteImaginaria + "i");
            Console.WriteLine("El valor de Raíz 2 es " + parteReal + " - " + parteImaginaria + "i");


        }

        Console.WriteLine();
        Console.WriteLine("Hecho por Merlin Sujey Duarte Argueta");

    }

}
