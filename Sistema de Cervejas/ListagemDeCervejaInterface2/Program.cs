using ListagemDeCerveja.Controller;
using ListagemDeCerveja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejaInterface2
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            AdicionaCerveja();
            cervejaController.ListarInformacoes().ForEach(x => Console.WriteLine("Id: {0,2} Nome: {1,-15} Litros: {2,4} Alcool: {3,4} Valor: {4,8}"
                , x.Id, x.Nome, x.Litros, x.Alcool, x.Valor.ToString("C2")));
            Console.WriteLine("\nO Total de cerveja é: {0} litros.", cervejaController.RetornaTotalLitros());
            Console.WriteLine("O valor total em cerveja é de: {0}", cervejaController.RetornaValorTotal());
            Console.WriteLine("\n\nPara calcular o indice de alcool no seu sangue digite seu peso:");
            int.TryParse(Console.ReadLine(), out int peso);
            Console.WriteLine("\nO teor alcólico no sangue é de {0} g de álcool/litro de sangue.",
                cervejaController.VerSeVaiPreso(peso));
            // Console.WriteLine("\n\nSe desejar, informe o limite permitido de álcool no sangue: ");
            // double.TryParse(Console.ReadLine().Replace("0","0.6"), out double limite);
            // if (cervejaController.VerSeVaiPreso(peso) > limite)
            //     Console.WriteLine("\n*** Com essa quantidade de álcool no sangue você poderá ser preso. ***");
            // else
            //     Console.WriteLine("\n*** Com essa quantidade de álcool no sangue você não será preso. ***");
            Console.ReadKey();

        }

        public static void AdicionaCerveja()
        {
            Console.WriteLine("Digite o nome da cerveja: ");
            var nomeCerveja = Console.ReadLine();
            Console.WriteLine("Digite quantos litros possue a embalagem: ");
            double.TryParse(Console.ReadLine(), out double litrosCerveja);
            Console.WriteLine("Digite qual o grau alcólico da cerveja: ");
            double.TryParse(Console.ReadLine(), out double alcoolCerveja);
            Console.WriteLine("Digite qual o valor da cerveja: ");
            double.TryParse(Console.ReadLine(), out double valorCerveja);

            cervejaController.AdicionarCerveja(new Cerveja()
            {
                Nome = nomeCerveja,
                Litros = litrosCerveja,
                Alcool = alcoolCerveja,
                Valor = valorCerveja

            });


        }
    }
}
