using Shared;

namespace Final.Core;

public class Challenge3
{
    public void Run()
    {
        var answer = string.Empty;
        var options = new List<string> { "s", "n" };
        do
        {
            var currentYear = DateTime.Now.Year;
            var message = string.Empty;
            var year = 0;
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("::::::::: DESAFIOS DE PROGRAMACIÓN BÁSICA :::::::::");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine();
                Console.WriteLine("****** EJERCICIO DEL AÑO BISIESTO ******");
                Console.WriteLine();
                year = ConsoleExtension.GetInt("Ingrese el año que desea consultar.: ");
                Console.WriteLine();
                if (year == currentYear)
                {
                    message = "es";
                }
                else if (year > currentYear)
                {
                    message = "va a ser";
                }
                else
                {
                    message = "fue";
                }
                var isLeapYear = DateUtilities.IsLeapYear(year);
                Console.WriteLine($">>> El año {year}, {(isLeapYear ? "SI" : "NO" )} {message} bisiesto <<<");

                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine($"Error: >>> Lo que ingresaste no es un año válido <<<");
            }

            do
            {
                answer = ConsoleExtension.GetValidOptions("¿Deseas continuar? ¿[S]í, [N]o?: ", options);
            } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
        } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
    }
}