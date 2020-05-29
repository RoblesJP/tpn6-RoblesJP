using System;

namespace tp06_invertirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Ingrese el numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Error!: el numero ingresado debe ser mayor a 0");
                }
            } while (numero <= 0);
            Console.WriteLine("Numero invertido: " + InvertirNumero(numero));
        }

        static int InvertirNumero(int n)
        {
            string numeroInvertido = "";
            while (n > 0)
            {
                numeroInvertido += Convert.ToString(n % 10);
                n /= 10;
            }
            return Convert.ToInt32(numeroInvertido);
        }
    }
}
