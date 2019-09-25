using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaCarrosBiblioteca.Controller;
using VendaCarrosBiblioteca.Model;

namespace VendaCarrosInterface
{
   
    class Program
    {
        private static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
                
            MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            int opcao = int.MinValue;
            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("--------------SISTEMA DE VENDAS DE CARROS--------------");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Listar todas as vendas já realizadas");
                Console.WriteLine("2 - Gerar Relatórios");
                Console.WriteLine("3 - Sair\n");
                Console.Write("Opção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n");
                        vendasController.listaCompleta().ForEach(x => ImpressaoDados(x));
                        Console.WriteLine("\nPresione qualquer tecla para retornar.");
                        Console.ReadKey();
                    break;
                    case 2:
                        Console.WriteLine("\nDigite o mês que deseja gerar o relatório.");
                        int.TryParse(Console.ReadLine(), out int mesFiltro);
                        vendasController.listaCompleta().FindAll(x => x.DataVenda.Month == mesFiltro).ForEach(x => ImpressaoDados(x));
                        Console.WriteLine("O valor total das vendas é de : {0}",vendasController.listaCompleta().Sum(x => x.Valor).ToString("C2"));
                        Console.WriteLine("O valor total das vendas é de : {0}", vendasController.listaCompleta().Sum(x => x.Valor).ToString("C2"));
                        Console.WriteLine("\nPresione qualquer tecla para retornar.");
                        Console.ReadKey();
                    break;
                }
            }
        }

        public static void ImpressaoDados(Carro carro)
        {
            string template = "Id: {0,3}   Carro: {1,-35}  Valor: {2,8}  Quantidade: {3,3}  Data: {4,12}";
            string textoFormatado = string.Format(template, carro.Id, carro.Modelo,
                 carro.Valor.ToString("C2"), carro.Quantidade, carro.DataVenda.ToShortDateString());
            Console.WriteLine(textoFormatado);
        }

    }
    
}
