using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaCarrosBibioteca.Controller;
using VendaCarrosBiblioteca.Model;

namespace VendaCarrosBiclioteca.Controller
{

    public class VendasController
    {
        private VendasContext vendasContextDB = new VendasContext();

        public List<Carro> listaCompleta ()
        {
            return vendasContextDB.listaVendaCarros.OrderBy(x => x.Id).ToList();
        }

    }
}
