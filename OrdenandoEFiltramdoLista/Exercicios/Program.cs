using Exercicios.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static List<Pessoas> listaPessoas = new List<Pessoas>();
        static void Main(string[] args)
        {
            #region Cadastra Pessoas
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Spears",
                Nascimento = DateTime.Parse("07/11/2004"),
                Carteira = 846.96,
                Id = 1
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Swanson",
                Nascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09,
                Id = 2
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Gay",
                Nascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92,
                Id = 3
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Gregory",
                Nascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01,
                Id = 4
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Olson",
                Nascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90,
                Id = 5
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Garza",
                Nascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41,
                Id = 6
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Sweet",
                Nascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76,
                Id = 7
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Cline",
                Nascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51,
                Id = 8
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Oliver",
                Nascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76,
                Id = 9
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Vang",
                Nascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05,
                Id = 10
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Maddox",
                Nascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97,
                Id = 11
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Garrett",
                Nascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11,
                Id = 12
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Mcintosh",
                Nascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80,
                Id = 13
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Yang",
                Nascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48,
                Id = 14
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Hendricks",
                Nascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56,
                Id = 15
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Cain",
                Nascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13,
                Id = 16
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Blackburn",
                Nascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67,
                Id = 17
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Howe",
                Nascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14,
                Id = 18
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Pratt",
                Nascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83,
                Id = 19
            });
            listaPessoas.Add(new Pessoas()
            {
                Nome = "Sherman",
                Nascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00,
                Id = 20
            });
            #endregion

            Console.WriteLine("--------------------------------ORDENANDO CRESCENTE POR NOME----------------------------------------\n");
            listaPessoas.OrderBy(x => x.Nome).ToList()
                .ForEach(x => Console.WriteLine($"Id: {x.Id}  Nome: {x.Nome}  Nascimento: {x.Nascimento.ToShortDateString()}  Carteira: {x.Carteira.ToString("C2")}"));
            Console.WriteLine("\n\n------------------------------------ORDENANDO DECRESCENTE NASCIMENTO----------------------------------------\n");
            listaPessoas.OrderByDescending(x => x.Nascimento).ToList()
                .ForEach(x => Console.WriteLine($"Id: {x.Id}  Nome: {x.Nome}  Nascimento: {x.Nascimento.ToShortDateString()}  Carteira: {x.Carteira.ToString("C2")}"));
            Console.WriteLine("\n\n----------------------------------------QUEM TEM MAIS DE R$ 500,00--------------------------------------\n");
            listaPessoas.FindAll(x => x.Carteira > 500).OrderBy(x => x.Nome).ToList()
                .ForEach(x => Console.WriteLine($"Id: {x.Id}  Nome: {x.Nome}  Nascimento: {x.Nascimento.ToShortDateString()}  Carteira: {x.Carteira.ToString("C2")}"));
            Console.WriteLine("\n\n---------------------------------PESSOAS COM MAIS DE 18 ANOS--------------------------------------\n");

        
            foreach (var pessoa in listaPessoas)
            {
                TimeSpan idade = DateTime.Now - pessoa.Nascimento;
                if (idade.Days/365 > 18)
                Console.WriteLine($"Id: {pessoa.Id}  Nome: {pessoa.Nome}  Idade:{idade.Days/365}");
              
            }
            Console.WriteLine("\n\n-------------------------------PESSOAS COM MENOS DE 16 ANOS----------------------------------------------\n");
            foreach (var pessoa in listaPessoas)
            {
                TimeSpan idade = DateTime.Now - pessoa.Nascimento;
                if (idade.Days/365 < 16)
                    Console.WriteLine($"Id: {pessoa.Id}  Nome: {pessoa.Nome}  Idade:{idade.Days / 365}");

            }
            Console.ReadKey();
        }
    }
}
