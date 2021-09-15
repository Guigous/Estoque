using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {

        static void Main(string[] args)
        {
            //input, processamento e Output de dados
            Produto p = new Produto("Nome", 0.0, 0);
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados do atualizados: " + p);
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
}
