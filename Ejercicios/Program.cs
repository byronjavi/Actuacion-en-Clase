using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program n = new Program();
            int op = 0;

            while (true)
            {
                op = n.Menu();

                switch (op)
                {
                    case 1: n.generanumero(); break;
                    case 2: n.validarEdad(); break;
                    case 3: n.diaSemana(); break;
                    case 4: n.Calificacion(); break;
                    case 5: n.parOImpar(); break;
                    case 6: n.determinaElMayor(); break;
                   
                }
                Console.WriteLine("***************************************************************");
                if (op == 0) break;
            }
        }

        /////
        ///

        
            ///ejercici1 = realizar un menu de opciones 
            /// pasos que vamos a utilizar son :
            /// paso 1= generar el numer 
            /// paso 2= pedir que igrese un numero al usuario
            /// paso 3= guardar el numero por el usuario
            /// paso 4= conparat si el numero es = al numero del usuario 
            /// paso  5= si el numero es igual ahi queda 
            /// paso 6= comparar si el numero es mayor o menor que  el numero areatoriamente 
            /// paso 7= si es menor imprimir por consola debe ser un numero mayor 
            /// paso 8= sio el es mayor debe imprimir  un numero menor 
            /// pso 9= se repite del paso 4 hasta que que el usuario cumpla 
            /// </summary>
            /// 

        /*************************************************************************************/
        //Munu
        public int Menu()
        {
            string mensaje = "Por favor escojer una opción\n\n1.- Adivinar numero\n2.- Validar Edad\n3.- Día de la semana\n4.- Calcular Calificación\n" +
                "5.- Determine si un número es par o impar\n6.- Determinar el mayor\n0 .- Salir\n";
            Console.WriteLine(mensaje);
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        /******************************************************************************/
        /******  generanumero()                                                  ******/
        /******  Esta funcion le permite generar un numero aleatorio y compara   ******/
        /******  con el numero ingresado por el usuario.                         ******/
        /******************************************************************************/
       public void generanumero()
        {
            Random nuevo = new Random();
            int numero = nuevo.Next(1, 100);
           
            while(true)
            {
                Console.Write("ingrese un numero: ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 == numero)
                {
                    Console.WriteLine("Usted ha adivinado el numero: "+num1);
                    break;
                }
                else
                {
                    if (num1 > numero)
                        Console.WriteLine("El numero debe ser menor");
                    else
                        Console.WriteLine("El numeor debe ser mayor");
                } 
            }

            Console.WriteLine("\n\n");
        }

        /******************************************************************************/
        /******  validarEdad()                                                   ******/
        /******  Esta funcion le permite comprobar si el usuario puede sufragar  ******/
        /******  Si es mayor o igual a 16 años si puede sufragar.                ******/
        /******************************************************************************/

        public void validarEdad()
        {
            int edad = 0;
            Console.Write("Por favor ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("El usuario si puede sufragar");
            }
            else
            {
                Console.WriteLine("El usuario no puede sufragar");
            }

            Console.WriteLine("\n\n");
        }

        /******************************************************************************/
        /******  diaSemana()                                                     ******/
        /******  Esta funcion le permite comprobar si el usuario puede sufragar  ******/
        /******  Si es mayor o igual a 16 años si puede sufragar.                ******/
        /******************************************************************************/

        public void diaSemana()
        {
            int dia = 0;
            Console.Write("Por favor ingrese un número de 1 al 7: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Día lunes"); break;
                case 2: Console.WriteLine("Día Martes"); break;
                case 3: Console.WriteLine("Día Miercoles"); break;
                case 4: Console.WriteLine("Día Jueves"); break;
                case 5: Console.WriteLine("Día Viernes "); break;
                case 6: Console.WriteLine("Día Sabado"); break;
                case 7: Console.WriteLine("Día Domingo"); break;
            }

            Console.WriteLine("\n\n");
        }

        /******************************************************************************/
        /******  diaSemana()                                                     ******/
        /******  Esta funcion le permite comprobar si el usuario puede sufragar  ******/
        /******  Si es mayor o igual a 16 años si puede sufragar.                ******/
        /******************************************************************************/

        public void Calificacion()
        {
            int calificacion = 0;
            Console.WriteLine("Ingrese su calificación, un número del 1 al 100");
            calificacion = int.Parse(Console.ReadLine());

            switch (calificacion / 10)
            {
                case 10: Console.WriteLine("Su calificación es: A");break;
                case 9: Console.WriteLine("Su calificación es: A"); break;
                case 8: Console.WriteLine("Su calificación es: B"); break;
                case 7: Console.WriteLine("Su calificación es: C"); break;
                case 6: Console.WriteLine("Su calificación es: D"); break;
                default: Console.WriteLine("Su calificacion es: F");break;
            }

            Console.WriteLine("\n\n");
        }

        /******************************************************************************/
        /******  parOImpar()                                                     ******/
        /******  Esta funcion le permite comprobar si un número es par o impar   ******/
        /******************************************************************************/

        public void parOImpar()
        {
            int numero = 0;
            Console.Write("Por favor ingrese un numero entero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El número es PAR");
            else
                Console.WriteLine("El número es IMPAR");
        }

        /******************************************************************************/
        /******  determinaElMayor()                                              ******/
        /******  Esta funcion determina si un numero es mayor o menor que otro   ******/
        /******************************************************************************/

        public void determinaElMayor()
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Los números son iguales");
            else if (num1 > num2)
                Console.WriteLine("El número " + num1 + " es mayor que el número " + num2);
            else Console.WriteLine("El número " + num2 + " es mayor que el número " + num1);
        }
    }
}

