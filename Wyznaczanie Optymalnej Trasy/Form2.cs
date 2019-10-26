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
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
