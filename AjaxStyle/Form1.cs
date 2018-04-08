using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjaxStyle
{
    public partial class Form1 : Form
    {
        public int count = 50;
        public string SelectedItem;
        public ComboBox combo=new ComboBox();
        public ComboBox cities = new ComboBox();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public Form1()
        {
            InitializeComponent();
            dict.Add("Azerbaycan", new List<string>() { "Baki", "Quba", "Sabirabad", "Susa" });
            dict.Add("Turkiye", new List<string>() { "Ankara", "Izmir", "Adana", "Kayseri" });
            dict.Add("Rusiya", new List<string>() { "Moskva", "Leningrad", "Sibir"});
            dict.Add("Gurcustan", new List<string>() { "Batumi", "Borcali", "Tbilisi", "Marneuli" });
          
            foreach (KeyValuePair<string, List<string>> country in dict)
            {
                
                
                //var label = new Label();
                combo.Top = 50;
                //label.Left = 50;
                //label.Top = count;
                combo.Left = 50;
                //count += combo.Height + 10;
                combo.Items.Add(country.Key);
                Controls.Add(combo);
                //label.Text = country.Key;
                //foreach (var city in country.Value)
                //{
                //    combo.Items.Add(city);
                //}

                //Controls.Add(label);
            }
            combo.SelectionChangeCommitted += new EventHandler(GetCities);
            

        }
        public void GetCities(object obj,EventArgs e)
        {
            SelectedItem = combo.SelectedItem.ToString();
            cities.Items.Clear();
            cities.Left = combo.Left + 150;
            cities.Top = combo.Top;
            foreach (KeyValuePair<string, List<string>> country in dict)
            {
                
                if (country.Key == SelectedItem)
                {
                    foreach (var item in country.Value)
                    {
                        
                        cities.Items.Add(item);
                        Controls.Add(cities);
                        
                    }
                }
            }

        }
    }
}
