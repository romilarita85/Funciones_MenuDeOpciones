//Funcion que calcule el perimetro de un rectangulo
namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRectangulo;
            double alturaRectangulo;
            double resultado;

            Console.WriteLine("Ingrese la base de un rectangulo");
            baseRectangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura de un rectangulo");
            alturaRectangulo = double.Parse(Console.ReadLine());

            resultado = CalcularPerimetroRectangulo(baseRectangulo,alturaRectangulo);
            
            Console.WriteLine($"El perimetro del rectangulo es:{resultado}");

        }
        static double CalcularPerimetroRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double perimetro;

            perimetro = 2 * (baseRectangulo + alturaRectangulo);

            return perimetro;

        }
    }
}
