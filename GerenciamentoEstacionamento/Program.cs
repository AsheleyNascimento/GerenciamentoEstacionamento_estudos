using GerenciamentoEstacionamento;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamento[] estacionamento = new Estacionamento[11];

            int continuar;
            Boolean completo = true;

            do
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Documento: ");
                string documento = Console.ReadLine();

                Console.Write("Modelo Carro: ");
                string modelocarro = Console.ReadLine();

                Console.Write("Placa: ");
                string placacarro = Console.ReadLine();

                Console.Write("Vaga: ");
                int vaga = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                for (int i = 0; i < estacionamento.Length; i++)
                {
                    if (vaga >= estacionamento.Length)
                    {
                        Console.WriteLine("Vaga não existente escolha vagas dentre 1 e 10");
                        vaga = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    else if (vaga < 1 || vaga > 10)
                    {
                        Console.WriteLine("Vaga não existente escolha vagas dentre 1 e 10");
                        vaga = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }    
                }

                estacionamento[vaga] = new Estacionamento(nome, documento, modelocarro, placacarro);

                Console.WriteLine("Pressione 1 para Continuar ou 2 para Sair ");
                continuar = int.Parse(Console.ReadLine());

            } while ( continuar== 1);

            for (int i = 0; i < 10; i++)
            {
                if (estacionamento[i] != null)
                {
                    Console.WriteLine(i + ": " + estacionamento[i]);
                }
            }
        }
    }
}