using Shared;

namespace Final.Core;

/* DESAFÍO 1 => NUMERO ES PAR O IMPAR
Construir un programa que pida un número y luego diga si este número es par o impar
• Prueba 1 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese un número: 10
El número 10 es par
• Prueba 2 => Al ejecutar el programa debe mostrar lo siguiente
Ingrese un número: 7
El número 7 es impar */

public class Challenge1
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
                Console.WriteLine("****** EJERCICIO DE NÚMEROS PARES O IMPARES ******");
                Console.WriteLine();
                var num = ConsoleExtension.GetInt("Ingrese un número: ");
                if (num % 2 == 0)
                {
                    Console.WriteLine($">>> El número {num}, es par <<<");
                }
                else
                {
                    Console.WriteLine($">>> El número {num}, es impar <<<");
                }
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
