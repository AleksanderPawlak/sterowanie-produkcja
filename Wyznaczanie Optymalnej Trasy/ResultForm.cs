using Simulated_annealing;
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
    public partial class ResultForm : Form
    {
        // TODO: simplify structure and change structures
        private Sequence Result;
        private List<Address> AddressesNames;
        List<List<string>> resultAddressesNames = new List<List<string>>();

        public ResultForm(Sequence result, List<Address> addressesNames)
        {
            Result = result;
            AddressesNames = addressesNames;
            InitializeComponent();
            InitializeDynamicContent();
            InitializeMap();
        }
    }
}
