using System;

namespace InversoQuadrado
{
    class Program
    {
    static void Main(string[] args)

    {
        //Array
        int[] vet = new int [5];
        int i = 0;

        //Números que serão fornecidos pelo usuário
        for (i = 0; i < 5; i++)
        {
            Console.Write($"Valor {i + 1} : ");
            vet[i] = int.Parse(Console.ReadLine());
        }

        //Inverso dos números
        Console.Write("Inverso: ");
        for (i = 4; i >= 0; i--)
        {
            Console.Write(vet[i] + " ");
        }

        Console.WriteLine(" ");

        //Quadrado dos números
        Console.Write("Quadrado: ");
        for (i = 0; i < 5; i++)
        {
            Console.Write(vet[i] * vet[i] + " ");
        }
        
        Console.WriteLine(" ");

        //Números maiores que 3
        Console.Write("Números maiores que 3: ");
        for (i = 0; i < 5; i++)
        {
            if (vet[i] > 3)
            {
                Console.Write(vet[i] + " ");
            }
        }

        Console.WriteLine(" ");

        //Indices de números pares10
        Console.Write("Números pares: ");
        for (i = 0; i < 5; i++)
        {
            if (vet[i] % 2 == 0)
            {
                Console.Write(vet[i] + " ");
            }
        }
        
        Console.WriteLine(" ");
    }

    }
}