using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivo();
            SomaInterioLista();
            SomaBalasListaDeCriancas();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que soma valores de um vetor
        /// </summary>
        private static void SomarInteiroPrimitivo()
        {
            // quando utilizamos "[]" em um tipo de "primitivo" podemos criar uma coleção detes valores
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(colecaoInteiros.Sum());

        }

        /// <summary>
        /// Metodo que soma valores um a um de uma lista
        /// </summary>
        private static void SomaInterioLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,25,45,1
            };
            Console.WriteLine(listaDeInteiros.Sum());

        }

        /// <summary>
        /// Metodo que faz a soma da quantidade de balas através de objeto
        /// </summary>
        private static void SomaBalasListaDeCriancas ()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
                new Crianca()
                {
                    Nome = "Joanzinho",
                    Balas = 9
                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }

            };
            Console.WriteLine("Quantidade de balas: {0}",criancas.Sum(x => x.Balas));


        }
    }
}