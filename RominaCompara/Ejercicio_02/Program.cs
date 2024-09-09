//Funcion que calcula el area de un circulo
namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            double piCirculo;
            double radioCirculo;

            Console.WriteLine("Ingrese pi");
            piCirculo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese radio del circulo");
            radioCirculo = int.Parse(Console.ReadLine());

            resultado = CalcularAreaCirculo(piCirculo, radioCirculo);
            Console.WriteLine(resultado);
        }
        static double CalcularAreaCirculo(double piCirculo, double radioCirculo)
        {
            double areaDeCirculo;

            areaDeCirculo = piCirculo * (radioCirculo * radioCirculo);
            return areaDeCirculo;
        }
    }
}
