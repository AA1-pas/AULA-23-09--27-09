using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaCarrosBiblioteca.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader read = new StreamReader("C:\\Users\\900063\\OneDrive\\Treinamento HBSIS\\DadosVendasCarros.csv", false))
            {
                List<Carro> listaVendaCarros = new List<Carro>();
                int cont = 1;
                string linha = string.Empty;
                while (cont == 1)
                {
                    List<string> dados = new List<string>();
                    linha = read.ReadLine();
                    if (linha == null)
                        cont = 0;
                    else
                    {
                        dados = linha.Split(';').ToList();

                        int d = Convert.ToInt32(dados[0]);
                        listaVendaCarros.Add(new Carro()
                        {
                            Id = int.Parse(dados[0]),
                            
                        });
                    }

                }

            }
            Console.WriteLine("Importação realizada com sucesso!!!");
        }
    }
}
