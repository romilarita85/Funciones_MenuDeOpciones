namespace Funciones
{
    internal class Program
    {
        //Minimizacion
        //Depuracion y modificacion
        //Reutilizacion
        //Independencia
        
        //Funcion que no tiene retorno y que no recibe parametros
        static void Sumar1() //declaracion e implementacion de la funcion
        {
            int unNumero;
            int otroNumero;
            int suma;
            //Minimizacion = No
            //Depuracion y modificacion = +- (masomenos)
            //Reutilizacion = NO
            //Independencia = NO (la funcion pide los numeros- altamente cohesiva)
            Console.WriteLine("Ingrese un numero");
            unNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            otroNumero = int.Parse(Console.ReadLine());

            suma = unNumero + otroNumero;

            Console.WriteLine($"El resultado de la suma es:{suma}");

        }

        //Funcion que tiene retorno y recibe parametros
        static void Sumar2(int unNumero, int otroNumero) //declaracion e implementacion de la funcion
        {
            int suma;
            suma = unNumero + otroNumero;
            //si no puedo devolver nada-lo muestro
            Console.WriteLine($"El resultado de la suma es:{suma}");

            //Minimizacion = +-
            //Depuracion y modificacion = +-(acotada al modulo)
            //Reutilizacion = +-
            //Independencia = +-
        } 
        //Funcion que tiene retorno pero no recibe parametros
        static int Sumar3() // va a tener un retorno pero no recibe parametros
        {
            int unNumero;
            int otroNumero;
            int suma;
            //Minimizacion = +-
            //Depuracion y modificacion = +- 
            //Reutilizacion = +-
            //Independencia = +-
            Console.WriteLine("Ingrese un numero");
            unNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            otroNumero = int.Parse(Console.ReadLine());

            suma = unNumero + otroNumero;
            
            return suma; //retorno-
        }
        static void Main(string[] args)
        {//Primero se ejecuta el main
         //Se van ejecutando las funciones q llamo o invoco implicitamente

            //Console.WriteLine("Inicio del programa");
            //Sumar1();//instancia donde la funcion se usa e invoca
            //Console.WriteLine("Fin del programa");
            //--------------------------------------------------------------------
            //int unNumero;
            //int otroNumero;
            //int suma;

            //Console.WriteLine("Ingrese un numero");
            //unNumero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese otro numero");
            //otroNumero = int.Parse(Console.ReadLine());
            ////llamo dos veces a la funcion-Reutilizacion de codigo
            //Sumar2(unNumero,otroNumero); 
            //Sumar2(5,7);//hardcodeo numeros
            //-----------------------------------------------------------------------
            //Una funcion retorna necesito q la funcion tenga una variable que
            //tiene q ser del mismo tipo q retorna la funcion (variable resultado)
            //int resultado;
            //resultado = Sumar3();
            //Console.WriteLine(resultado);

            //-----------------------------------------------------------------------
            //int unNumero;
            //int otroNumero;
            //int suma;

            //Console.WriteLine("Ingrese un numero");
            //unNumero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese otro numero");
            //otroNumero = int.Parse(Console.ReadLine());
            //suma = Sumar4(unNumero,otroNumero);
            //Console.WriteLine(suma);
            //=================
            int suma;
            suma = Sumar4(4, 7);
            Console.WriteLine(suma);
            //-------------------------------------------------------------------------
           
        }
        //Funcion que tiene retorno y recibe parametros
        static int Sumar4(int unNumero, int otroNumero) 
        { 
            int resultado;

            resultado = unNumero + otroNumero;//resultado +=otroNumero;

            return resultado;//Un solo return por funcion
                             
            //Minimizacion = SI
                             
            //Depuracion y modificacion = SI
                             
            //Reutilizacion = SI
                             
            //Independencia = SI
        }
        //Crear una funcion que reciba como parametro la base y la altura de un rectangulo.
        //La funcion tendra que calcular y devolver el area de la figura.
        static int CalcularAreaRectangulo(int baseR, int alturaR) 
        {
            int area;
            
            area = baseR * alturaR;
            
            return area;
        }

    }
}
