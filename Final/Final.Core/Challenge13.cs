using Shared;

namespace Final.Core;

/* DESAFÍO 13 => CÁLCULO DEL NÚMERO e
Hacer un programa que calcule el número natural e, dado el número de términos requeridos por el usuario.
• Prueba: Al ejecutar el programa debe mostrar lo siguiente:
Cuantos términos de precisión desea: 10
El valor de 'e' con 10 términos de precisión es: 2.718281525573192243
*/

public class Challenge13
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
                Console.WriteLine("****** EJERCICIO DEL NÚMERO e ******");
                Console.WriteLine();
                var n = ConsoleExtension.GetInt("Cuantos términos de precisión desea: ");
                var e = CalculateE(n);
                Console.WriteLine();
                Console.WriteLine($">>> El valor de 'e' con {n} términos de precisión es: {e} <<<");
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

    double CalculateE(int n)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += 1 / MyMath.Factorial(i);
        }
        return sum;
    }
}