using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MoneyCurrencyAPI.Domain.Entities
{

    [XmlRoot(ElementName = "Currency")]
    public class Currency
    {
        public int Id { get; set; }

        [XmlElement(ElementName = "Unit")]
        public int Unit { get; set; }

        [XmlElement(ElementName = "Isim")]
        public string Isim { get; set; }

        [XmlElement(ElementName = "CurrencyName")]
        public string CurrencyName { get; set; }

        [XmlElement(ElementName = "ForexBuying")]
        public double ForexBuying { get; set; }

        [XmlElement(ElementName = "ForexSelling")]
        public string ForexSelling { get; set; }

        [XmlElement(ElementName = "BanknoteBuying")]
        public string BanknoteBuying { get; set; }

        [XmlElement(ElementName = "BanknoteSelling")]
        public string BanknoteSelling { get; set; }

        [XmlElement(ElementName = "CrossRateUSD")]
        public string CrossRateUSD { get; set; }

        [XmlElement(ElementName = "CrossRateOther")]
        public string CrossRateOther { get; set; }

        [XmlAttribute(AttributeName = "CrossOrder")]
        public string CrossOrder { get; set; }

        [XmlAttribute(AttributeName = "Kod")]
        public string Kod { get; set; }


        [XmlAttribute(AttributeName = "CurrencyCode")]
        public string CurrencyCode { get; set; }

        public string Tarih { get; set; }

        public string Date { get; set; }

        public string BultenNo { get; set; }


    }
}
