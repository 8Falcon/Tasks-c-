using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtdiscount.Clear();
            txtbouns.Clear();
            txtnet.Clear();
            txtrate.Clear();
            txtsalary.Clear();
            txtsalaryafter.Clear();
            txttotal.Clear();
            txtvalue.Clear();

         
        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            // declare Variables
            string name;
            float hours, discount;
            int bonus;
            short rate;
            double salary, value, after, net;
            // get Text From Input Fields
            name = txtname.Text;
            discount = float.Parse(txtdiscount.Text);
            hours = float.Parse(txttotal.Text);
            bonus = int.Parse(txtbouns.Text);
            rate = short.Parse(txtrate.Text);
            // proccess
            salary = hours * rate;
            value = salary * discount;
            after = salary - value;
            net = after - bonus;
            // output Result
            txtsalary.Text = salary.ToString("0.00");
            txtvalue.Text = discount.ToString("0.00");
            txtsalaryafter.Text = after.ToString("0.00");
            txtnet.Text = net.ToString("0.00");
        }
    }
}
