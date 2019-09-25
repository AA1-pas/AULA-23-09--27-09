using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>
            {
                new Venda()
                {
                    Produto = "XIAOMI",
                    Quantidade = 8,
                    Valor = 1200.75
                },

                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },

                new Venda()
                {
                    Produto = "IPHONE XL",
                    Quantidade = 1,
                    Valor = 9999
                }
            };

            Console.WriteLine("Media de produtos vendidos neste mês.");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Media dos valores.");
            Console.WriteLine(vendas.Average(x => (x.Valor * x.Quantidade)));
            Console.ReadKey();
        }
    }
}
