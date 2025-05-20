using System;

    class Emprestimo
    {
        static void Main(string[] args)
        {
            Console.Write("valor do empréstimo: ");
            float valorEmprestimo = float.Parse(Console.ReadLine());

            Console.Write("quantidade de parcelas: ");
            int quantidadeParcelas = int.Parse(Console.ReadLine());

            Console.Write("sua renda mensal: ");
            float rendaMensal = float.Parse(Console.ReadLine());

            float valorParcela = valorEmprestimo / quantidadeParcelas;
            float limiteParcela = rendaMensal * 0.3f;

            if (valorParcela <= limiteParcela)
            {
                Console.WriteLine("emprestimo aceito");
            }
            else
            {
                Console.WriteLine("emprestimo negado");
            }
        }
    }
