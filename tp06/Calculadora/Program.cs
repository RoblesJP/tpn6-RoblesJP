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
            int a = 0;
            int b = 0;
            int resultado = 0;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Producto");
            Console.WriteLine("4. Cociente");
            do
            {
                do
                {
                    Console.Write(">> Accion: ");
                    accion = Convert.ToInt32(Console.ReadLine());
                    if (accion < 1 || accion > 4)
                    {
                        Console.WriteLine("Error!: accion ingresada incorrecta");
                    }
                } while (accion < 1 || accion > 4);

                switch (accion)
                {
                    case 1:
                        Console.WriteLine("Elegiste SUMA");
                        Console.Write("a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        resultado = a + b;
                        break;
                    case 2:
                        Console.WriteLine("Elegiste RESTA");
                        Console.Write("a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        resultado = a - b;
                        break;
                    case 3:
                        Console.WriteLine("Elegiste PRODUCTO");
                        Console.Write("a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        resultado = a * b;
                        break;
                    case 4:
                        Console.WriteLine("Elegiste COCIENTE");
                        Console.Write("a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            Console.Write("b: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            if (b == 0)
                            {
                                Console.WriteLine("Error!: el denominador no puede ser 0");
                            }
                        } while (b == 0);
                        resultado = a / b;
                        break;
                }
                Console.WriteLine("RESULTADO: {0}", resultado);

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
