using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController carroController =  new CarroController();
        static void Main(string[] args)
        {
            carroController.GetCarros().ForEach(i => Console.WriteLine($"{i.Id} - {i.Marca} - {i.Modelo} - {i.Ano} - {i.Cilindradas} - {i.Portas}"));
            Console.ReadLine();
        }
    }
}
