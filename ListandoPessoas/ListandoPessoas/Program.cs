using ListandoPessoas.Controller;
using ListandoPessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas aqui podemos listar e demais funcionalidades
            PessoaController pessoaController = new PessoaController();
            MostraIdentificadorAcao("LISTA ORIGINAL");
            pessoaController.ListaDePessoasPublica.ForEach(i => MostraInformacoes(i));
            MostraIdentificadorAcao("LISTA CRESCENTE POR NOME");
            pessoaController.GetPessoasOrdenadaAsc().ForEach(i => MostraInformacoes(i));
            MostraIdentificadorAcao("LISTA DECRESCENTE POR DATA NASCIMENTO");
            pessoaController.GetPessoasOrdenadaDesc().ForEach(i => MostraInformacoes(i));
            MostraIdentificadorAcao("LISTA COM FILTRO NA CARTEIRA");
            pessoaController.GetPessoasFiltraValorCarteira(500).ForEach(i => MostraInformacoes(i));
            MostraIdentificadorAcao("LISTA COM MAIORES DE 18 ANOS");
            pessoaController.GetPessoasFiltraFaixaIdade(18).ForEach(i => MostraInformacoes(i));
            MostraIdentificadorAcao("LISTA COM MENORES DE 16 ANOS");
            pessoaController.GetPessoasFiltraFaixaIdade(0,16).ForEach(i => MostraInformacoes(i));
            Console.ReadKey();
        }

        public static void MostraInformacoes (Pessoa pessoa)
            {
            //o menos muda a direção da organização
            string template = "Id {0,2}   Nome {1,-10}   Nasc. {2,10}  Carteira {3,15}";
            string textoFormatado = string.Format(template, pessoa.Id, pessoa.Nome, 
                pessoa.Nascimento.ToShortDateString(),pessoa.Carteira.ToString("C2"));
            Console.WriteLine(textoFormatado);
        }

        public static void MostraIdentificadorAcao (string nomeAcao)
        {
            Console.WriteLine(string.Format("----------------{0,20}----------------",nomeAcao));
        }
    }
}
