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
        private ServiceReference1.WebService1SoapClient ws;
        public Form1()
        {
            InitializeComponent();
            ws = new ServiceReference1.WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.txt1.Text = ws.USDToVND(10).ToString();
            
        }
    }
}
