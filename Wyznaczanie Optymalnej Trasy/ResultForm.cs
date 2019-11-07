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
        private Sequence Result;
        private List<Address> Addresses;

        public ResultForm(Sequence result, List<Address> addresses)
        {
            Result = result;
            Addresses = addresses;
            InitializeDynamicContent();
            InitializeComponent();
        }
    }
}
