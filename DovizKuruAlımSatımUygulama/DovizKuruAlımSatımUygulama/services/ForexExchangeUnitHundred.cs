using DovizKuruAlımSatımUygulama.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAlımSatımUygulama.services
{
    public class ForexExchangeUnitHundred : IExchange
    {
        public decimal Exchange(decimal from, decimal to, decimal amount)
        {
            return ((from/to))*(amount/100);
        }
    }
}
