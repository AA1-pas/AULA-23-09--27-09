using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        private List<Carro> ListaDeCarros { get; set; }
        private int contador = 0;
        /// <summary>
        /// Metodo construtor para adicionar itens a lista
        /// </summary>
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 1986, Modelo = "Fusca", Marca = "Volkswagem", Cilindradas = 1500, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 2018, Modelo = "Pajero", Marca = "Mitsubishi", Cilindradas = 3800, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 2010, Modelo = "Jetta", Marca = "Chevrolet", Cilindradas = 2400, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 1977, Modelo = "Corcel 1 GT", Marca = "Ford", Cilindradas = 1500, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 2020, Modelo = "F-250", Marca = "Ford", Cilindradas = 3000, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 2013, Modelo = "Cobalt", Marca = "Volkswagem", Cilindradas = 2000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 1998, Modelo = "Uno", Marca = "Fiat", Cilindradas = 1000, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 2017, Modelo = "Clio", Marca = "Renault", Cilindradas = 1000, Portas = 2 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 2014, Modelo = "J5", Marca = "JAC", Cilindradas = 1600, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = contador++, Ano = 1995, Modelo = "Monza", Marca = "Chevrolet", Cilindradas = 2000, Portas = 4 });


        }

        public List<Carro> listaCarros { get { return ListaDeCarros;} }
       
    }
}
