using DovizKuruAlımSatımUygulama.interfaces;
using DovizKuruAlımSatımUygulama.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAlımSatımUygulama.services
{
    public class ForexManagerTwo
    {
        IExchange exchangeService;

        public ForexManagerTwo(IExchange ex)
        {
            exchangeService = ex;
        }

        public decimal Exchange(ForexModel from,ForexModel to,decimal amount, ForexType type)
        {
           return exchangeService.Exchange(decimal.Parse(from.ForexSelling), decimal.Parse(to.ForexSelling), amount);
        }
    }
}
