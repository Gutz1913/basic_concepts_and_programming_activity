using Shared;

namespace Final.Core;

/* DESAFÍO 5 => VALOR MATRÍCULA
Se desea obtener el valor de la matrícula de un estudiante, el cual se calcula de la siguiente manera en un subprograma:
• Si toma 20 o menos créditos, paga el crédito al valor normal.
• Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
• Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
    • Si el estrato es 1, el descuento es del 80%.
    • Si el estrato es 2, el descuento es del 50%.
    • Si el estrato es 3, el descuento es del 30%.
Además los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera (el cual se debe calcular en otro subprograma):
• Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
• Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.

• Prueba => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese el número de créditos: 25
Ingrese el valor por crédito: 85000
Ingrese el estrato del estudiante: 2
Costo de la matrícula: 1'275.000
Valor del subsidio: 100000 */

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