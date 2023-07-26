using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MoneyCurrencyAPI.Domain.Entities
{
    [Serializable()]
    [XmlRoot(ElementName = "Tarih_Date")]
    public class TarihDate
    {
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "Tarih")]
        public string Tarih { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }

        [XmlAttribute(AttributeName = "Bulten_No")]
        public string BultenNo { get; set; }

        [XmlElement(ElementName = "Currency")]
        public List<Currency> Currency { get; set; }


    }
}
