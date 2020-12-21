using System;
using System.Collections.Generic;
namespace ObjetoArgumento.classes
{
    public class Carrinho : Produto
    {
        // - 0 Criamos uma propriedade para guardar o valor total do carrinho
        public float ValorTotal {get; set;}
       List<Produto> listadeProdutos = new List <Produto>();

        public void AdicionarProduto(Produto produto)
        {
            listadeProdutos.Add(produto);
        }
        public void MostrarProdutos()
        {
            if (listadeProdutos != null)
            {
                foreach (var item in listadeProdutos)
                {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"R${item.Preco.ToString("n2")} {item.Nome}");
                Console.ResetColor();
                }
                
                
            }
        }
        public void RemoverProduto(Produto produto)
        {
            listadeProdutos.Remove(produto);
        }
        public void AlterarItem(int _codigo, Produto _produtoNovo)
        {
            listadeProdutos.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
            listadeProdutos.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
        }
        
        
        
    }
}