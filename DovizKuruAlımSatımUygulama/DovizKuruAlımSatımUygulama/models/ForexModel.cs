using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAlımSatımUygulama.models
{
    public class ForexModel
    {
        public string CurrencyName { get; set; }
        public string ForexSelling { get; set; }
        public string ForexBuying { get; set; }
        public string EffectiveBankNoteSelling { get; set; }
        public string EffectiveBankNoteBuying { get; set; }
        public string CurrencyCode { get; set; }
        public string Unit { get; set; }

    }
}
