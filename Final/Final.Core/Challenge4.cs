using Shared;

namespace Final.Core;

public class Challenge4
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
                Console.WriteLine("****** EJERCICIO DE DESCUENTOS ******");
                Console.WriteLine();
                var desks = ConsoleExtension.GetInt("Ingrese el número de escritorios: ");
                var valueToPay = CalculateValue(desks);
                Console.WriteLine();
                Console.WriteLine($">>> El valor a pagar es: {valueToPay,20:C2} <<<");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: >>> { ex.Message } <<<");
            }

            do
            {
                answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
            } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
        } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
    }

    decimal CalculateValue(int desks)
    {
        float discount;
        if (desks < 5)
        {
            discount = 0.1f;
        }
        else if (desks >= 5 && desks < 10)
        {
            discount = 0.2f;
        }
        else
        {
            discount = 0.4f;
        }
        return desks * 650000M * (decimal)(1 - discount);
    }
}