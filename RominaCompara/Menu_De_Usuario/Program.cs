namespace Menu_De_Usuario
{
    internal class Program
    {
        public static void Main(string[] args)
        {//seleccion de opciones

            //Ingresar nombre
            //Ingresar el turno
            //Que tipo de saludo quiere
            //Preguntar si quiere que le sigamos saludando-si para seguir/no para cancelar

            int seleccion = -1;
            string nombre = string.Empty;
            string turno = string.Empty;
            bool seguir = true;

            while (seguir == true)
            {
                Console.WriteLine("1.Para ingresar su nombre");
                Console.WriteLine("2.Para ingresar el turno");
                Console.WriteLine("3.Para seleccionar el tipo de saludo");
                Console.WriteLine("4.Salir del programa");
                Console.Write("Ingrese su opcion: ");

                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)//ToUpper: convierte lo q le pase por parentesis a mayuscula
                {
                    case 1:
                        Console.WriteLine("Ingrese su nombre");
                        nombre = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("En que turno esta: M:mañana, T: tarde, N:noche: ");
                        turno = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("1.Saludo inicial");
                        Console.WriteLine("2.Saludo de despedida");
                        //Validacion:
                        if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(turno))
                        {//niego si esto es nulo o vacio para que tenga un valor
                            if (int.Parse(Console.ReadLine()) == 1)
                            {
                                Console.WriteLine(Saludar(nombre, turno));
                            }
                            else
                            {
                                Console.WriteLine(Despedirse(nombre));
                            }
                        }
                        else 
                        {
                            if (string.IsNullOrEmpty(nombre)) // nulo o vacio
                            {
                                Console.WriteLine("Para poder elegir el saludo falta ingresar el nombre");
                            }
                            else 
                            { 
                                Console.WriteLine("Para poder elegir el saludo falta ingresar el turno");
                            }
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Saliendo de la app.....");
                        seguir = false;
                        break;
                }
                Console.WriteLine("Precione una tecla para continuar.......");
                Console.ReadKey();//precione una tecla cualquiera
                Console.Clear();//limpia

            }
        }
       
        //DOCUMENTACION DE LA FUNCION
        //SUMARY:Breve descripcion de lo que hace la funcion
        //PARAM:parametros, q tipos de datos deberian suministrar
        //RETURNS:si tiene retorno

        /// <summary>
        /// Funcion que recibe un string a modo de nombre y un char para indicar 
        /// el horario y retorna un saludo
        /// </summary>
        /// <param name="nombre">String con el nombre para saludar</param>
        /// <param name="turno">M: para el turno mañana, T: para el turno tarde, N: para el turno noche</param>
        /// <returns>Retorna un string con el nombre y el turno correspondiente</returns>

        private static string Saludar(string nombre, string turno)
        {
            string saludo = string.Empty;//inicializa la variable del tipo string sin ningun valor

            switch (turno.ToUpper())//ToUpper: convierte lo q le pase por parentesis a mayuscula
            {
                case "M":
                    saludo = $"Buen dia {nombre}";
                    break;
                case "N":
                    saludo = $"Buenas noches {nombre}";

                    break;
                case "T":
                    saludo = $"Buenas tardes {nombre}";
                    break;
                default:
                    break;
            }
            return saludo;
        }
        public static string Despedirse(string nombre)
        {
            return $"Adios {nombre}";
        }
    }
}
// while (seguir == true) 
// {
//     Console.WriteLine("1.Para ingresar su nombre");
//     Console.WriteLine("2.Para ingresar el turno");
//     Console.WriteLine("3.Para seleccionar el tipo de saludo");
//     Console.WriteLine("4.Salir del programa");
//     Console.WriteLine("Desea seguir siendo saludado:Si para seguir");
//     if (Console.ReadLine().ToLower() == "si") // hago la lectura y me fijo si es igual a "si"
//     {//con ToLower estandarizamos a minuscula
//         seguir = true;//sigue el bucle repetitivo

//     }
//     else
//    {
//         seguir = false;
//    }
// } 
//-------------------------------------------------------------------------------
//
//    Console.Write("Ingrese su nombre");
//    nombre = Console.ReadLine();    

//    Console.WriteLine("Que tipo de saludo quiere?");
//    Console.WriteLine("1.Saludo inicial");
//    Console.WriteLine("2.Saludo despedida");

//    seleccion = int.Parse(Console.ReadLine());

//    if (seleccion == 1)
//    {
//        Console.WriteLine("En que turno esta: M:mañana, T: tarde, N:noche: ");
//        turno = Console.ReadLine()[0];
//        Console.WriteLine(Saludar(nombre,turno));
//    }
//    else 
//    {
//        Console.WriteLine(Despedirse("Jose"));
//    }     

//}