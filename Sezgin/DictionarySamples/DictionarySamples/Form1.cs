using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarySamples
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> dictionary;
        private SortedDictionary<string, int> sortedDictionary;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, int>();
            //Alternative Initialize:
            //dictionary = new Dictionary<string, int>()
            //{
            //    {"cat", 2},
            //    {"dog", 1},
            //    {"llama", 0},
            //    {"iguana", -1}
            //};
            dictionary.Add("cat", 2);
            dictionary.Add("dog", 1);
            dictionary.Add("llama", 0);
            dictionary.Add("iguana", -1);

            sortedDictionary = new SortedDictionary<string, int>();
            //sortedDictionary = new SortedDictionary<string, int>()
            //{
            //    { "cat", 2 },
            //    { "dog", 1 },
            //    { "llama", 0 },
            //    { "iguana", -1 }
            //};
            sortedDictionary.Add("cat", 2);
            sortedDictionary.Add("dog", 1);
            sortedDictionary.Add("llama", 0);
            sortedDictionary.Add("iguana", -1);
            //sortedDictionary.Add("bird", 3);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lbListDictionary.Items.Clear();

            if (!cbActivate.Checked)
            {
                lbListDictionary.Items.Add("Dictionary: ");

                foreach (KeyValuePair<string, int> pair in dictionary)
                {
                    lbListDictionary.Items.Add("Key: " + pair.Key + ", Value: " + pair.Value);
                }
            }
            else
            {
                lbListDictionary.Items.Add("Sorted Dictionary: ");

                //if (cbValue.Checked)
                //{
                //    var sortedDictionary2 = sortedDictionary.OrderBy(item => item.Value);
                //}

                foreach (KeyValuePair<string, int> pair in sortedDictionary)
                {
                    lbListDictionary.Items.Add("Key: " + pair.Key + ", Value: " + pair.Value);
                }
            }
        }

        private void btnBringValue_Click(object sender, EventArgs e)
        {
            lbBringValue.Items.Clear();

            if (!cbActivate.Checked)
            {
                lbBringValue.Items.Add("Dictionary: ");

                //This code will cause an error!
                //lbBringValue.Items.Add(dictionary["asdad"]);
                //try
                //{
                //    lbBringValue.Items.Add(dictionary[tbKey.Text]);
                //}
                //catch (KeyNotFoundException)
                //{
                //    MessageBox.Show("Entered key couldn't be found!");
                //}

                int value;
                if (dictionary.TryGetValue(tbKey.Text, out value))
                {
                    lbBringValue.Items.Add(value);
                }
                else
                {
                    MessageBox.Show("Entered key couldn't be found!");
                }
            }
            else
            {
                lbBringValue.Items.Add("Sorted Dictionary: ");

                //This code will cause an error!
                //lbBringValue.Items.Add(sortedDictionary["asdad"]);
                //try
                //{
                //    lbBringValue.Items.Add(sortedDictionary[tbKey.Text]);
                //}
                //catch (KeyNotFoundException)
                //{
                //    MessageBox.Show("Entered key couldn't be found!");
                //}

                int value;
                if (sortedDictionary.TryGetValue(tbKey.Text, out value))
                {
                    lbBringValue.Items.Add(value);
                }
                else
                {
                    MessageBox.Show("Entered key couldn't be found!");
                }
            }
        }

        private void btnUseKeys_Click(object sender, EventArgs e)
        {
            lbUseKeys.Items.Clear();

            if(!cbActivate.Checked)
            {
                lbUseKeys.Items.Add("Dictionary: ");

                List<string> keyList = new List<string>(dictionary.Keys);
                foreach (string key in keyList)
                    lbUseKeys.Items.Add(dictionary[key]);
            }
            else
            {
                lbUseKeys.Items.Add("Sorted Dictionary: ");

                List<string> keyList = new List<string>(sortedDictionary.Keys);
                foreach (string key in keyList)
                    lbUseKeys.Items.Add(sortedDictionary[key]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbRemove.Items.Clear();

            if(!cbActivate.Checked)
            {
                lbRemove.Items.Add("Dictionary: ");

                try
                {
                    dictionary.Remove(tbRemoveKey.Text);
                    foreach(var pair in dictionary)
                    {
                        lbRemove.Items.Add("Key: " + pair.Key + ", Value: " + pair.Value);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("An error occured!");
                }
            }
            else
            {
                lbRemove.Items.Add("Sorted Dictionary: ");

                try
                {
                    sortedDictionary.Remove(tbRemoveKey.Text);
                    foreach (var pair in sortedDictionary)
                    {
                        lbRemove.Items.Add("Key: " + pair.Key + ", Value: " + pair.Value);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured!");
                }
            }
        }
    }
}
