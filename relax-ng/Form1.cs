using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relax_ng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string result = Validator.ValidateFromURLs("../../example.xml", "../../example.rng");
            //string result = Validator.ValidateFromStrings(txtInstance.Text, txtPattern.Text);
            txtOutput.Text = result;
        }
    }
}
