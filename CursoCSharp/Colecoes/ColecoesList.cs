using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesList
    {  
        public class Produto
        {
            public string Nome;
            public double Preco;
            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object obj)
            {
                return obj is Produto produto &&
                       Nome == produto.Nome &&
                       Preco == produto.Preco;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Nome, Preco);
            }

            //public override bool Equals(object obj)
            //{
            //    Produto outroProduto = (Produto)obj;
            //    bool mesmoNome = Nome == outroProduto.Nome;
            //    bool mesmoPreco = Preco == outroProduto.Preco;
            //    return mesmoNome && mesmoPreco;
            //}

            //public override int GetHashCode()
            //{
            //    return Nome.Length;
            //}
        }
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.99);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("5TEMP Sobrenatural", 45.6),
                new Produto("Poster", 12.9)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var i in carrinho) {
                Console.Write(carrinho.IndexOf(i));
                Console.WriteLine($"{i.Nome} {i.Preco}");
            }
        }
    }
}
