using Shared;

namespace Final.Core;

public class Challenge5
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
                Console.WriteLine("****** EJERCICIO DE VALOR DE MATRÍCULA ******");
                Console.WriteLine();
                var credits = ConsoleExtension.GetInt("Ingrese el número de créditos.......: ");
                var creditValue = ConsoleExtension.GetDecimal("Ingrese el valor por crédito........: ");
                var stratum = ConsoleExtension.GetInt("Ingrese el estrato del estudiante...: ");
                var registrationValue = CalculateRegistrationValue(credits, creditValue, stratum);
                var subsidy = CalculateSubsidy(stratum);
                Console.WriteLine();
                Console.WriteLine($">>> Costo de la matrícula..........: {registrationValue,20:C2} <<<");
                Console.WriteLine($">>> Valor del subsidio.............: {subsidy,20:C2} <<<");
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

    decimal CalculateSubsidy(int stratum)
    {
        if (stratum == 1)
        {
            return 200000m;
        }
        if (stratum == 2)
        {
            return 100000m;
        }
        return 0;
    }

    decimal CalculateRegistrationValue(int credits, decimal creditValue, int stratum)
    {
        decimal value;
        if (credits <= 20)
        {
            value = credits * creditValue;
        }
        else
        {
            value = (20 * creditValue) + ((credits - 20) * creditValue * 2m);
        }

        if (stratum == 1)
        {
            return value * 0.2m;
        }
        if (stratum == 2)
        {
            return value * 0.5m;
        }
        if (stratum == 3)
        {
            return value * 0.7m;
        }
        return value;
    }
}