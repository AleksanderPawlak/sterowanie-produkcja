﻿using System;
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
using Wyznaczanie_Optymalnej_Trasy.Forms;
using Wyznaczanie_Optymalnej_Trasy.Structures;
using Wyznaczanie_Optymalnej_Trasy.Algorithms.utils;

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
            LoadCarsListview();
        }

        protected override void OnClosed(EventArgs e)
        {
            data.SaveData();
            base.OnClosed(e);
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
                data,
                selectedNames,
                new Distance(data.getSpecifiedDurations(selectedNames)),
                new Distance(data.getSpecifiedDistances(selectedNames)),
                new SA_Result()
                );

            var form = new OptimalizationResultForm(result.optimal_road, allNames);
            form.Show();
        }

        static string AddressIntToString(int value)
        {
            return value != 0 ? value.ToString() : "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadCarsListview()
        {
            List<Car> carsList = data.AllCarsList();
            this.carsListView.Items.Clear();
            this.carsListView.Items.Clear();

            foreach (Car car in carsList)
            {
                string[] row = {
                    car.model,
                    car.brand,
                    car.kmCost.ToString(),
                    car.carCost.ToString()
                };
                var listviewItem = new ListViewItem(row);
                this.carsListView.Items.Add(listviewItem);
            }
        }


        private void AddCarButton_Click(object sender, EventArgs e)
        {
            var form = new CarForm(ref data);
            form.FormClosed += delegate {
                ActiveAddForm = false;
                LoadCarsListview();
            };
            form.Show();
        }

        private void computeCarFleetAlgorithmButton_Click(object sender, EventArgs e)
        {
            int weeksNumber = Convert.ToInt32(this.weeksNumberNumericUpDown.Value.ToString());
            float penalty, hourRate;

            try
            {
                penalty = float.Parse(this.penaltyInput.Text.ToString());
                hourRate = float.Parse(this.hourRateInput.Text.ToString());
            }
            catch (System.FormatException)
            {
                IncorrectValuesMessageBox("Upewnij się, że podałeś wartość liczbową.");
                return;
            }

            CarFleetExpansionAlgorithm.Result decision = CarFleetExpansionAlgorithm.getDecision(
                weeksNumber,
                hourRate,
                penalty,
                new DataCopy(data)
                );

            string msg;

            if (decision.carShouldBeBuyed)
                msg = "Opłaca się kupić samochód: \n" + decision.carType.ToString() + 
                    "\n Koszt zwróci się za " + decision.numberOfWeeks + " tygodni.";
            else
                msg = "Przy aktualnej liczbie zamówień i samochodów " +
                    "nie opłaca się rozszerzać floty samochodowej";
            
            string caption = "Wynik obliczeń";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(msg, caption, buttons);
        }

        private void IncorrectValuesMessageBox(string msg)
        {
            string caption = "Niepoprawne dane wejściowe";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(msg, caption, buttons);
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
