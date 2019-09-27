using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContex
    {
        public List<Cerveja> ListaCervejas { get; set; }
        public int IdContador { get; set; } = 1;

        /// <summary>
        /// Metodo construtor que adiciona 5 item
        /// </summary>
        public SistemaCervejaContex()
        {
            ListaCervejas = new List<Cerveja>();

           ListaCervejas.Add(new Cerveja() { Id = IdContador++, Nome = "SubZero", Alcool = 4.1, Litros = 0.6, Valor = 10.50 });
           ListaCervejas.Add(new Cerveja() { Id = IdContador++, Nome = "Skol", Alcool = 4.5, Litros = 0.6, Valor = 12.00 });
           ListaCervejas.Add(new Cerveja() { Id = IdContador++, Nome = "Budweiser", Alcool = 5.0, Litros = 0.35, Valor = 3.69 });
           ListaCervejas.Add(new Cerveja() { Id = IdContador++, Nome = "Corona", Alcool = 5.5, Litros = 0.3, Valor = 4.89 });
           ListaCervejas.Add(new Cerveja() { Id = IdContador++, Nome = "Original", Alcool = 4.9, Litros = 0.6, Valor = 14.30 });
        }

             
    }
}
