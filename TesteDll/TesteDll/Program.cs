using DllPastaWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDll
{
    class Program
    {
        static DocumentsAutoGenerate pastaWin = new DocumentsAutoGenerate();
        static HoraDoShow horaDoShow = new HoraDoShow();
        static void Main(string[] args)
        {
            int opcao = int.MinValue;
            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("---------------SISTEMA DE PASTAS------------------\\n\n");
                Console.WriteLine("1 - Criar pastas nos meus documentos");
                Console.WriteLine("2 - Deletar pastas nos meus documentos");
                Console.WriteLine("3 - Listar as pastas nos meus documentos");
                Console.WriteLine("4 - Desenhar");
                Console.WriteLine("5 - Sair");
                Console.Write("\nOpção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        CriarPastas();
                        Retorna();
                         break;
                    case 2:
                        DeletarPasta();
                        Retorna();
                        break;
                    case 3:
                        ListarPastas();
                        Retorna();
                        break;
                    case 4:
                        DesenhaImagem();
                        Retorna();
                        break;

                }

            }

        }

        public static void DeletarPasta()
        {
            Console.WriteLine("\nDigite um nome para a pasta a ser deletada:");
            var pasta = Console.ReadLine();
            pastaWin.DeletarPastaMeusDocumentos(pasta, true);
            Console.WriteLine("\nPasta Apagada!!!");
        }

        public static void CriarPastas()
        {
            Console.WriteLine("Digite um nome para a pasta a ser criada:");
            var pasta = Console.ReadLine();
            pastaWin.CriarPastaMeusDocumentos(pasta);
            Console.WriteLine("Pasta Criada com sucesso!!!");
        }

        public static void ListarPastas()
        {
            pastaWin.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
        }

        public static void DesenhaImagem()
        {
            horaDoShow.Birllllllllll();
        }

        public static void Retorna()
        {
            Console.WriteLine("\nPressione qualquer tecla para retornar");
            Console.ReadKey();
           
        }
    }

}
