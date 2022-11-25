using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class CartaoDeCredito
    {
        public string Numero { get; set; }

        public string DataDeValidade { get; set; }

        //agregação do cliente | referenciando outra class
        public Cliente Cliente { get; set; } //para qual cliente é esse cartao de credito





    }
}
