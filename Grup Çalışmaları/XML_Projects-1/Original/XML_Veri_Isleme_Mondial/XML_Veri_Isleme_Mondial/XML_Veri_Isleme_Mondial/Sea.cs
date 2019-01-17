using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Veri_Isleme_Mondial
{
    class Sea
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Depth { get; set; }
        public HashSet<string> CountryIDs { get; set; }

        public static object GetField(string attributeName, XmlNode node)
        {
            var field = node.Attributes[attributeName];
            if (field != null && string.IsNullOrWhiteSpace(field.InnerText) == false)
            {
                return field.InnerText;
            }
            return null;
        }

        public Sea(XmlNode node)
        {
            CountryIDs = new HashSet<string>();
            ID = (string)GetField("id", node);
            Name = (string)GetField("name", node);

            var depth = GetField("depth", node);
            Depth = depth == null ? 0 : Convert.ToInt32(depth);

        }

        internal void GetCountries(XmlDocument xmlDoc)
        {
            string path = "mondial/sea[@id='" + ID + "']";
            XmlNode node = xmlDoc.SelectSingleNode(path);
            foreach (XmlElement located in node.ChildNodes)
            {
                string countryID = (string)GetField("country", located);
                if (CountryIDs.Contains(countryID) == false)
                    CountryIDs.Add(countryID);
            }
        }
    }
}
