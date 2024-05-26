//using System.ComponentModel.Design;
//using System.Reflection.Metadata.Ecma335;


//Console.WriteLine("Tipos de datos");
//Console.WriteLine();

////Tipo Numero
//Console.WriteLine("Numero:");
//int number = 9;
//Console.WriteLine(number);
//Console.WriteLine();

////Tipo Double
//Console.WriteLine("double");
//double number2 = 3.1416;
//Console.WriteLine(number2);
//Console.WriteLine();

////Tipo Float
//Console.WriteLine("float");
//float number3 = 3.14f;
//Console.WriteLine(number3);
//Console.WriteLine();

////Tipo Char
//Console.WriteLine("char");
//char letter = 'A';
//Console.WriteLine(letter);
//Console.WriteLine();

////Tipo Boolean
//Console.WriteLine("boolean");
//bool dis = false;
//Console.WriteLine(dis);
//Console.WriteLine();

////Tipo String
//Console.WriteLine("string");
//string word = "remoto";
//Console.WriteLine(word);


//if (number <= 2)
//{
//    Console.WriteLine("menor o igual que 2");
//}
//Console.WriteLine();

//if (number > 2)
//{
//    Console.WriteLine("mayor que 2");
//}
//else
//{
//    Console.WriteLine("Ni se sabe");

//}
//Console.WriteLine();
//if (number < 2)
//{
//    Console.WriteLine("menor que 2");
//}
//else if (number == 4)
//{
//    Console.WriteLine("igual que 4");

//}
//else
//{
//    Console.WriteLine("mayor que 2 y diferente a 4");

//}

//edad
using PrimeraPractica;
using System;


class Ejercicios
{
    static void Main(string[] args)
    {
        ProyectoFinal.FinalProject();

        //VerificarEdad();
        //VerificarPromedio();
        //NumeroMenor();
        //ParoImpar();
        //PositivouNegativo();
        //Ciclos();
        //CiclosReverse();
        //Pares();
        //UnoCien();
        //Impares();
        //Negativo();
        //PairBetween();
        // OpcionesMenu();
        // ProyectoFinal();
    }

    void VerificarEdad()
    {
        Console.WriteLine("Cual es tu edad?");
        Console.WriteLine();
        string input = Console.ReadLine();
        int edad = int.Parse(input);

        if (edad < 18)
        {
            Console.WriteLine("usted e' un menor");
        }
        else
        {
            Console.WriteLine("Tenemos un mayor, uoooo");
        }

    }


    ////5 numeros
    static void VerificarPromedio()
    {
        Console.WriteLine("Calculadora de promedio ");
        Console.WriteLine("Ingresa la primera calificación");
        Console.WriteLine();
        string input1 = Console.ReadLine();
        int numero1 = int.Parse(input1);

        Console.WriteLine("Ingresa la segunda calificación");
        Console.WriteLine();
        string input2 = Console.ReadLine();
        int numero2 = int.Parse(input2);

        Console.WriteLine("Ingresa la tercera calificación");
        Console.WriteLine();
        string input3 = Console.ReadLine();
        int numero3 = int.Parse(input3);

        Console.WriteLine("Ingresa la cuarta calificación");
        Console.WriteLine();
        string input4 = Console.ReadLine();
        int numero4 = int.Parse(input4);

        Console.WriteLine("Ingresa la quinta calificación");
        Console.WriteLine();
        string input5 = Console.ReadLine();
        int numero5 = int.Parse(input5);

        int total = numero1 + numero2 + numero3 + numero4 + numero5;
        int promedio = total / 5;
        if (promedio >= 70)
        {
            Console.WriteLine("Usted paso con:" + promedio);
        }
        else
        {
            Console.WriteLine("Usted se quemo con:" + promedio);
        }
    }

    static void NumeroMenor()
    {
        Console.WriteLine("Identificar numero menor ");
        ////Numero menor
        Console.WriteLine("Ingresa tres numeros");
        Console.WriteLine("Ingresa el primer numero");
        Console.WriteLine();
        string value1 = Console.ReadLine();
        int num1 = int.Parse(value1);

        Console.WriteLine("Ingresa el segundo numero");
        Console.WriteLine();
        string value2 = Console.ReadLine();
        int num2 = int.Parse(value2);

        Console.WriteLine("Ingresa el tercer numero");
        Console.WriteLine();
        string value3 = Console.ReadLine();
        int num3 = int.Parse(value3);

        if (num1 > num2 && num1 > num3)
        {
            if (num2 > num3)
            {
                Console.WriteLine(num3);

            }
            else
            {
                Console.WriteLine("El menos es:");
                Console.WriteLine(num2);


            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine("El menor es:");
                Console.WriteLine(num3);

            }
            else
            {
                Console.WriteLine("El menor es:");
                Console.WriteLine(num1);

            }
        }
        else
        {
            if (num1 > num2)
            {
                Console.WriteLine("El menor es:");
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("El menor es:");
                Console.WriteLine(num1);
            }
        }
    }


    ////par o impar
    static void ParoImpar()
    {
        Console.WriteLine("Ingresa un numero para verificar si es par o impar");

        Console.WriteLine("Ingresa el numero");
        Console.WriteLine();
        string val1 = Console.ReadLine();
        int n1 = int.Parse(val1);

        if (n1 % 2 == 0)
        {
            Console.WriteLine("Este numero es par");
        }
        else
        {
            Console.WriteLine("Este no e' par");
        }
    }


    ////positivo o negativo
    static void PositivouNegativo()
    {
        Console.WriteLine("Ingresa un numero para ver si es positivo o Negativo ");
        Console.WriteLine("Ingresa el numero");
        Console.WriteLine();
        string valore1 = Console.ReadLine();
        int numeros1 = int.Parse(valore1);

        if (numeros1 > 0)
        {
            Console.WriteLine("Este numero es positivo");
        }
        else
        {
            Console.WriteLine("Este numero es negativo");
        }
    }

    //ciclos
    static void Ciclos()
    {
        Console.WriteLine("Muestra los numeros del 1 al 100 ");
        // app que muestre los primeros 100 números enteros iniciando desde el 1.
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void CiclosReverse()
    {
        Console.WriteLine("Muestra los numeros del 100 al 1 ");
        //app que muestre los primeros 100 números de forma inversa, es decir, del 100 al 1
        for (int i = 100; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }


    //app que muestre únicamente, los números pares en el rango del 1 al 100
    static void Pares()
    {
        Console.WriteLine("Muestra los numeros pares del  1 al 100 ");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void UnoCien()
    {
        Console.WriteLine("Suma los numeros del  1 al 100 ");
        //Suma numeros 1 al 100
        int suma = 0;
        for (int i = 1; i <= 100; i++)
        {
            suma = suma + i;
        }
        Console.WriteLine(suma);
    }


    static void Impares()
    {
        Console.WriteLine("Suma los numeros impares del  1 al 100 ");
        //Suma numeros impares del 1 al 100
        int sumar = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 > 0)
            {
                sumar += i;
            }
        }
        Console.WriteLine(sumar);
    }


    static void Negativo()
    {

        //app que pida números mientras no se ingrese uno negativo. Al final, se debe mostrar la suma de los números ingresados
        int total = 0;
        while (true)
        {
            Console.WriteLine("Suma de numeros hasta que ingreses un negativo ");
            Console.WriteLine("Ingresa el numero");
            Console.WriteLine();
            string val1 = Console.ReadLine();
            int n1 = int.Parse(val1);
            if (n1 > 0)
            {
                total += n1;
            }
            else
            {
                Console.WriteLine("Usted ingreso un numero negativo");
                Console.WriteLine("El total ingresado fue:" + total);
                break;

            }
        }
    }


    static void PairBetween()
    {
        Console.WriteLine("Muestra los numeros pares entre dos numeros ");
        //App que pida 2 números enteros, e imprima los números pares que existen entre los 2.
        Console.WriteLine("Ingresa el primer numero");
        string val1 = Console.ReadLine();
        int num1 = int.Parse(val1);

        Console.WriteLine("Ingresa un numero mayor");
        string val2 = Console.ReadLine();
        int num2 = int.Parse(val2);
        Console.WriteLine();

        if (num1 > num2)
        {
            Console.WriteLine("El numero 1 es mayor");
            Environment.Exit(0);
        }
        else
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }



    static void OpcionesMenu()
    {
        //app que muestre un menú en pantalla con las opciones:

        while (true)
        {
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1.Sumar\r\n2.Restar\r\n3.Multiplicar\r\n4.Dividir\r\n5.Salir");
            string opcion = Console.ReadLine();
            int option = int.Parse(opcion);

            if (option != 5)
            {
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

                    default:
                        Console.WriteLine("La opcion que ingresaste no esta en el menu");
                        break;
                }


            }
            else
            {
                Environment.Exit(0);
            }
        }

    }
}














