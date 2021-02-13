using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            string idademaior;
            idademaior = "";
            string[] nome;
            int[] idade;

            int n = int.Parse(Console.ReadLine());

            nome = new string[n];
            idade = new int[n];

            for(int i=0;i<n;i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                nome[i] = vetor[0];
                idade[i] = int.Parse(vetor[1]);

                if(maior==0)
                {
                    maior = idade[i];
                   idademaior = nome[i];
                }
                else if(maior < idade[i])
                {
                    maior = idade[i];
                    idademaior = nome[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pessoa mais velha : " + idademaior);
        }
    }
}
