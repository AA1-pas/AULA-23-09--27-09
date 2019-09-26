using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{
    
    public class CarroController
    {
        SistemaCarrosContext listaCarrosContext = new SistemaCarrosContext();

        /// <summary>
        /// Metodo que retorna nossa lista de carros completa
        /// </summary>
        /// <returns>Retorna nossa lista de carro</returns>
        public List<Carro> GetCarros ()
        {
            return listaCarrosContext.listaCarros;
        }
    }
}
