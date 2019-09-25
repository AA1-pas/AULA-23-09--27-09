using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaCarrosBiblioteca.Controller;
using VendaCarrosBiblioteca.Model;

namespace ConsoleApp1
{
    class Program
    {
     
            public static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("--------------SISTEMA DE VENDAS DE CARROS--------------");
            MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Listar todas as vendas já realizadas");
            Console.WriteLine("2 - Gerar Relatórios");
            Console.WriteLine("3 - Sair\n");
            Console.Write("Opção: ");
            char opcao = Console.ReadKey().KeyChar;
            switch (opcao)
            {
                case '1':
                    vendasController.listaCompleta().ForEach(x => ImpressaoDados(x));
                    break;
            }
        }

        public static void ImpressaoDados(Carro carro)
        {
            string template = "Id: {0,2}   Carro: {1,-25}  Valor: {2,10}  Quantidade: {3,3}  Data: {4,10}";
            string textoFormatado = string.Format(template, carro.Id, carro.Modelo,
                carro.Quantidade, carro.Valor.ToString("C2"), carro.DataVenda.ToShortDateString());
            Console.WriteLine(textoFormatado);
        }

    }
}

