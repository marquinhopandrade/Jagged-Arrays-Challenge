using System;

namespace Jagged_Arrays_Challenge
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string[][] amigos = new string[3][];//1o index: define o array
                                                //2o index: anda pelos elementos da array referente
            for (int k = 0; k < 3; k++)
            {
                amigos[k] = new string[3];
            }

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Dê o nome do {0}o amigo", i + 1);
                amigos[i][0] = Console.ReadLine();
                for (int j = 1; j < amigos[i].Length; j++)
                {
                    Console.WriteLine("Dê o nome do {0}o familiar do {1}o amigo", j, i);
                    amigos[i][j] = Console.ReadLine();
                }
            }
            for(int i = 0 , k = amigos.Length -1 ; i < amigos.Length && k >= 0; i++,k--)
            {
                for (int j = 1, l = 2; j < amigos.Length && l >= 1; j++, l--)
                {
                    if (i == k && j == l)
                    {
                        Console.WriteLine("aaaaaaa");
                    }
                    else
                    Console.WriteLine("{0}, este(a) é o(a) {1}", amigos[i][j], amigos[k][l]);
                }
                
            }
        }

    }
}
