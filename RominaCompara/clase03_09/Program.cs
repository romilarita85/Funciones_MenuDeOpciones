//FUNCIONES
//Crear una funcion que reciba como parametro la base y la altura de un rectangulo.
//La funcion tendra que calcular y devolver el area de la figura.
namespace clase03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double resultado;
            //resultado = CalcularAreaRectangulo(10,7);
            //Console.WriteLine(Resultado);
            //-----------------------------------
            int baseRectangulo;
            int alturaRectangulo;
            Console.WriteLine("ingrese la base del rectangulo");
            baseRectangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura del rectangulo");
            alturaRectangulo = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcularAreaRectangulo);

           
        }
        static int CalcularAreaRectangulo(int baseRectangulo, int alturaRectangulo)
        {
            int area;

            area = baseRectangulo * alturaRectangulo;

            return area;
        }
    }
}
