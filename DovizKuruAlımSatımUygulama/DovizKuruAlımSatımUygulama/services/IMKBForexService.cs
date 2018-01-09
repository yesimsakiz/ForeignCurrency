using DovizKuruAlımSatımUygulama.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DovizKuruAlımSatımUygulama.models;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DovizKuruAlımSatımUygulama.services
{
    public class IMKBForexService : IForex
    {
        private List<ForexModel> _forexData;

        public ForexModel GetByCurrencyCode(string code)
        {
            //tek 1 tane para birimi döndür.
          return _forexData.Where(x => x.CurrencyCode == code).Single();
        }

        public List<ForexModel> GetList(string uri)
        {
            XmlDocument doc = new XmlDocument();
             doc.Load(uri);

            //json.net xml dökümanını json formatına çevirebilmek için kütüphanesinde kodlar barındırır.
            var json = JsonConvert.SerializeXmlNode(doc);

            //JObject,JArray,JValue =>

            //JObject = > json string i json nesnesine parse eder
            //JArray => json string i json dizisine parse eder
            //JValue ise json string i value parse
            //JToken eğer çevrilecek değer karmaşık bir modele sahip ise JObject,JArray veya JValue dan birini tercih etmek de zorlanıyorsak bu durum da JToken herhangi bir tipte verilerimizin Json objesi olarak çevrilmesini söyleyebiliriz.

            JToken data = JToken.Parse(json);
            JArray arr = (JArray)data.SelectToken("Tarih_Date").SelectToken("Currency");

            //dizinin her bir objesini alıp tek tek modelimize mapledik. (haritalama)
            List<ForexModel> model = arr.Select(a => new ForexModel
            {
                CurrencyCode = a.Value<string>("@CurrencyCode"),
                CurrencyName = a.Value<string>("CurrencyName"),
                ForexBuying = a.Value<string>("ForexBuying"),
                ForexSelling = a.Value<string>("ForexSelling"),
                EffectiveBankNoteBuying = a.Value<string>("BanknoteBuying"),
                EffectiveBankNoteSelling = a.Value<string>("BanknoteSelling"),
                Unit = a.Value<string>("Unit")

            }).ToList();

            _forexData = model;

            return model;

        }
    }
}
