using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
        public double Valor { get; set; }
    }
}
