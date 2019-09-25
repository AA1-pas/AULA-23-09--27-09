using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VendasController
    {
        public VendasContext vendasContextDB = new VendasContext();

        public List<Carro> listaCompleta()
        {
            return vendasContextDB.listaVendaCarros.OrderBy(x => x.Id).ToList();
        }
    }
}
