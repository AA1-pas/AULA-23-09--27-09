using ListagemDeCarros.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarroController carro = new CarroController();
            carro.GetCarros().ForEach(i => Console.WriteLine(i.Ano));
        }
    }
}
