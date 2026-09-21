using Shared;

namespace Final.Core;

public class Challenge11
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
                Console.WriteLine("****** EJERCICIO SERIE FIBONACCI ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Cuantos términos quiere (mínimo 2): ");
                double a = 0;
                double b = 1;
                Console.WriteLine();
                Console.Write($">>> {a,5:N0}{b,10:N0}");
                for (int i = 2; i < n; i++)
                {
                    double c = a + b;
                    Console.Write($"{c,10:N0} ");
                    a = b;
                    b = c;
                }
                Console.Write("\t<<<");
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