using DovizKuruAlımSatımUygulama.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAlımSatımUygulama.interfaces
{
    public interface IForex
    {
        /// <summary>
        /// Koduna göre döviz kurunun değerlerine ulaşmak için kullandık
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        ForexModel GetByCurrencyCode(string code);
       /// <summary>
       /// Tüm dövizlerin listesi
       /// </summary>
       /// <param name="uri">kaynağın konumu</param>
       /// <returns></returns>
        List<ForexModel> GetList(string uri);
    }
}
