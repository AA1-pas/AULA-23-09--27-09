﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes.Aggregate((nome1, nome2) => nome1 + ";" + nome2);
            var texto2 = listaDeNomes.Aggregate((nome1, nome2) => nome1 + " " + "-" + " "+ nome2);
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.ReadKey();
        }
    }
}
