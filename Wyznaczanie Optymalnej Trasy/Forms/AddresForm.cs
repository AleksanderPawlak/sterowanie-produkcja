using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyznaczanie_Optymalnej_Trasy
{
    public partial class AddCustomerForm : Form
    {
        private Data data;
        public AddCustomerForm(ref Data _data)
        {
            data = _data;
            InitializeComponent();
            InitializeAdditional();
        }

        private void IncorrectValuesMessageBox(string msg)
        {
            string caption = "Niepoprawne dane wejściowe";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(msg, caption, buttons);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.NameBox.Text))
            {
                IncorrectValuesMessageBox("Nie uzupelniono wymaganego pola z nazwą.");
            }

            if (!this.CoordinatesBoxes.All(box => string.IsNullOrWhiteSpace(box.Text)))
            {
                try
                {
                    var lat = Convert.ToDecimal(this.LatBox.Text);
                    var len = Convert.ToDecimal(this.LenBox.Text);
                    data.AddCustomer(this.NameBox.Text, lat, len);
                    this.Close();
                }
                catch (FormatException)
                {
                    IncorrectValuesMessageBox(
                        "Niepoprawny format danych wejściowych. " +
                        "Upewnij się, że wartości liczbowe wprowadzono ze znakiem \",\"."
                        );
                }
            }
            else if (this.AddressBoxes.All(box => string.IsNullOrWhiteSpace(box.Text)))
            {
                IncorrectValuesMessageBox(
                    "Nie uzupełniono wszystkich wymaganych pól.\n" + 
                    "Upewnij się, że uzupełniono koordynaty lub adres."
                    );
            }
            else
            {
                //TODO: Pass Adrress data
                IncorrectValuesMessageBox("");
            }
        }

    }
}
