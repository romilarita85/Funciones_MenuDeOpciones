//Funcion que calcula el area de un rectangulo
namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double resultado;
            //resultado = CalcularAreaRectangulo(10,7);
            //Console.WriteLine(resultado);   
            double resultado;
            double baseRectangulo;
            double alturaRectangulo;

            Console.WriteLine("Ingrese la base del rectangulo");
            baseRectangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            alturaRectangulo = double.Parse(Console.ReadLine());
            //Console.WriteLine(CalcularAreaRectangulo);
            resultado = CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
            Console.WriteLine(resultado);
        }

        static double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double area;

            area = baseRectangulo * alturaRectangulo;

            return area;
        }

    }
}
