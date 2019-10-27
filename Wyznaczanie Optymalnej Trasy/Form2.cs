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

        private void MissingValuesMessageBox()
        { 
            //TODO display box with "OK" and message about missing values...
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.NameBox.Text))
            {
                MissingValuesMessageBox();
            }

            if (!this.CoordinatesBoxes.All(box => string.IsNullOrWhiteSpace(box.Text)))
            {
                data.AddCustomer(
                    this.NameBox.Text, Convert.ToDecimal(this.LatBox.Text), Convert.ToDecimal(this.LocalBox.Text)
                    );
                this.Close();
            }
            else if (this.AddressBoxes.All(box => string.IsNullOrWhiteSpace(box.Text)))
            {
                MissingValuesMessageBox();
            }
            else
            {
                //TODO: Pass Adrress data
                MissingValuesMessageBox();
            }
        }
    }
}
