//REPASO FUNCIONES - EJERCICIO 6
using clase17_09;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace clase17_09
{
    //usando enumerado
    public enum Signo 
    { 
        Positivo,
        Negativo,
        Cero
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i; // contador , variable de control para saber la cantidad de iteraciones
            int acumuladorNegativos;
            int acumuladorPositivos;
            int cantidadPositivos;
            int cantidadNegativos;
            int cantidadCeros;
            int cantidadPares;
            float promedioPositivos;//No se inicializan los promedio no son contadores ni acumuladores
            float promedioNegativos;
            int diferencia;
            int cantidadImparesPositivos;
            int maximo;//Creo variable
            int minimoNegativo;//declaro minimo
            i = 0;
            acumuladorNegativos = 0;
            acumuladorPositivos = 0;
            cantidadNegativos = 0;
            cantidadPositivos = 0;
            cantidadCeros = 0;
            cantidadPares = 0;
            maximo = 0;
            minimoNegativo = 0;//inicializo en cero solo para darle valor inicial
            cantidadImparesPositivos = 0;
            do 
            {
                numero = PedirNumero("Ingrese un numero: ");
                Signo signo = VerificarSignoE(numero);
                switch (signo)
                {
                    case Signo.Cero:
                        cantidadCeros++; //cantidadCeros = cantidaCeros + 1
                        break;
                    case Signo.Positivo:
                        cantidadPositivos++;
                        acumuladorPositivos += numero;//acumulador = acumulador + numero;
                        if (VerificarParidad(numero) == false) // para sacar impares
                        {
                            cantidadImparesPositivos++;
                        }
                         break;
                    case Signo.Negativo:
                        acumuladorNegativos += numero;
                        cantidadNegativos++;
                        if (cantidadNegativos == 1 || numero < minimoNegativo) 
                        {// el primer numero q ingreso es el minimo 
                            minimoNegativo = numero;
                        }
                        break;
                }
                if (VerificarParidad(numero) == true) //me interesa q sea true
                { //tengo el universo de los pares
                    cantidadPares++;
                }
                if (i == 0 || numero > maximo) 
                {
                    maximo = numero;
                }

                i++;// i = i + 1;

            }while (i<5);

            Console.WriteLine($"1.La suma de los negativos es: {acumuladorNegativos}");
            Console.WriteLine($"2.La suma de los positivos es: {acumuladorPositivos}");
            Console.WriteLine($"3.La cantidad de los positivos es: {cantidadPositivos}");
            Console.WriteLine($"4.La cantidad de los negativos es: {cantidadNegativos}");
            Console.WriteLine($"5.La cantidad de ceros es: {cantidadCeros}");
            Console.WriteLine($"6.La cantidad de numeros pares es: {cantidadPares}");
           
            if (cantidadPositivos > 0)//si la cantidad de positivos es mayor a cero significa q por lo menos un positivo ingres0
            {
                promedioPositivos = CalcularPromedio(acumuladorPositivos, cantidadPositivos);
                Console.WriteLine($"7.El promedio de los positivos es: {promedioPositivos}");
            }
            else 
            {
                Console.WriteLine("7.No se ingresaron numeros positivos para calcular el promedio.");
            }
            
            if (cantidadNegativos > 0)
            {
                promedioNegativos = CalcularPromedio(acumuladorNegativos, cantidadNegativos);
                Console.WriteLine($"8.El promedio de los negativos es: {promedioNegativos}");
            }
            else 
            {
                Console.WriteLine("8.No se ingresaron numeros negativos para calcular el promedio.");
            }

            diferencia = CalcularDiferencia(cantidadPositivos,cantidadNegativos);
            //diferencia = CalcularDiferencia(acumuldorPositivos, acumuladorNegativos);
            Console.WriteLine($"9.La diferencia entre los positivos y negativos: {diferencia}");
           
            Console.WriteLine($"10.El numero maximo: {maximo}");
            
            if (cantidadNegativos > 0) // si contador negativo es mayor a cero -encontre el minimo
            {
                Console.WriteLine($"11.El minimo negativo es : {minimoNegativo}");
            }
            else 
            {
                Console.WriteLine("11.No se encontraron negativos para encontrar el minimo");
            }
            
            Console.WriteLine($"12.La cantidad de numeros impares de los positivos: {cantidadImparesPositivos}");
            
        }

        //Funcion que va a evaluar positividad(si numero es positivo neg o cero)
        //la funcion recibe un entero(representa el parametro de entrada o numero q quiero evaluar)
        //y devuelve(si es negativo y positivo)
        static int VerificarSignoI(int numero) //USANDO INT
        {
            int esPositivo = 0; // por default el numero es cero
            if (numero > 0)
            {
                esPositivo = 1;//si es positivo devuelve un numero positivo
            }
            else 
            {
                if (numero < 0) 
                {
                    esPositivo = -1;//si es negativo devuelve un numero negativo
                }
                //el else nova ya q le dimos valor a cero por default "esPositivo = 0"
            }
            return esPositivo;
        }
        static string VerificarSignoS(int numero) //USANDO STRING
        {
            string esPositivo = "cero"; // por default el numero es cero
            if (numero > 0)
            {
                esPositivo = "si";
            }
            else
            {
                if (numero < 0)
                {
                    esPositivo = "no";
                }
            }
            return esPositivo;
        }
        static Signo VerificarSignoE(int numero) //USANDO ENUMERADOS
        {
            Signo esPositivo = Signo.Cero; // por default el numero es cero
            if (numero > 0)
            {
                esPositivo = Signo.Positivo;
            }
            else
            {
                if (numero < 0)
                {
                    esPositivo = Signo.Negativo;
                }
            }
            return esPositivo;
        }
        /// <summary>
        /// Determina la paridad de un numero
        /// </summary>
        /// <param name="numero">Recibe un numero</param>
        /// <returns>True si es par - False si es impar</returns>
        static bool VerificarParidad(int numero) //Funcion para verificar si es par o impar 
        {
            bool esPar = false;
            if (numero != 0 && numero % 2 == 0)
            {
                esPar = true;
            }
            return esPar;
        }
        //Funcion para pedir numero
        static int PedirNumero(string msj) 
        {
            int numero; //numero leido o ingresado
            Console.WriteLine(msj);
            numero = int.Parse(Console.ReadLine());
            return numero;//retorna numero(devuelve)
        }
        //Funcion para calcular un promedio
        static float CalcularPromedio(int acumulador, int contador) 
        {
            float resultado;
            resultado = (float)acumulador / contador; // castear (a float) para que no haya perdida de informacion
            //un entero sobre un entero por ende se debe convertir en flotante
            return resultado;
        }
        //funcion para calcular diferencia
        static int CalcularDiferencia(int unNumero, int otroNumero) 
        {
            int resultado;
            resultado = unNumero - otroNumero;
            return resultado;
        }
    }
}


//Signo resultado = VerificarSignoE(0);
////Signo signo = VerificarSignoE(numero);// otra forma
//switch(resultado)
//{ 
//    case Signo.Negativo:
//        Console.WriteLine("Es negativo");  
//        break;
//    case Signo.Cero:
//        Console.WriteLine("Es cero");
//        break;
//    case Signo.Positivo:
//        Console.WriteLine("Es positivo");
//        break;
//}

//switch (VerificarSignoE(numero))
//{
//    case Signo.Cero:

//        break;
//    case Signo.Positivo:

//        break;
//    default:
//        break;
//}


