using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {  
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.99);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("5TEMP Sobrenatural", 45.6),
                new Produto("Poster", 12.9),
                new Produto("Poster", 12.9)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach(var i in carrinho) {
                //Console.Write(carrinho.IndexOf(i));
                Console.WriteLine($"{i.Nome} {i.Preco}");
            }
        }
    }
}
