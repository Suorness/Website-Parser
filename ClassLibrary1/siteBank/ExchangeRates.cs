using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParserLib.siteBank
{
   //[Serializable]
   public class ExchangeRates
    {
        //[JsonProperty("CurrencyName")]
        public string CurrencyName { get; set; }
        //[JsonProperty("CurrencyValue")]
        public string CurrencyValue { get; set; }

        public ExchangeRates(string value,string name)
        {
            CurrencyName = name;
            CurrencyValue = value;
        }
        public ExchangeRates()
        {

        }
        public override string ToString()
        {
            return string.Format("{0} = {1}", CurrencyName.Trim(), CurrencyValue.Trim());

        }
    }
}
