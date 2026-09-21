using Shared;

namespace Final.Core;

/* DESAFÍO 10 => ECUACIONES CUADRÁTICAS
Construir un programa que resuelva los valores de X para una ecuación cuadrática
• Prueba 1 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese valor de a: 1
Ingrese valor de b: 3
Ingrese valor de c: 2
x1: -1,00000
x2: -2,00000
• Prueba 2 => Al ejecutar el programa debe mostrar lo siguiente:
Ingrese valor de a: 2
Ingrese valor de b: 8
Ingrese valor de c: 3
x1: -0,41886
x2: -3,58114 */

public class Challenge10
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
                Console.WriteLine("****** EJERCICIO DE ECUACIONES CUADRÁTICAS ******");
                Console.WriteLine();
                var a = ConsoleExtension.GetDouble("Ingrese valor de a: ");
                var b = ConsoleExtension.GetDouble("Ingrese valor de b: ");
                var c = ConsoleExtension.GetDouble("Ingrese valor de c: ");
                var solution = QuadraticEquation(a, b, c);
                Console.WriteLine();
                Console.WriteLine($">>> X1 = {solution.X1:N5} <<<");
                Console.WriteLine($">>> X2 = {solution.X2:N5} <<<");

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

    QuadraticEquationSolution QuadraticEquation(double a, double b, double c)
    {
        return new QuadraticEquationSolution
        {
            X1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a),
            X2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)
        };
    }

    public class QuadraticEquationSolution
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
    }
}