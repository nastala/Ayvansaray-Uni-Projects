using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Veri_Isleme_Mondial
{
    class City
    {
        public string ID { get; set; }
        public string CountryID { get; set; }
        public string Name { get; set; }
        public double Population { get; set; }
        public int Year { get; set; }

        public City(XmlNode node)
        {
            var id = node.Attributes["id"];
            if (id != null && id.InnerText != null)
                ID = id.InnerText;

            var country = node.Attributes["country"];
            if (country != null && country.InnerText != null)
                CountryID = country.InnerText;

            var name = node.ChildNodes[0];
            if (name != null && name.InnerText != null)
                Name = name.InnerText.Replace("\n", "").Trim();

            XmlNode population = null;
            foreach (XmlNode innerNode in node.ChildNodes)
            {
                if (innerNode.Name == "population")
                {
                    population = innerNode;
                    break;
                }
            }
            if (population != null && population.InnerText != null)   
            {
                Population = double.Parse(population.InnerText.Replace(" ", ""));

                
                var year = population.Attributes["year"];
                if (year != null && year.InnerText != null)
                    Year = int.Parse(year.InnerText);
            }

            
        }
    }
}
