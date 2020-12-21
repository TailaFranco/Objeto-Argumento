using System;
using ObjetoArgumento.classes;
namespace ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar menu com opções
            // 1- Cadastrar Produto
            // 2- Listar Produto
            // 3- Deletar produto
            // 4- Alterar produto

            Produto produto1 = new Produto(1, "Mouse Razer 3.5", 300);
            Produto produto2 = new Produto(2, "Headset Chrona 7.1", 500);
            Produto produto3 = new Produto(3, "Mouse Pad XTPD", 120);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);
            carrinho.MostrarProdutos();

           // carrinho.RemoverProduto(produto2); // Aqui eu removo da lista
            Console.WriteLine($"Alterar produto 2");
            
           Produto produtoNovo = new Produto();
           produtoNovo.Nome = "Fone com microfone da Xamxung";
           produtoNovo.Preco = 5;
           carrinho.AlterarItem(2, produtoNovo);
            carrinho.MostrarProdutos();
        }
    }
}
