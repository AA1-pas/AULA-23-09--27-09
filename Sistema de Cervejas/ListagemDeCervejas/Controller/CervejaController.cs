using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContex cervejaContext = new SistemaCervejaContex();

        /// <summary>
        /// Metodo que retona todas as informações da lista
        /// </summary>
        /// <returns>Retorna a lista "cervejas" completa</returns>
        public List<Cerveja> GetListaCervejas ()
        {
            return cervejaContext.cervejas;
        }

        /// <summary>
        /// Metodo para diciona um item cerveja:
        /// Nome = Nome da cerveja
        /// Litros = Quantidade da cerveja em litros
        /// Alcool = Teor alcolico da cerveja
        /// Valor = Valor da cerveja
        /// </summary>
        /// <param name="parametroAdd">Recebe os dados para cadastro conforme o objeto Cerveja</param>
        public void GetAdicionaCerveja(Cerveja parametroAdd )
        {
            parametroAdd.Id = cervejaContext.contador++;
            cervejaContext.cervejas.Add(parametroAdd);
           
        }

        /// <summary>
        /// Metodo que retorna o total da soma de todos o valores de cerveja
        /// </summary>
        /// <returns>Retorna um valor total</returns>
        public double GetRetornaValorTotal()
        {
            return cervejaContext.cervejas.Sum(x => x.Valor);
        }
        
        
        /// <summary>
        /// Metodo que retorna o total da soma de todos o valores de cerveja
        /// </summary>
        /// <returns>Retorna um valor total</returns>
        public double GetRetornaLitrosTotal()
        {
            return cervejaContext.cervejas.Sum(x => x.Litros);
        }

        /// <summary>
        /// Metodo retorna o valor de alcool no sangue 
        /// </summary>
        /// <param name="peso">Solicita o valor do peso</param>
        /// <returns>Retorna o valor de gramas de alcol/litro de sangue</returns>
        public double GetRetornaTeorAlcoolSanguel(int peso)
        {
            return cervejaContext.cervejas.Sum(x => (x.Litros * x.Alcool * 0.8) / (peso * 0.06125));
      
        }
    }
}
