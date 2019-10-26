using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wyznaczanie_Optymalnej_Trasy;

namespace Wyznaczanie_Optymalnej_Trasy
{
    public partial class Form1 : Form
    {
        private Data data;
        public Form1()
        {
            InitializeComponent();
            data = new Data();
            Load_CustomerListview();
        }

        private void Load_CustomerListview()
        {
            foreach (Customer customer in data.CustomersList)
            {
                string[] row = {
                    customer.Name, 
                    customer.Coordinates.Latitude.ToString(), 
                    customer.Coordinates.Longitude.ToString(),
                    customer.Street,
                    customer.BuildingNumber.ToString(),
                    customer.HouseNumber.ToString(),
                    customer.ZipCode,
                    customer.City
                };
                var listviewItem = new ListViewItem(row);
                this.CustomerListview.Items.Add(listviewItem);
            }
        }
    }
}
