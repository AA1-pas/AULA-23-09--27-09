using ListandoPessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas.Controller
{
    class PessoaController
    {
        /// <summary>
        ///  lista que contem as pessoas para realizar as atividades
        /// </summary>
        private List<Pessoa> listaDePessoas { get; set; }

        /// <summary>
        /// Metodo construtur ajuda a iniciar nossa clasee para utilizarmos de maneira correta as informações internas, com isso podemos 
        /// iniciar nossa lista de pessoas sem depender do usuario ou programador na parte da interface
        /// </summary>
        public PessoaController()
        {
            listaDePessoas = new List<Pessoa>();
            
                listaDePessoas.Add(new Pessoa(){Id = 1 ,Nome ="Spears",Nascimento =DateTime.Parse("07/11/2004"), Carteira = 846.96});
                listaDePessoas.Add(new Pessoa(){Id = 2 ,Nome ="Swanson",Nascimento =DateTime.Parse("20/06/2003"),Carteira = 233.09});
                listaDePessoas.Add(new Pessoa(){Id = 3 ,Nome ="Gay",Nascimento =DateTime.Parse("03/12/2001"),Carteira = 911.92});
                listaDePessoas.Add(new Pessoa(){Id = 4 ,Nome ="Gregory",Nascimento =DateTime.Parse("02/01/2000"),Carteira = 469.01});
                listaDePessoas.Add(new Pessoa(){Id = 5 ,Nome ="Olson",Nascimento =DateTime.Parse("18/07/2001"),Carteira = 261.90});
                listaDePessoas.Add(new Pessoa(){Id = 6 ,Nome ="Garza",Nascimento =DateTime.Parse("01/04/2000"),Carteira = 360.41});
                listaDePessoas.Add(new Pessoa(){Id = 7 ,Nome ="Sweet",Nascimento =DateTime.Parse("12/03/2003"),Carteira = 312.76});
                listaDePessoas.Add(new Pessoa(){Id = 8 ,Nome ="Cline",Nascimento =DateTime.Parse("26/03/2002"),Carteira = 484.51});
                listaDePessoas.Add(new Pessoa(){Id = 9 ,Nome ="Oliver",Nascimento =DateTime.Parse("05/07/2004"),Carteira = 513.76});
                listaDePessoas.Add(new Pessoa(){Id = 10,Nome ="Vang",Nascimento =DateTime.Parse("10/07/2000"),Carteira = 271.05});
                listaDePessoas.Add(new Pessoa(){Id = 11,Nome ="Maddox",Nascimento =DateTime.Parse("29/05/2004"),Carteira = 783.97});
                listaDePessoas.Add(new Pessoa(){Id = 12,Nome ="Garrett",Nascimento =DateTime.Parse("03/06/2006"),Carteira = 154.11});
                listaDePessoas.Add(new Pessoa(){Id = 13,Nome ="Mcintosh",Nascimento =DateTime.Parse("06/07/2006"),Carteira = 902.80});
                listaDePessoas.Add(new Pessoa(){Id = 14,Nome ="Yang",Nascimento =DateTime.Parse("29/04/2005"),Carteira = 550.48});
                listaDePessoas.Add(new Pessoa(){Id = 15,Nome ="Hendricks",Nascimento =DateTime.Parse("05/09/2003"),Carteira = 410.56});
                listaDePessoas.Add(new Pessoa(){Id = 16,Nome ="Cain",Nascimento =DateTime.Parse("12/01/2002"),Carteira = 221.13});
                listaDePessoas.Add(new Pessoa(){Id = 17,Nome ="Blackburn",Nascimento =DateTime.Parse("10/05/2000"),Carteira = 135.67});
                listaDePessoas.Add(new Pessoa(){Id = 18,Nome ="Howe",Nascimento =DateTime.Parse("27/09/2005"),Carteira = 360.14});
                listaDePessoas.Add(new Pessoa(){Id = 19,Nome ="Pratt",Nascimento =DateTime.Parse("18/09/2000"),Carteira = 991.83});
                listaDePessoas.Add(new Pessoa(){Id = 20,Nome ="Sherman",Nascimento =DateTime.Parse("20/02/2003"),Carteira = 667.00});
                                             

        }
        public List<Pessoa> ListaDePessoasPublica
        {
           get { return listaDePessoas; }
        }
        
        public List<Pessoa> GetPessoasOrdenadaAsc()
        {
            return listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>();
        }

        public List<Pessoa> GetPessoasOrdenadaDesc()
        {
            return listaDePessoas.OrderByDescending(x => x.Nascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo que retorna as pessoas com determinado valor dentro da carteira
        /// </summary>
        /// <param name="valor">Valor informado para o filtro caso não informe o parametro o valor será 500</param>
        /// <returns>Retorna lista com o filtro de valor na carteria</returns>
        public List<Pessoa> GetPessoasFiltraValorCarteira(double valor = 500)
        {
            return listaDePessoas.FindAll(x => x.Carteira > valor).OrderBy(x => x.Carteira).ToList<Pessoa>();
        }

        /// <summary>
        /// Metodo que filtra uma faixa de idade informada pelo usuario
        /// caso não informe parametro idade minima será 0 e idade máxima será 150
        /// </summary>
        /// <param name="idade1">Parametro de idade minima</param>
        /// <param name="idade2">Parametro de idade maxima</param>
        /// <returns></returns>
        public List<Pessoa> GetPessoasFiltraFaixaIdade(int idade1 = 0, int idade2 = 150)
        {
            //List<int> listaIdade = new List<int>();
            //foreach (var item in listaDePessoas)
            //{
            //    TimeSpan idade = DateTime.Now - item.Nascimento;
            //    listaIdade.Add(idade.Days/365);
            //} 
            return listaDePessoas.FindAll(x => DateTime.Now.Year - x.Nascimento.Year > idade1 && DateTime.Now.Year - x.Nascimento.Year < idade2);
        }

    }
}
