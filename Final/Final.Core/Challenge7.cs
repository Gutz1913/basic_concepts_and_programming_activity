using Shared;

namespace Final.Core;

/* DESAFÍO 7 => SERIE DE NÚMEROS, SUMATORIA Y PROMEDIO
Construir un programa que imprima N numeros, su sumatoria y su promedio.
• Prueba => Al ejecutar el programa debe mostrar lo siguiente:
Cuantos números desea: 100
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
16 17 18 19 20 21 22 23 24 25 26 27 28 29
30 31 32 33 34 35 36 37 38 39 40 41 42 43
44 45 46 47 48 49 50 51 52 53 54 55 56 57
58 59 60 61 62 63 64 65 66 67 68 69 70 71
72 73 74 75 76 77 78 79 80 81 82 83 84 85
86 87 88 89 90 91 92 93 94 95 96 97 98 99
100
La suma es: 5050
El promedio es: 50
*/

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
