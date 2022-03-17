using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace ClientConvertWS
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(this.txtFi.Text.ToString());
         
            this.txtLa.Text = b.ToString();
        }
    }
}