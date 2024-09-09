//Funcion que calcula el area de un triangulo
namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            double baseTriangulo;
            double alturaTriangulo;

            Console.WriteLine("Ingrese la base del rectangulo");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo");
            alturaTriangulo = double.Parse(Console.ReadLine());

            resultado = CalcularAreaTriangulo(baseTriangulo,alturaTriangulo);
            Console.WriteLine(resultado);
        }
        static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double area;

            area = (baseTriangulo * alturaTriangulo) / 2;

            return area;
        }
    }
}
