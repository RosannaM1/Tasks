using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPractica
{
    public static class ProyectoFinal
    {
        public static void FinalProject()
        {

            //Proyecto final

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Selecciona una opcion");
                Console.WriteLine("1- Calculadora\n2-Tabla de multiplicar\n3- seleccionar numero mas pequeño\n4- Piramide\n5- Cerrar App");
                string menuopcion = Console.ReadLine();
                int menuoption = int.Parse(menuopcion);

                switch (menuoption)
                {
                    case 1:
                        while (true)
                        {
                            //Calculadora
                            Console.WriteLine("Selecciona una opcion");
                            Console.WriteLine("1.Sumar\r\n2.Restar\r\n3.Multiplicar\r\n4.Dividir\r\n5.Salir");

                            string opcion = Console.ReadLine();
                            int option = int.Parse(opcion);

                            if (option == 5) break;

                            Console.WriteLine("Ingresa el primer numero");
                            string val1 = Console.ReadLine();
                            int num1 = int.Parse(val1);

                            Console.WriteLine("Ingresa el segundo numero");
                            string val2 = Console.ReadLine();
                            int num2 = int.Parse(val2);

                            int total = 0;

                            switch (option)
                            {

                                case 1:
                                    total = num1 + num2;
                                    Console.WriteLine("El total es:" + total);
                                    break;

                                case 2:
                                    total = num1 - num2;
                                    Console.WriteLine("El total es:" + total);
                                    break;

                                case 3:
                                    total = num1 * num2;
                                    Console.WriteLine("El total es:" + total);
                                    break;

                                case 4:
                                    total = num1 / num2;
                                    Console.WriteLine("El total es:" + total);

                                    break;

                                case 5:
                                    Environment.Exit(0);
                                    break;


                                default:
                                    Console.WriteLine("La opcion que ingresaste no esta en el menu");
                                    break;
                            }

                        }

                        break;

                    case 2:

                        //tabla de multiplicar
                        Console.WriteLine("Ingresa el primer numero");
                        string val01 = Console.ReadLine();
                        int num01 = int.Parse(val01);

                        Console.WriteLine("Ingresa el segundo numero");
                        string val02 = Console.ReadLine();
                        int num02 = int.Parse(val02);

                        for (int i = 1; i <= num01; i++)
                        {
                            for (int j = 1; j <= num02; j++)
                            {
                                Console.WriteLine($"{i} x {j} = {i * j}");
                            }

                        }

                        string salir = Console.ReadLine();

                        // Verificar si la entrada está vacía (presionó Enter)
                        if (string.IsNullOrWhiteSpace(salir)) break;
                        break;


                    case 3:
                        //seleccionar mas pequeño

                        Console.WriteLine("Ingresa un valor para el arreglo");
                        string val001 = Console.ReadLine();
                        int num001 = int.Parse(val001);

                        int[] numeros = new int[num001];

                        for (int a = 0; a < numeros.Length; a++)
                        {
                            Console.WriteLine("Ingresa un numero");
                            string input = Console.ReadLine();
                            int valor = int.Parse(input);
                            numeros[a] = valor;

                        }
                        Console.WriteLine("Valores en el array:");
                        foreach (int numero in numeros)
                        {
                            Console.WriteLine(numero);
                        }
                        Array.Sort(numeros);
                        int menor = numeros[0];
                        Console.WriteLine($"El menor es:{menor}");

                        string salir1 = Console.ReadLine();

                        // Verificar si la entrada está vacía (presionó Enter)
                        if (string.IsNullOrWhiteSpace(salir1)) break;

                        break;
                    case 4:
                        //piramide
                        Console.WriteLine("Ingresa un numero para tu piramide");
                        string val0001 = Console.ReadLine();
                        int num0001 = int.Parse(val0001);


                        for (int i = 1; i <= num0001; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("0 ");
                            }
                            Console.WriteLine(); // Salto de línea después de cada fila

                        }
                        string salir2 = Console.ReadLine();

                        // Verificar si la entrada está vacía (presionó Enter)
                        if (string.IsNullOrWhiteSpace(salir2)) break;
                        break;

                    case 5:
                        Console.WriteLine("Gracias por usar mi app, pase buenas");
                        string salir3 = Console.ReadLine();

                        // Verificar si la entrada está vacía (presionó Enter)
                        if (string.IsNullOrWhiteSpace(salir3)) Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Selecciona una opcion valida");
                        break;

                }
            }

        }
    }
}
