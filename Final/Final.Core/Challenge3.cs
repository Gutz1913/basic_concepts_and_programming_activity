using Shared;

namespace Final.Core;

/* DESAFÍO 3 => AÑO BISIESTO
Construir un programa que pida un año y luego determine si el año es bisiesto o no. 
Tenga en cuenta que los años bisiestos son los números múltiplos de 4, pero que no son múltiplos de 100 y si son múltiplos de 100 y múltiplos de 400 sí son bisiestos. 
• Prueba 1 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese el año que desea consultar: 1974
El año 1974, NO fue bisiesto.
• Prueba 2 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese el año que desea consultar: 2000
El año 2000, SI fue bisiesto.
• Prueba 3 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese el año que desea consultar: 2026
El año 2012, NO es bisiesto.
• Prueba 4 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese el año que desea consultar: 2028
El año 2028, SI va a ser bisiesto. */

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