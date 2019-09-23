using CestaDeFrutas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            cestaDeFrutas.Add(new Fruta()
            {
                Id =1,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX1: Id: {i.Id}   Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX2: Id: {i.Id}   Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            cestaDeFrutas.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX3: Id: {i.Id}   Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX4: Id: {i.Id}   Nome: {i.Nome}   Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            var filtroCesta = cestaDeFrutas.Where(X => X.Peso > 100);
            filtroCesta.ToList<Fruta>()
                .ForEach(i => Console.WriteLine($"EX5: Id: {i.Id}  Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            cestaDeFrutas.Where(X => X.Peso > 100).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX6: Id: {i.Id}  Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            cestaDeFrutas.Where(X => X.Peso > 100).OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX7: Id: {i.Id}  Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            (from frutinha in cestaDeFrutas
                              where frutinha.Nome == "Manga"
                              select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"EX8:Id: {i.Id}  Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            #region Como sumir com tudo
            //RETORNA 1 SÓ ITEM ENCONTRADO
            var montrandoFind = cestaDeFrutas.Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"EX9: Id {montrandoFind.Id}   Nome: {montrandoFind.Nome} Peso: {montrandoFind.Peso}");
            Console.WriteLine("---------------------------");

            //RETORNA A COLEÇÃO
            var montrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            montrandoFindAll.ForEach(i => Console.WriteLine($"EX10: Id {i.Id}   Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");

            var montrandoFindAll2 = cestaDeFrutas.FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho").OrderBy(i => i.Nome);
            montrandoFindAll2.ToList<Fruta>().ForEach(i => Console.WriteLine($"EX11: Id {i.Id}   Nome: {i.Nome}  Peso: {i.Peso}"));
            Console.WriteLine("---------------------------");


            // como montrandoFindAll2 não é mais list podemos fazer dessa maneira com o foreach
            foreach (var item in montrandoFindAll2)
            {
                Console.WriteLine($"EX12: Id {item.Id}   Nome: {item.Nome}  Peso: {item.Peso}");
            }
            -
            Console.WriteLine("---------------------------");


            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id: {cestaDeFrutasFindOrder.Id}  Nome: {cestaDeFrutasFindOrder.Nome}  Peso: {cestaDeFrutasFindOrder.Peso}");
            #endregion


            Console.ReadKey();
        }
    }
}
