using Shared;

namespace Final.Core;

/* DESAFÍO 9 => SERIE DE TAYLOR 
Construir un programa que calcule los n primeros términos de la serie de Taylor
• Prueba 1 => Al ejecutar el programa debe mostrar lo siguiente:
Cuantos términos desea: 20
Digita el valor de x: 1
f(x) = 2,718282
• Prueba 2 => Al ejecutar el programa debe mostrar lo siguiente:
Cuantos términos desea: 500
Digita el valor de x: 2
f(x) = 7,389056 */

public class Challenge9
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
                Console.WriteLine("****** EJERCICIO DE LA SERIE DE TAYLOR ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Ingrese el número de términos: ");
                var x = ConsoleExtension.GetDouble("Ingrese el valor de x........: ");
                var taylor = Taylor(x, n);
                Console.WriteLine();
                Console.WriteLine($">>> f({x}) = {taylor:N5} <<<");
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

    double Taylor(double x, int n)
    {
        double sum = 0;
        int signo = 1;
        for (int i = 0; i < n; i++)
        {
            sum += Math.Pow(x, i) / MyMath.Factorial(i) * signo;
            signo *= -1;
        }
        return sum;
    }
}

