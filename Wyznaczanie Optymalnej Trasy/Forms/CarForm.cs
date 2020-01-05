using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wyznaczanie_Optymalnej_Trasy.Structures;

namespace Wyznaczanie_Optymalnej_Trasy.Forms
{
    public partial class CarForm : Form
    {
        private Data data;

        public CarForm(ref Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void IncorrectValuesMessageBox(string msg)
        {
            string caption = "Niepoprawne dane wejściowe";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(msg, caption, buttons);
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextBox[] boxes = new TextBox[] { 
                this.modelTextBox, this.brandTextBox, this.carCostTextBox, this.kmCostTextBox
            };

            if (!boxes.All(box => string.IsNullOrWhiteSpace(box.Text))){
                float carCost = float.Parse(this.carCostTextBox.Text);
                float kmCost = float.Parse(this.kmCostTextBox.Text);
                string model = this.modelTextBox.Text;
                string brand = this.brandTextBox.Text;
                Car car = new Car(model, brand, kmCost, carCost, 0);

                data.AddCar(car);
                this.Close();
            }
            else {
                IncorrectValuesMessageBox(
                    "Nie uzupełniono wszystkich wymaganych pól.\n" +
                    "Upewnij się, że uzupełniono koordynaty lub adres."
                );
            }
        }
    }
}
