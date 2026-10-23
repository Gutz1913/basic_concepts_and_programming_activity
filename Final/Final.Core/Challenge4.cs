using Shared;

namespace Final.Core;

/* DESAFÍO 4 => DESCUENTOS
Un almacén de escritorios hace los siguientes descuentos: si el cliente compra menos de 5 unidades se le da un
descuento del 10% sobre la compra; si el número de unidades es mayor o igual a cinco pero menos de 10 se le otorga un 20% y, si son 10 o más se le da un 40%.
Hacer un programa que determine cuánto debe pagar un cliente si el valor de cada escritorio es de $650.000.
• Prueba => Al ejecutar el programa debe mostrar lo siguiente
Ingrese el número de escritorios: 7
El valor a pagar es: 3'640.000 */

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