using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContex
    {
        public List<Cerveja> cervejas { get; set; }
        public int contador { get; set; } = 1;

        /// <summary>
        /// Metodo construtor que adiciona 5 item
        /// </summary>
        public SistemaCervejaContex()
        {
            cervejas = new List<Cerveja>();

           cervejas.Add(new Cerveja() { Id = contador++, Nome = "Kaiser", Alcool = 4.1, Litros = 0.6, Valor = 10.50 });
           cervejas.Add(new Cerveja() { Id = contador++, Nome = "Skol", Alcool = 4.5, Litros = 0.6, Valor = 12.00 });
           cervejas.Add(new Cerveja() { Id = contador++, Nome = "Budweiser", Alcool = 5.0, Litros = 0.35, Valor = 3.69 });
           cervejas.Add(new Cerveja() { Id = contador++, Nome = "Corona", Alcool = 5.5, Litros = 0.3, Valor = 4.89 });
           cervejas.Add(new Cerveja() { Id = contador++, Nome = "Original", Alcool = 4.9, Litros = 0.6, Valor = 14.30 });
        }

             
    }
}
