//Funcion para calcular el perimetro de un triangulo
namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipoTriangulo;
            double resultado1;
            double resultado2;
            double resultado3;
            double lado;
            double baseTriangulo;

            Console.WriteLine("Ingrese el tipo del triangulo");
            tipoTriangulo = Console.ReadLine();
            
            if (tipoTriangulo == "equilatero")
            {
                Console.WriteLine("Ingrese valor del lado");
                lado = double.Parse(Console.ReadLine());
            }
            else 
            {
                if (tipoTriangulo == "isosceles") 
                {
                    Console.WriteLine("Ingrese valor del lado");
                    lado = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la base del triangulo");
                    lado = double.Parse(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine("Ingrese valor del lado");
                    lado = double.Parse(Console.ReadLine());

                }
            }
            resultado1 = CalcularPerimetroTrianguloEquilatero(lado);
            Console.WriteLine($"El perimetro del triangulo es: {resultado1}");
            
            resultado2 = CalcularPerimetroTrianguloIsosceles(lado,baseTriangulo);
            Console.WriteLine($"El perimetro del triangulo es: {resultado2}");
            
            resultado3 = CalcularPerimetroTrianguloEscaleno(lado);
            Console.WriteLine($"El perimetro del triangulo es: {resultado3}");
        }
        static double CalcularPerimetroTrianguloEquilatero(double lado) 
        {
            double perimetro;
            perimetro = lado * 3;

            return perimetro;   
        }
        static double CalcularPerimetroTrianguloIsosceles(double lado,double baseTriangulo)
        {
            double perimetro;

            perimetro = lado * 2 + baseTriangulo;

            return perimetro;

        }
        static double CalcularPerimetroTrianguloEscaleno(double lado)
        {
            double perimetro;
            perimetro = lado + lado + lado;

            return perimetro;
        }
    }
}
