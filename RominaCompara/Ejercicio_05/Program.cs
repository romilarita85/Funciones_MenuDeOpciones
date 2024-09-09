//funcion para calcular el perimetro de un circulo
namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            double piCirculo;
            double radioCirculo;

            Console.WriteLine("Ingrese pi del circulo");
            piCirculo =double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el radio");
            radioCirculo = double.Parse(Console.ReadLine());

            resultado = CalcularPerimetroCirculo(piCirculo,radioCirculo);
            Console.WriteLine($"El perimetro de un circulo es: {resultado}");
        }
        static double CalcularPerimetroCirculo(double piCirculo, double radioCirculo) 
        {
            double perimetro;

            perimetro = 2 * piCirculo* radioCirculo;

            return perimetro;
        }
       
    }
}
