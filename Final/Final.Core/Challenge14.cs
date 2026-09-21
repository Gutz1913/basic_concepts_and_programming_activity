using Shared;

namespace Final.Core;

public class Challenge14
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
                Console.WriteLine("****** EJERCICIO DEL NÚMERO PI ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Cuantos términos de precisión desea: ");
                var pi = CalculatePi(n);
                Console.WriteLine();
                Console.WriteLine($">>> El valor de 'pi' con {n} términos de precisión es: {pi,10} <<<");
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

    double CalculatePi(int n)
    {
        double sum = 0;
        double den = 1;
        int sign = 1;
        for (int i = 0; i < n; i++)
        {
            double term = 1 / den * sign;
            sum += term;
            den += 2;
            sign *= -1;
        }
        return sum * 4;
    }
}