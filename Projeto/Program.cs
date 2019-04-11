using System;
using Projeto.dominio;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int opcao = 0;

            produtos.Add(new Produto(1001, "Quarda roupa", 1750.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 500.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 700.00));
            produtos.Add(new Produto(1004, "Armário duas portas", 500.00));
            produtos.Add(new Produto(1005, "Mesa retangular com seis cadeiras", 2000.00));
            produtos.Sort();

            while (opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if(opcao == 1)
                {
                    Tela.mostrarProdutos();
                }
                else if(opcao == 2)
                {
                    try
                    {
                    Tela.cadastrarProduto();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if(opcao == 3)
                {
                    try
                    {
                        Tela.cadastrarPedido();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if(opcao == 4)
                {
                    try
                    {
                        Tela.mostrarPedido();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if(opcao == 5)
                {
                    Console.WriteLine("Fim do programa!");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
