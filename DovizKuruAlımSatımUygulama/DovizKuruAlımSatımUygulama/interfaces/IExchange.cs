using DovizKuruAlımSatımUygulama.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAlımSatımUygulama.interfaces
{
    public interface IExchange
    {
        decimal Exchange(decimal from, decimal to, decimal amount);
    }
}
