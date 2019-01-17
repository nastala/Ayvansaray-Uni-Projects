using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Veri_Isleme_Mondial
{
    class Country
    {
        public string ID { get; set; }
        public string CountryName { get; set; }
        public double Population { get; set; }
        public string DataCode { get; set; }
        public double TotalArea { get; set; }
        public double PopulationGrowth { get; set; }
        public double InfantMortality { get; set; }
        public double GDPAgri { get; set; }
        public double GDPTotal { get; set; }
        public double Inflation { get; set; }
        public DateTime IndepDate { get; set; }
        public string Government { get; set; }

        internal IEnumerable<string> GetCities(XmlDocument xmlDoc)
        {
            string path = "mondial/country/city[@country='" + ID + "']";
            XmlNodeList nodeList = xmlDoc.SelectNodes(path);
            foreach (XmlNode node in nodeList)
            {
                string cityName = node.ChildNodes[0].InnerText.Replace("\n", "").Trim();
                Cities.Add(new City(node));
                yield return cityName;
            }
        }

        public string CarCode { get; set; }
        public List<City> Cities { get; set; }

        public Country(XmlNode node)
        {
            Cities = new List<City>();
            ID = node.Attributes["id"].InnerText;
            CountryName = node.Attributes["name"].InnerText;

            var population = node.Attributes["population"];
            if (population != null && population.InnerText != null)
                Population = double.Parse(population.InnerText.Replace(" ", ""));

            var dataCode = node.Attributes["datacode"];
            if (dataCode != null && dataCode.InnerText != null)
                DataCode = dataCode.InnerText;

            TotalArea = double.Parse(node.Attributes["total_area"].InnerText);

            var populationGrowth = node.Attributes["population_growth"];
            if (populationGrowth != null && populationGrowth.InnerText != null)
                PopulationGrowth = double.Parse(populationGrowth.InnerText);

            var infantMortality = node.Attributes["infant_mortality"];
            if (infantMortality != null && infantMortality.InnerText != null)
                InfantMortality = double.Parse(infantMortality.InnerText);

            var gdpAgri = node.Attributes["gdp_agri"];
            if (gdpAgri != null && gdpAgri.InnerText != null)
                GDPAgri = double.Parse(gdpAgri?.InnerText);
            var gdpTotal = node.Attributes["gdp_total"];
            if (gdpTotal != null && gdpTotal.InnerText != null)
                GDPTotal = double.Parse(gdpTotal.InnerText);

            var inflation = node.Attributes["inflation"];
            if (inflation != null && inflation.InnerText != null)
                Inflation = double.Parse(inflation.InnerText);

            var indepDate = node.Attributes["indep_date"];
            if (indepDate != null && indepDate.InnerText != null)
                IndepDate = DateTime.Parse(indepDate.InnerText);

            Government = node.Attributes["government"].InnerText;

            var carCode = node.Attributes["car_code"];
            if (carCode != null && carCode.InnerText != null)
                CarCode = carCode.InnerText;
        }
    }
}
