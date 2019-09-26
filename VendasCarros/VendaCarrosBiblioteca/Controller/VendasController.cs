using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaCarrosBiblioteca.Model;

namespace VendaCarrosBiblioteca.Controller
{
     public class VendasController
    {
        public VendasContext vendasContextDB = new VendasContext();

        /// <summary>
        /// Metodo retorna lista completa de carros vendidos ordenada pela data de venda
        /// </summary>
        /// <returns></returns>
       public List<Carro> ListaCompleta()
       {
           return vendasContextDB.ListaDeVendasPublica;
       }

        /// <summary>
        /// Metodo retorno uma lista com filtro do mes de venda
        /// </summary>
        /// <param name="mesFiltro">Informa como parametro o mes para filtrar</param>
        /// <returns></returns>
        public List<Carro> RetornaListaFiltroMes(int mesFiltro=0)
        {
            if (mesFiltro == 0)
                return vendasContextDB.ListaDeVendasPublica;
            return vendasContextDB.ListaDeVendasPublica.FindAll(x => x.DataVenda.Month == mesFiltro);
        }


   
    }
}
