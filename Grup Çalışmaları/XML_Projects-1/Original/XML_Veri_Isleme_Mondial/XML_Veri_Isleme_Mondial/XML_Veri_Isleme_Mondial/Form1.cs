using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_Veri_Isleme_Mondial
{
    public partial class Form1 : Form
    {
        private readonly string _filePath = @"E:\XML_Veri_Isleme_Mondial\XML_Veri_Isleme_Mondial\XML_Veri_Isleme_Mondial\mondial-3.0.xml";
        private readonly XmlDocument _xmlDoc = new XmlDocument();
        private List<Country> _countries;
        private List<Sea> _seas;

        public Form1()
        {
            InitializeComponent();
            _xmlDoc.Load(_filePath);
            _countries = new List<Country>();
            _seas = new List<Sea>();
            LoadCountries();
            LoadCities();
            LoadSeas();
        }

        private void LoadSeas()
        {
            var nodes = _xmlDoc.SelectNodes("/mondial/sea");

            foreach (XmlNode node in nodes)
            {
                Sea sea = new Sea(node);
                sea.GetCountries(_xmlDoc);
                _seas.Add(sea);
            }
        }

        private void LoadCities()
        {
            foreach (var country in _countries)
            {
                TreeNode root = new TreeNode(country.CountryName);

                tvCountriesAndCities.Nodes.Add(root);

                foreach (var city in country.GetCities(_xmlDoc))
                {
                    root.Nodes.Add(city);
                }
            }
        }

        private void LoadCountries()
        {
            var nodes = _xmlDoc.SelectNodes("/mondial/country");


            foreach (XmlNode node in nodes)
            {
                Country country = new Country(node);
                dgvCountries.Rows.Add(country.CountryName, country.Population, country.DataCode, country.TotalArea, country.PopulationGrowth,
                    country.InfantMortality, country.GDPAgri, country.GDPTotal, country.Inflation, country.IndepDate, country.Government, country.CarCode);
                _countries.Add(country);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchCountry_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_countries.First(x => x.DataCode == tbSearchCountry.Text).CountryName);
        }

        private void FilterByPopulation_Click(object sender, EventArgs e)
        {
            foreach (var country in _countries)
            {
                var cities = country.Cities.Where(city => city.Population > 5000000);
                if (cities.Any())
                {
                    foreach (var city in cities)
                    {
                        dgvFilteredCities.Rows.Add(city.Name, city.Population, country.CountryName);
                    }
                }
            }

        }

        private void FilterBySeaNames_Click(object sender, EventArgs e)
        {
            lbFilterBySeaNames.Items.Clear();
            var seas = _seas.Where(sea => sea.Name.StartsWith("S"));
            HashSet<string> allIDs = new HashSet<string>();
            foreach (var sea in seas)
            {
                var ids = sea.CountryIDs;
                foreach (var id in ids)
                {
                    if (allIDs.Contains(id) == false)
                        allIDs.Add(id);
                }
            }
            var countries = _countries.Where(country => allIDs.Contains(country.ID));
            lbFilterBySeaNames.Items.AddRange(countries.Select(c => c.CountryName).ToArray());
        }

        private void FilterByCountryAndCityNames_Click(object sender, EventArgs e)
        {
            lbFilterByCountryAndCityNames.Items.Clear();
            var countries = _countries.Where(country => country.CountryName.StartsWith("C"));
            foreach (var country in countries)
            {
                var cities = country.Cities.Where(city => city.Name.StartsWith("A"));
                lbFilterByCountryAndCityNames.Items.AddRange(cities.Select(city => city.Name).ToArray());
            }
        }
    }
}
