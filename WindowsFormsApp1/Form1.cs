using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnVND2USD_Click(object sender, EventArgs e)
        {
            using(ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient())
            {

                double t = Convert.ToDouble(this.txtMoney.Text.ToString());
                double temp = client.VNDToUSD(t);
                this.txtKetQua.Text = Math.Round(temp, 3).ToString();
            }
        }

        private void btnVND2EUR_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient())
            {

                double t = Convert.ToDouble(this.txtMoney.Text.ToString());
                double temp = client.VNDToEUR(t);
                this.txtKetQua.Text = Math.Round(temp, 3).ToString();
            }
        }

        private void btnUSD2VND_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient())
            {

                double t = Convert.ToDouble(this.txtMoney.Text.ToString());
                double temp = client.USDToVND(t);
                this.txtKetQua.Text = Math.Round(temp, 3).ToString();
            }
        }

        private void btnEUR2VND_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient())
            {

                double t = Convert.ToDouble(this.txtMoney.Text.ToString());
                double temp = client.EURToVND(t);
                this.txtKetQua.Text = Math.Round(temp, 3).ToString();
            }
        }
    }
}
