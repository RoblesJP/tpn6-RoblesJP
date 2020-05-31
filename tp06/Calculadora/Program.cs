using System;
using System.Diagnostics.CodeAnalysis;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int accion = 0;
            int rep = 0;
            double x = 0;
            double y = 0;
            double resultado = 0;

            Console.WriteLine("0. Suma (x + y)");
            Console.WriteLine("1. Resta (x - y)");
            Console.WriteLine("2. Producto (x * y)");
            Console.WriteLine("3. Cociente (x / y)");
            Console.WriteLine("4. Valor absoluto (|x|)");
            Console.WriteLine("5. Cuadrado (x^2)");
            Console.WriteLine("6. Raiz cuadrada (x^(1/2))");
            Console.WriteLine("7. Seno (sin(x))");
            Console.WriteLine("8. Coseno (cos(x))");
            Console.WriteLine("9. Parte entera de un decimal (floor(x))");
            do
            {
                string expresion = "";
                do
                {
                    Console.Write(">> Accion: ");
                    accion = Convert.ToInt32(Console.ReadLine());
                    if (accion < 0 || accion > 9)
                    {
                        Console.WriteLine("Error!: accion ingresada incorrecta");
                    }
                } while (accion < 0 || accion > 9);

                switch (accion)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        Console.Write("x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.Write("x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        break;
                }

                switch (accion)
                {
                    case 0:                     
                        resultado = x + y;
                        expresion += $"{x}+{y}";
                        break;
                    case 1:
                        resultado = x - y;
                        expresion += $"{x}-{y}";
                        break;
                    case 2:
                        resultado = x * y;
                        expresion += $"{x}*{y}";
                        break;
                    case 3:
                        if (y == 0)
                        {
                            Console.WriteLine("Error!: el denominador no puede ser 0");
                            resultado = 0;
                            expresion += $"{x}/{y}";
                        } 
                        else
                        {
                            resultado = x / y;
                            expresion += $"{x}/{y}";
                        }
                        break;
                    case 4:
                        resultado = Math.Abs(x);
                        expresion += $"|{x}|";
                        break;
                    case 5:
                        resultado = Math.Pow(x, 2);
                        expresion += $"{x}^2";
                        break;
                    case 6:
                        if (x < 0)
                        {
                            Console.WriteLine("Error!: valor ingresado no pertenece al dominio de la operacion");
                            resultado = 0;
                            expresion += $"{x}^(1/2)";
                        }
                        else
                        {
                            resultado = Math.Sqrt(x);
                            expresion += $"{x}^(1/2)";
                        }
                        
                        break;
                    case 7:
                        resultado = Math.Sin(x);
                        expresion += $"sin({x})";
                        break;
                    case 8:
                        resultado = Math.Cos(x);
                        expresion += $"cos({x})";
                        break;
                    case 9:
                        resultado = Math.Floor(x);
                        expresion += $"floor({x})";
                        break;
                }

                Console.WriteLine($"EL RESULTADO DE {expresion} ES {resultado}");

                do
                {
                    Console.Write("Desea realizar otra operacion? SI[Y] NO[N]: ");
                    rep = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (rep != 'Y' && rep != 'N')
                    {
                        Console.WriteLine("Error!: accion ingresada incorrecta");
                    }
                } while (rep != 'Y' && rep != 'N');
            } while (rep == 'Y');
        }
    }
}
