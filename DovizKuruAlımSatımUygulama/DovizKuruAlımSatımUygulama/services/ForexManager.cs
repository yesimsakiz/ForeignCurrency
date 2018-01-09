using DovizKuruAlımSatımUygulama.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAlımSatımUygulama.services
{
    public enum ForexType
    {
        ForexSelling,
        ForexBuying
    }
    public class ForexManager
    {

        public ForexExchangeService service;

        public ForexManager()
        {
            service = new ForexExchangeService();
        }
       
        public decimal Exchange(ForexType type,ForexModel from,ForexModel to,decimal amount)
        {
            decimal result = 0;

            if (type == ForexType.ForexBuying)
            {
                result = service.Exchange(decimal.Parse(from.ForexBuying),decimal.Parse (to.ForexBuying), amount);
            }
            else if (type==ForexType.ForexSelling)
            {
                result =  service.Exchange(decimal.Parse(from.ForexSelling), decimal.Parse(to.ForexSelling), amount);
            }

            return result;

        }

    }
}
