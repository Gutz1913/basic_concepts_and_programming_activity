using Shared;

namespace Final.Core;

/* DESAFÍO 8 => CÁLCULO DEL FACTORIAL DE UN NÚMERO
Construir un programa que imprima el factorial de un número dado. La función factorial se representa como:
n! = 1x2x3x4x....x(n - 1) x n
Es decir, que factorial de 5 = 1 x 2 x 3 x 4 x 5 = 120.
• Prueba 1 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese número: 5
El factorial es: 120
• Prueba 2 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese número: 20
El factorial es: 2432902008176640000 */

public class Challenge8
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
                Console.WriteLine("****** EJERCICIO DE FACTORIAL ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Ingrese número: ");
                var factorial = MyMath.Factorial(n);
                Console.WriteLine();
                Console.WriteLine($">>> {n}! = {factorial:N0} <<<");
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