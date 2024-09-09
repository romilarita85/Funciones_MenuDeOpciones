using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_MenuDeOpciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ofrecer las operaciones basicas +-*/
            //repetir hasta que el usuario quiera
            //por lo menos dos numeros
            int numeroUno = int.MinValue;//numero min q puede cargar un entero
            int numeroDos = int.MinValue;
            string seguir = "si";//variable de control
            int opcion;
            string operacion = string.Empty;
            double resultado = double.NaN;

            while (seguir.ToLower() == "si") 
            {
                opcion = RetornaOpcionDelMenu();

                switch (opcion)//ToUpper: convierte lo q le pase por parentesis a mayuscula
                {
                    case 1:
                        //ingresar primer numero
                        numeroUno = PedirNumero("Ingrese el primer numero");
                        break;
                    case 2:
                        //ingresar segundo numero
                        numeroDos = PedirNumero("Ingrese el segundo numero");
                        break;
                    case 3:
                        //elegir operacion
                        Console.WriteLine("Elija la operacion:+suma -resta *multiplicar /dividir ");
                        operacion = Console.ReadLine();
                        break;
                    case 4:
                        
                        if (numeroUno != int.MinValue && numeroDos != int.MinValue && !string.IsNullOrEmpty(operacion)) //para saber si sus valores cambiaron y si operacion esta no esta vacio o nulo
                        {   //realizar la operacion 
                            switch (operacion)//ToUpper: convierte lo q le pase por parentesis a mayuscula
                            {
                                 case "+":
                                     resultado = numeroUno + numeroDos;
                                     break;
                                 case "-":
                                     resultado = numeroUno - numeroDos;
                                     break;
                                 case "*":
                                     resultado = numeroUno * numeroDos;
                                     break;
                                 case "/":
                                     resultado = numeroUno / numeroDos;
                                     break;
                            }
                            Console.WriteLine("Calculos realizados");
                        }
                        else 
                        {
                            Console.WriteLine("Para realizar la operacion debe asignar un valor a numero 1, numero 2 y elegir la operacion");  
                        }
                        break;
                    case 5:
                        //mostrar resultado
                        Console.WriteLine($"El resultado de {numeroUno} {operacion} {numeroDos} es {resultado}");
                        operacion = string.Empty;
                        numeroUno = int.MinValue;
                        numeroDos = int.MinValue;
                        break;
                    case 6:
                        //salir
                         seguir = "no";
                        break;
                    default:
                        //opcion incorrecta
                        Console.WriteLine("La opcion ingresada no es valida");
                       break;
                }
            }
        }
        static void MostrarMenu() //funcion para mostrar
        {
            Console.WriteLine("\t\t\a **** Menu Calculadora ****");
            Console.WriteLine("1.Ingresar el primer operando");
            Console.WriteLine("2.Ingresar el segundo operando");
            Console.WriteLine("3.Elegir la operacion matematica");
            Console.WriteLine("4.Calcular la operacion");
            Console.WriteLine("5.Mostrar resultado");
            Console.WriteLine("6.Salir");
            Console.Write("Elija una opcion: ");
        }
        static int RetornaOpcionDelMenu() //retorna las opciones
        {
            int resultado;
            MostrarMenu();
            resultado = int.Parse(Console.ReadLine());
            
            return resultado;
        }
        static int PedirNumero(string mensaje) //pido por parametro
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }
    }
}
