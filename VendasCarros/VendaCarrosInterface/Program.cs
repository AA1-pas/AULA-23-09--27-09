using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
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

        /// <summary>
        /// Metodo que apresenta o menu principal
        /// </summary>
        public static void MenuPrincipal()
        {
            int opcao = int.MinValue;
            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("--------------SISTEMA DE VENDAS DE CARROS--------------");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Listar todas as vendas já realizadas");
                Console.WriteLine("2 - Gerar Relatórios");
                Console.WriteLine("3 - Exportar");
                Console.WriteLine("4 - Ler arquivo");
                Console.WriteLine("5 - Sair\n");
                Console.Write("Opção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n");
                        vendasController.RetornaListaFiltroMes().ForEach(x => ImpressaoDados(x));
                        Console.WriteLine("\nPresione qualquer tecla para retornar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        RelatorioMes();
                        Console.WriteLine("\nPresione qualquer tecla para retornar.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nDigite dois endereços com nomes diferentes de arquivos para salvar: ");
                        ExportaArquivo(Console.ReadLine().Replace( "'\'" ,"'\\'"), Console.ReadLine().Replace("'\'", "'\\'"));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nDigite o endereço do arquivo para ler: ");
                        LeArquivo(Console.ReadLine());
                        Console.ReadKey();
                        break;
                }
            }
        }

        /// <summary>
        /// Metodo para impressao de dados formatado
        /// </summary>
        /// <param name="carro">Recebe uma lista como parametro para impressao</param>
        public static void ImpressaoDados(Carro carro)
        {
            string template = "Id: {0,3}    Carro: {1,-35}    Valor: {2,12}    Quantidade: {3,3}    Data: {4,12}";
            string textoFormatado = string.Format(template, carro.Id, carro.Modelo,
                 carro.Valor.ToString("C2"), carro.Quantidade, carro.DataVenda.ToShortDateString());
            Console.WriteLine(textoFormatado);
        }

        /// <summary>
        /// Metodo que gera o relatorio pelo mes solicitado
        /// </summary>
        public static void RelatorioMes()
        {
            
            int mesFiltro;
            do
            {
                Console.WriteLine("\nDigite um mês válido que deseja gerar o relatório. Se '0' gera a lista completa.");
                int.TryParse(Console.ReadLine(), out mesFiltro);
            } while (mesFiltro < 0 || mesFiltro > 12);
            var listaFiltradaMes = vendasController.RetornaListaFiltroMes(mesFiltro);

            listaFiltradaMes.ForEach(x => ImpressaoDados(x));

            Console.WriteLine("\nO valor total das vendas é de : {0}", listaFiltradaMes.Sum(x => x.Valor * x.Quantidade));

            Console.WriteLine("A media por dia de venda (dividido pela quantidade de registros) : {0}", listaFiltradaMes.Average(x => x.Valor * x.Quantidade));

            Console.WriteLine("A media por dia (dividido por 30 dias) : {0}", listaFiltradaMes.Average(x => (x.Valor * x.Quantidade)/30));

        }

        /// <summary>
        /// Metodo que gera lista completa ordenada pela data
        /// </summary>
      

        public static void ExportaArquivo(string caminhoExport, string caminhoExport2)
        {
            int mesFiltro;
            do
            {
                Console.Write("Digite um mês válido que deseja gerar o relatório. Se '0' busca a lista completa. ");
                int.TryParse(Console.ReadLine(), out mesFiltro);
            } while (mesFiltro < 0 || mesFiltro > 12);
            var listaExp = vendasController.RetornaListaFiltroMes(mesFiltro);

            // 1: Escreve um linha para o novo arquivo
            using (StreamWriter writer = new StreamWriter(caminhoExport + ".csv", false))
            {
                writer.WriteLine("Id;Modelo;Quantidade;Valor;Data de Venda");
                foreach (var item in vendasController.ListaCompleta())
                {
                    var linha = item.Id + ";" + item.Modelo + ";" + item.Quantidade + ";" + item.Valor.ToString("C2") + ";" + item.DataVenda.ToShortDateString();
                    writer.WriteLine(linha);
                }
            }

            using (StreamWriter writer = new StreamWriter(caminhoExport2 + ".csv", false))
            {
                writer.WriteLine("Id;Modelo;Quantidade;Valor;Data de Venda");
                foreach (var item in vendasController.RetornaListaFiltroMes(mesFiltro))
                {
                    var linha = item.Id + ";" + item.Modelo + ";" + item.Quantidade + ";" + item.Valor.ToString("C2") + ";" + item.DataVenda.ToShortDateString();
                    writer.WriteLine(linha);
                }
                writer.WriteLine("\nO valor total das vendas no mes e de : {0}", listaExp.Sum(x => x.Quantidade * x.Valor));

                writer.WriteLine("A media por dia de venda (dividido pela quantidade de registros) : {0}",listaExp.Average(x => x.Quantidade * x.Valor));

                writer.WriteLine("A media por dia (dividido por 30 dias) : {0}\n\n", listaExp.Sum(x => (x.Quantidade * x.Valor))/30);

                Console.WriteLine("Exportação realizada com sucesso!!!");
                // 2: Anexa uma linha ao arquivo
                // using (StreamWriter writer = new StreamWriter(@"C:\Users\900063\OneDrive\Treinamento HBSIS\allan.csv", true))
                //    {
                //         writer.WriteLine("Quase tudo para Visual Basic");
                //     }
            }
        }

        public static void LeArquivo(string caminhoLe)
        {
            using (StreamReader read = new StreamReader(caminhoLe + ".csv", false))
            {
                string linha = string.Empty;
                while (linha != null)
                {
                    linha = read.ReadLine();
                    Console.WriteLine(linha);
                }
                
            }
                Console.WriteLine("Importação realizada com sucesso!!!");
        }
         
    }
}
   
    
