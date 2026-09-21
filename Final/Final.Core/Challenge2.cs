using Shared;

namespace Final.Core;

public class Challenge2
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
                Console.WriteLine("****** EJERCICIO DEL NÚMERO MAYOR ******");
                Console.WriteLine();
                var n1 = ConsoleExtension.GetInt("Ingrese el primer número.: ");
                var n2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");
                var n3 = ConsoleExtension.GetInt("Ingrese el tercer número.: ");
                Console.WriteLine();
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine($">>> El número mayor es: {n1} <<<");
                }
                else if (n2 > n1 && n2 > n3)
                {
                    Console.WriteLine($">>> El número mayor es: {n2} <<<");
                }
                else if (n3 > n1 && n3 > n2)
                {
                    Console.WriteLine($">>> El número mayor es: {n3} <<<");
                }
                else
                {
                    Console.WriteLine(">>> Hay números iguales o no se puede determinar un único mayor <<<");
                }
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