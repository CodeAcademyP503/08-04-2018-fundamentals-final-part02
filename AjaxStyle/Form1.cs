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
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public Form1()
        {
            InitializeComponent();
            dict.Add("Azerbaycan", new List<string>() { "Baki", "Quba", "Sabirabad", "Susa" });
            dict.Add("Turkiye", new List<string>() { "Ankara", "Izmir", "Adana", "Kayseri" });
            dict.Add("Rusya", new List<string>() { "Moskva", "Leningrad", "Sibir"});
            dict.Add("Gurcustan", new List<string>() { "Batumi", "Borcali", "Tbilisi", "Marneuli" });

            foreach (KeyValuePair<string, List<string>> country in dict)
            {
                var combo = new ComboBox();
                var label = new Label();
                combo.Top = count;
                label.Left = 50;
                label.Top = count;
                combo.Left = 200;

                count += combo.Height + 10; ;
                label.Text = country.Key;
                foreach (var city in country.Value)
                {
                    combo.Items.Add(city);
                }
                Controls.Add(combo);
                Controls.Add(label);
            }

        }
    }
}
