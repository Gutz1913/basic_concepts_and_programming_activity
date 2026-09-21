using Shared;

namespace Final.Core;

/* DESAFÍO 12 => ¿ES PRIMO?
Construir un programa que pida un número por pantalla y luego diga si es primo o no.
• Prueba 1: Al ejecutar el programa debe mostrar lo siguiente:
Ingrese número: 997
El número: 997, SI es primo
• Prueba 2: Al ejecutar el programa debe mostrar lo siguiente:
Ingrese número: 9
El número: 9, NO es primo */

public class Challenge12
{
    public void Run()
    {
        var answer = string.Empty;
        var options = new List<string> { "s", "n" };
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("::::::::: DESAFIOS DE PROGRAMACIÓN BÁSICA :::::::::");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine();
                Console.WriteLine("****** EJERCICIO DE NÚMEROS PRIMOS ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Ingrese un número: ");
                var isPrime = MyMath.IsPrime(n);
                Console.WriteLine();
                Console.WriteLine($">>> El número: {n} {(isPrime ? "SI" : "NO")} es primo <<<");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: >>> {ex.Message} <<<");
            }

            do
            {
                answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
            } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
        } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
    }
}