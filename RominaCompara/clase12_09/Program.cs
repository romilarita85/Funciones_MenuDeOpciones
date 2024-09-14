//Repaso:
namespace clase12_09
{
    internal class Program
    {
        static void Main(string[] args)
        {//variables propias del metodo main
            int nota;
            string nombre;
            string situacion;
            //calcular aumento 50%
            double numeroConAumento = CalcularAumento(150,50);//precio 150 y aumento del 50%
           
            numeroConAumento = CalcularAumento(150, 50);
            //calcular el 10% de descuento.Sobre el valor de 150 el 10% de descuento
            numeroConAumento = CalcularDescuento(150, 10);
            while (8>0) 
            {
                nota = PedirInt("Ingrese un numero");
                switch (EvaluarPositividad(nota))
                {
                    case 0:
                        Console.WriteLine("El numero ingresado es cero");
                        break;
                    case 1:
                        Console.WriteLine("El numero ingresado es positivo");
                        break;
                    default:
                        Console.WriteLine("El numero ingresado es negativo");
                        break;
                }
                Console.ReadKey();//hace una pausa
            }
            
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
        /*
        3.Pedir y retornar una cadena
        */
        /// <summary>
        /// Recibe un string a modo de mensaje y retorna la lectura.
        /// </summary>
        /// <param name="msj">string para mostrar el pedido de una cadena</param>
        /// <returns>retorna la lectura de consola</returns>
        public static string PedirString(string msj)//puedo usar para pedir cualquier cosa
        {
            string lectura;
            Console.Write(msj);
            lectura = Console.ReadLine();
            return lectura;
        }

        /*
        4.Evaluar nota
        */
        /// <summary>
        /// Recibe un entero que debe estar en un rango entre 1 a 10 y evalua el estado de la nota
        /// </summary>
        /// <param name="nota">Valor de la nota, debe estar entre 1 y 10</param>
        /// <returns>
        /// vacio: si la nota no esta entre 1 y 10
        /// desaprobado = si la nota esta entre 1 y 3
        /// regularizado = si la nota esta entre 4 y 5
        /// promocionado = si la nota esta entre 6 y 10
        /// </returns>
        public static string EvaluarNota(int nota) 
        {//funcion que evalua el resultado de una nota
            string resultado = string.Empty;
            
            if (nota > 0 && nota < 11) 
            {
                if (nota > 5)
                {
                    resultado = "Promocionado"; //1
                }
                else 
                {
                    if (nota > 3)
                    {
                        resultado = "Regularizado";//2
                    }
                    else 
                    {
                        resultado = "Desaprobado"; //3
                    }
                }
            }
            return resultado;
        }
        /*
        5.Evaluar paridad
        */
        public static bool EsPar(int numero) //ej 6
        {
            bool par = false; //no es par
            if (numero % 2 == 0) //para evaluar paridad-si el resto queda en cero quiere decir q se pudo dividir por 2 y es par
            {
                par = true;
            }
            return par;
        }

        /*
        6.Evaluar positividad
        */
        /// <summary>
        /// Recibe un numero e informa si es positivo, negativo o cero
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>
        /// 1: si es positivo.
        /// 0: si es cero.
        /// -1: si es negativo.
        /// </returns>
        public static int EvaluarPositividad(int numero) //ej 6
        {
            int positividad = 0;
            if (numero > 0)//positivo
            {
                positividad = 1; 
            }
            else //sino es negativo
            {
                if (numero < 0) 
                { 
                    positividad = -1;
                }
            }
            return positividad;
        }

        /*
        7.Calcular porcentaje: funcion para calcular porcentaje
        */
        public static double CalcularPorcentaje(int valor, int porcentaje) 
        {//recibimos el valor o monto(valor) y el numero del porcentaje(porcentaje).
            double resultado;
            resultado = 0; //Calculo del porcentaje
            return resultado;
        }
        /*
        8.Calcular aumento
        */
        public static double CalcularAumento(int valor, int porcentaje)
        {//recibimos el valor al que le vamos a sumar el aumento (monto) y el porcentaje
            double resultado;
            resultado = valor + CalcularPorcentaje(valor, porcentaje);
            return resultado;
        }
        /*
        9.Calcular descuento
        */
        public static double CalcularDescuento(int valor, int porcentaje) 
        {
            double resultado;
            resultado = valor - CalcularPorcentaje(valor, porcentaje);
            return resultado;
        }
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
//---------------------------------------------------------------
// /*
//4.Evaluar nota
//*/
//        //entrada = nombre y nota
//        //proceso = evaluar la condicion frente al examen 
//        //salidas = regularizado,desaprobado y promocionado
//        public static string EvaluarNota(int nota)
//{
//    string resultado = string.Empty;
//    if (nota <= 3 && nota > 0)
//    {
//        resultado = "Desaprobado";
//    }
//    else
//    {
//        if (nota >= 4 && nota <= 5)
//        {
//            resultado = "Regularizado";
//        }
//        else
//        {
//            if (nota >= 5 && nota <= 10)
//            {
//                resultado = "Promocionado";
//            }
//        }
//    }
//    return resultado;
//}
//---------------------------------------------------
/*
        4.Evaluar nota-Otra forma de hacerlo
        */
//entrada = nombre y nota
//proceso = evaluar la condicion frente al examen 
//salidas = regularizado,desaprobado y promocionado
//public static string EvaluarNota(int nota)
//{
//    string resultado = string.Empty;

//    if (nota > 5)
//    {
//        resultado = "Promocionado";
//    }
//    else
//    {
//        if (nota > 3)
//        {
//            resultado = "Regularizado";
//        }
//        else
//        {
//            resultado = "Desaprobado";
//        }

//    }

//    return resultado;
//}
//---------------------------------
/*
       4.Evaluar nota
       */
//entrada = nombre y nota
//proceso = evaluar la condicion frente al examen 
//salidas = regularizado,desaprobado y promocionado

//public static string EvaluarNota(int nota)
//{//funcion que evalua el resultado de una nota
//    string resultado = "Desaprobado";//por defecto esta desáprobado
//                                     //salvo que sea mayor a 5 o mayor a 3
//    if (nota > 5)
//    {
//        resultado = "Promocionado";
//    }
//    else if (nota > 3)
//    {
//        resultado = "Regularizado";
//    }
//    return resultado;
//}
///--------------------------
//  static void Main(string[] args)
//{//variables propias del metodo main
//    int nota;
//    string nombre;
//    string situacion;

//    nombre = PedirString("Ingrese su nombre: ");
//    nota = PedirInt("Ingrese su nota: ");
//    situacion = EvaluarNota(nota);

//    Console.WriteLine($"Su nombre es {nombre}, su nota es de {nota} y su situacion es: {situacion}");
//}
//-----------------------------------------------------------------------------------------------------
////public static string EvaluarNota(int nota) 
//{//funcion que evalua el resultado de una nota
//    string resultado = string.Empty;
//    if (nota > 0 && nota < 11)
//    {
//        if (nota > 5)
//        {
//            resultado = "Promocionado";
//        }
//        else
//        {
//            if (nota > 3)
//            {
//                resultado = "Regularizado";
//            }
//            else
//            {
//                resultado = "Desaprobado";
//            }
//        }
//    }
//    return resultado;
//}
//-------------------------------
//static void Main(string[] args)
//{//variables propias del metodo main
//    int nota;
//    string nombre;
//    string situacion;
//    while (true)
//    {
//        nombre = PedirString("Ingrese su nombre: ");
//        nota = PedirInt("Ingrese su nota: ");
//        situacion = EvaluarNota(nota);

//        Console.WriteLine($"Su nombre es {nombre}, su nota es de {nota} y su situacion es: {situacion}");
//        Console.ReadKey();//hace una pausa
//    }
//}
//---------------------------------------------Main--------
//static void Main(string[] args)
//{//variables propias del metodo main
//    int nota;
//    string nombre;
//    string situacion;
//    while (true)
//    {
//        nota = PedirInt("Ingrese un numero");
//        switch (EvaluarPositividad(nota))
//        {
//            case 0:
//                Console.WriteLine("El numero ingresado es cero");
//                break;
//            case 1:
//                Console.WriteLine("El numero ingresado es positivo");
//                break;
//            default:
//                Console.WriteLine("El numero ingresado es negativo");
//                break;
//        }
//        Console.ReadKey();//hace una pausa
//    }

//}
//-------Funcion---------------------
//public static int EvaluarPositividad(int numero) //ej 6
//{
//    int positividad = 0;
//    if (numero > 0)//positivo
//    {
//        positividad = 1;
//    }
//    else //sino es negativo
//    {
//        if (numero < 0)
//        {
//            positividad = -1;
//        }
//    }
//    return positividad;
//}