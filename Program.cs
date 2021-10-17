using System;

namespace JESUS.MENDOZA.CUENCA._3A_
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1.
            int num1, num2;
            Console.WriteLine("Programa que lee dos numero y da el numero mayor ");
            Console.WriteLine("escribir el primer numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escribir el segundo numero ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("El numero mayor es: {0}", num1);

            }
            else
            {
                Console.WriteLine("El numero mayor es {0}", num2);
            }
            Console.WriteLine();
            Console.ReadKey();


            //EJERCICIO 2.
            int vari;
            Console.WriteLine("Programa que dice si un numero es impar o par.");
            
            Console.Write("Diguite un numero: ");
            vari = int.Parse(Console.ReadLine());
            if ((vari % 2) == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
            Console.WriteLine("");


            //EJERCICIO 3.
            int num, lum1, lum2;
            Console.WriteLine("Diguite 3 numeros y tendra de respuesta el numero mayor ");
            Console.WriteLine("Escriba el primer nuemro: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo nuemro: ");
            lum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el tercer nuemro: ");
            lum2 = int.Parse(Console.ReadLine());
            if (num > lum1 && num > lum2)
            {
                Console.WriteLine("El numero mayor es: {0}", num);
            }

            if (lum1 > num && lum1 > lum2)
            {
                Console.WriteLine("El numero mayor es: {0}", lum1);
            }

            if (lum2 > lum1 && lum2 > num)
            {
                Console.WriteLine("El numero mayor es: {0}", lum2);
            }

            Console.ReadKey();
            Console.WriteLine("");


            //EJERCICIO 4.
            decimal mun;
            Console.WriteLine("Diguite un numero decimal.");
            Console.Write("escribir un numero: ");
            mun = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.ReadKey();


            //EJERCICIO 5.
            int conta = 1, acumu = 0, con;
            Console.WriteLine("Programa que lee 5 numeros y da la sumatoria total.");
            while (conta <= 5)
            {
                conta++;
                Console.WriteLine("Escriba un numero:  ");
                con = int.Parse(Console.ReadLine());
                acumu = con + acumu;
            }

            Console.WriteLine("la suma total es: {0}", acumu);
            Console.ReadKey();
            Console.WriteLine("");


            //EJERCICIO 6.
            int onta = 1, acumula = 0, cont, numero;
            Console.WriteLine("Programa que puede poner cuantas veces desea sumar y da la sumatoria total. ");
            Console.WriteLine("Escribir cuantas veces desea sumar: ");
            numero = int.Parse(Console.ReadLine());

            while (onta <= numero)
            {
                onta++;
                Console.WriteLine("Escriba un numero:  ");
                cont = int.Parse(Console.ReadLine());
                acumula = cont + acumula;
            }

            Console.WriteLine("la suma total es: {0}", acumula);
            Console.ReadKey();
            Console.WriteLine("");


            //EJERCICIO 8.
            int contaa = 0;

            Console.WriteLine("Programa que te va a dar la tabla de multiplicar hasta el 1000.");
            Console.WriteLine(" Tabla de multiplos del 7, del 1 hasta el 1000 ");


            while (contaa <= 1000)
            {
                contaa = contaa + 7;

                Console.WriteLine("{0}", contaa);
            }
            Console.ReadKey();
            Console.WriteLine("");

            //EJERCICIO 10.
            int numm;
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                numm = int.Parse(Console.ReadLine());
                verificar(numm);
            } while (numm < 0);
            factorial(numm);
            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("\nError: No existe el factorial de un número negativo...\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);

        }
    }
}
