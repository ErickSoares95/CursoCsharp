using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach(var i in arraylist)
            {
                System.Console.WriteLine("{0} => {1}", i, i.GetType());
            }
        }
    }
}
