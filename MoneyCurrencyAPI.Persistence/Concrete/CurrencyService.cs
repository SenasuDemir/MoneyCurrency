using MoneyCurrencyAPI.Application.Absraction;
using MoneyCurrencyAPI.Domain.Entities;
using System.Xml;

namespace MoneyCurrencyAPI.Persistence.Concrete
{
    public class CurrencyService : ICurrencyService
    {
        public List<Currency> GetCurrencies()
        {

            List<Currency> currency = new List<Currency>();
            try
            {
                string xmlUrl = "https://www.tcmb.gov.tr/kurlar/today.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlUrl);

                using var sr = new StringReader(xmlDoc.InnerXml);
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(TarihDate));
                var response = (TarihDate)serializer.Deserialize(sr);


                EMoneyCurrencyDbContext context = new();
                

                for (int i = 0; i < 12; i++)
                {
                    currency[i].Tarih = response.Tarih;
                    currency[i].Date = response.Date;
                    currency[i].BultenNo = response.BultenNo;
                    currency.Add(response.Currency[i]);
                     context.Add(currency[i]);
                }

               context.SaveChanges();
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            return currency;
        }

        
    }
}
