using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MyModel.Accounts;
using MyModel.Interfaces;

namespace MyModel
{
    public class Exchange : ICursManager
    {
        public static readonly Dictionary<string, decimal> ExchangeToMDL = new Dictionary<string, decimal>();

        private void LoadRate()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://www.bnm.org/ro/official_exchange_rates?get_xml=1&date=" + $"{DateTime.Now:dd.MM.yyyy}");

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();

                    if (receiveStream != null)
                        using (StreamReader readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet)))
                        {
                            string data = readStream.ReadToEnd();
                            XmlDocument xml = new XmlDocument();
                            xml.LoadXml(data);

                            XmlNodeList xnList = xml.SelectNodes("/ValCurs/Valute");
                            if (xnList != null)
                                foreach (XmlNode xn in xnList)
                                {
                                    string currencyType = xn["CharCode"]?.InnerText;
                                    string value = xn["Value"]?.InnerText;

                                    if (currencyType != null && Enum.IsDefined(typeof(CurrencyTypes), currencyType))
                                    {
                                        ExchangeToMDL.Add(currencyType, Convert.ToDecimal(value));
                                    }
                                }
                            else
                            {
                                throw new Exception("Error parsing Exchange rate from BNM");
                            }
                        }
                    else
                    {
                        throw new Exception("Recieved Stream is null");
                    }
                }
            }
        }

        public decimal CurrencyConvert(CurrencyTypes currency1, CurrencyTypes currency2, decimal ammount)
        {
            LoadRate();
            ExchangeToMDL.Add("MDL",1);

            if (!ExchangeToMDL.Any()) throw new Exception("Exchange rate was not loaded");
            if (currency1 == currency2) return ammount;

            return ExchangeToMDL[currency1.ToString()] * ammount / ExchangeToMDL[currency2.ToString()];
        }
    }
}
