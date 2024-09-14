//Repaso:
namespace clase12_09
{
    internal class Program
    {
        static void Main(string[] args)
        {//variables propias del metodo main
            int edad;
            string nombre;
            nombre = PedirString("Ingrese su nombre");
            edad = PedirInt("Ingrese su edad");
            Console.WriteLine($"su nombre es {nombre} y tiene {edad} años");

        }
        /*
       1.Sumar dos numeros
       */
        public static int Sumar(int numeroUno, int numeroDos) // la cantidad de parametrso puede ser infinito 
        {//Mi funcion retorna un int
            int resultado;//creo una variable del mismo tipo (int)
            resultado = numeroUno + numeroDos;
            return resultado;
        }
        /*
        2.Pedir y retornar un numero
        */
        public static int PedirInt(string msj) //pide un tipo de dato y retorna un tipo de dato
        {
            int resultado;
            Console.Write(msj);
            resultado = int.Parse(Console.ReadLine());
            return resultado;
        }
        /// <summary>
        /// Recibe un string a modo de mensaje u retorna la lectura.
        /// </summary>
        /// <param name="msj">string para mostrar el pedido de una cadena</param>
        /// <returns>retorna la lectura de consola</returns>
        /*
        3.Pedir y retornar una cadena
        */
        public static string PedirString(string msj)//puedo usar para pedir cualquier cosa
        {
            string lectura;
            Console.Write(msj);
            lectura = Console.ReadLine();
            return lectura;
        }

        /*
       4.Pedir y retornar una cadena
       */

        /*
        5.Pedir y retornar una cadena
        */
    }
}
//1-Como solucion de un unico problema.Que quiero que haga la funcion
//2-Que va a retornar y que tipo de dato
//3-Saber si va a recibir parametros, cuanto y de que tipo.

//Prototipos de funcion:

//1)-No reciben parametros y no retornan nada.
//2)-No reciben parametros y si retornan un valor.
//3)-Reciben parametros y No retornan ningun valor.

//4)-Si reciben parametros y si retornan un valor. //----Las vamos a utilizar casi siempre 

//public => visibilidad
//static => comportamiento
//int => retorno.Tipo de dato que va a retornar
//Sumar => nombre de la funcion
//(int,int) => cantidad y tipo de parametrosparametros.
//__________________________________________________
//1.Sumar dos numeros
//namespace clase12_09
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {//variables propias del metodo main
//            int numeroUno = 8;
//            int numeroDos = 7;
//            int resultado;

//            resultado = Sumar(numeroUno, numeroDos); //la funcion espera recibir dos enteros(pueden ser hardcodeados,variables,lectura de parseo)
//            //resultado = Sumar(8, 7);
//            Console.WriteLine($"La suma entre {numeroUno} y {numeroDos} es igual a {resultado}");
//        }
//        /*
//       1.Sumar dos numeros
//       */
//        public static int Sumar(int numeroUno, int numeroDos) // la cantidad de parametrso puede ser infinito 
//        {//Mi funcion retorna un int
//            int resultado;//creo una variable del mismo tipo (int)
//            resultado = numeroUno + numeroDos;
//            return resultado;
//        }
//    }
//}
//--------------------------------------------------
//2.Pedir y retornar un numero
//namespace clase12_09
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {//variables propias del metodo main
//            int numeroUno;
//            int numeroDos;

//            numeroUno = PedirInt();
//            numeroDos = PedirInt();

//            int resultado;
//            resultado = Sumar(numeroUno, numeroDos); //la funcion espera recibir dos enteros(pueden ser hardcodeados,variables,lectura de parseo)
//            //resultado = Sumar(8, 7);
//            Console.WriteLine($"La suma entre {numeroUno} y {numeroDos} es igual a {resultado}");
//            _____________________________________________
              //int numeroUno;
             //int numeroDos;

             //numeroUno = PedirInt("Ingrese el primer valor: ");
             //numeroDos = PedirInt("Ingrese el segundo valor: ");

            //int resultado;
            //resultado = Sumar(numeroUno, numeroDos); 
            //resultado = Sumar(8, 7);
            //Console.WriteLine($"La suma entre {numeroUno} y {numeroDos} es igual a {resultado}");
//         ______________________________________________________________
//        }
//        /*
//       1.Sumar dos numeros
//       */
//        public static int Sumar(int numeroUno, int numeroDos) // la cantidad de parametrso puede ser infinito 
//        {//Mi funcion retorna un int
//            int resultado;//creo una variable del mismo tipo (int)
//            resultado = numeroUno + numeroDos;
//            return resultado;
//        }
//        /*
//        2.Pedir y retornar un numero
//        */
//        public static int PedirInt()
//        {
//            int resultado;
//            string lectura;
//            Console.Write("Ingrese un numero");
//            lectura = Console.ReadLine();
//            resultado = int.Parse(lectura);
//            return resultado;
//        }
//------------Forma simplificada de hacer la funcion------------- 
//        public static int PedirInt(string msj) //pide un tipo de dato y retorna un tipo de dato
//        {
//            int resultado;
//            Console.Write(msj);
//            resultado = int.Parse(Console.ReadLine());
//            return resultado;
//}
//        }
//}