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
using static System.Windows.Forms.ListView;
using Simulated_annealing;

namespace Wyznaczanie_Optymalnej_Trasy
{
    public partial class Form1 : Form
    {
        private Data data;
        // TODO: handle situations when add form was opened but adding was not completed
        private bool ActiveAddForm { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
            data = new Data();
            LoadHomeAddressListview();
            Load_CustomerListview();
        }

        private void LoadHomeAddressListview()
        {
            string[] row = {
                    data.HomeAddress.Coordinates.Latitude.ToString(),
                    data.HomeAddress.Coordinates.Longitude.ToString(),
                    data.HomeAddress.Street,
                    AddressIntToString(data.HomeAddress.BuildingNumber),
                    AddressIntToString(data.HomeAddress.HouseNumber),
                    data.HomeAddress.ZipCode,
                    data.HomeAddress.City
                };
            var listviewItem = new ListViewItem(row);
            this.HomeAddressListView.Items.Add(listviewItem);
        }

        private void Load_CustomerListview()
        {
            this.CustomerListview.Items.Clear();
            this.CustomersListCheck.Items.Clear();

            foreach (Address customer in data.CustomersList)
            {
                string[] row = {
                    customer.Name,
                    customer.Coordinates.Latitude.ToString(),
                    customer.Coordinates.Longitude.ToString(),
                    customer.Street,
                    AddressIntToString(customer.BuildingNumber),
                    AddressIntToString(customer.HouseNumber),
                    customer.ZipCode,
                    customer.City
                };
                string[] rowCopy = new string[row.Length];
                row.CopyTo(rowCopy, 0);
                var listviewItem = new ListViewItem(row);
                var listviewItemCopy = new ListViewItem(rowCopy);
                this.CustomerListview.Items.Add(listviewItemCopy);
                this.CustomersListCheck.Items.Add(listviewItem);
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var form = new AddCustomerForm(ref data);
            form.FormClosed += delegate { 
                ActiveAddForm = false;
                Load_CustomerListview();
            };
            form.Show();
            ActiveAddForm = true;
        }

        private void DimensionsRefreshButton_Click(object sender, EventArgs e)
        {
            data.UpdateDistanceMatrix();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            List<ListViewItem> selected = CustomersListCheck.CheckedItems.OfType<ListViewItem>().ToList();
            List<string> selectedNames = new List<string>(from choice in selected select choice.Text);
            List<string> allNames = new List<string>() { data.HomeAddress.Name };
            allNames.AddRange(selectedNames);
            // TODO: parametrize
            var result = SA.Start_SA(
                100000000,
                0.00001,
                0.9999,
                Convert.ToInt32(this.CarsNumberNumericUpDown.Value.ToString()),
                new Distance(data.getSpecifiedDistances(selectedNames))
                );

            var form = new ResultForm(result, allNames);
            form.Show();
        }

        static string AddressIntToString(int value)
        {
            return value != 0 ? value.ToString() : "";
        }
    }
}
