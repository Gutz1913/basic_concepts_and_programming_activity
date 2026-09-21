using Shared;

namespace Final.Core;

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

