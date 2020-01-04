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
    public partial class MainForm : Form
    {
        private Data data;
        // TODO: handle situations when add form was opened but adding was not completed
        private bool ActiveAddForm { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
            data = new Data();
            LoadHomeAddressListview();
            Load_CustomerListview();
        }

        private void LoadHomeAddressListview()
        {
            Address homeAddress = data.HomeAddress();

            string[] row = {
                    homeAddress.addressCoordinates.latitude.ToString(),
                    homeAddress.addressCoordinates.longitude.ToString(),
                    homeAddress.street,
                    AddressIntToString(homeAddress.buildingNumber),
                    AddressIntToString(homeAddress.houseNumber),
                    homeAddress.zipCode,
                    homeAddress.city
                };
            var listviewItem = new ListViewItem(row);
            this.HomeAddressListView.Items.Add(listviewItem);
        }

        private void Load_CustomerListview()
        {
            List<Address> customersList = data.AllCustomers();
            this.CustomerListview.Items.Clear();
            this.CustomersListCheck.Items.Clear();

            foreach (Address customer in customersList)
            {
                string[] row = {
                    customer.name,
                    customer.addressCoordinates.latitude.ToString(),
                    customer.addressCoordinates.longitude.ToString(),
                    customer.street,
                    AddressIntToString(customer.buildingNumber),
                    AddressIntToString(customer.houseNumber),
                    customer.zipCode,
                    customer.city
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
            Address homeAddress = data.HomeAddress();
            List<Address> customersList = data.AllCustomers();

            List<ListViewItem> selected = CustomersListCheck.CheckedItems.OfType<ListViewItem>().ToList();
            List<string> selectedNames = new List<string>(from choice in selected select choice.Text);
            List<Address> allNames = new List<Address>() { homeAddress };
            allNames.AddRange(customersList.Where(x => selectedNames.Contains(x.name)));
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
