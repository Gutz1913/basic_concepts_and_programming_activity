using Shared;

namespace Final.Core;

public class Challenge7
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
                Console.WriteLine("****** EJERCICIO DE SUMA Y PROMEDIO ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Cuantos números desea: ");
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i}\t");
                    sum += i;
                }
                var average = sum / n;
                Console.WriteLine();
                Console.WriteLine($">>> La suma es.......................: {sum,10:N0} <<<");
                Console.WriteLine($">>> El promedio es...................: {average,10:N0} <<<");
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
