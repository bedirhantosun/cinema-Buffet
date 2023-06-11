using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_Buffet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cash = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int corn, ticket, water, tea, total;
            corn = Convert.ToInt16(TxtCorn.Text);
            ticket = Convert.ToInt16(TxtTicket.Text);
            water = Convert.ToInt16(TxtWater.Text);
            tea = Convert.ToInt16(TxtTea.Text);

            total = corn * 4 + tea * 2 + water * 1 + ticket * 8;
            LblTotal.Text = total.ToString()+ " TL ";

            cash = cash + total;
            LblCashBox.Text = cash.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTicket.Text = "";
            TxtTea.Text = "";
            TxtCorn.Text = "";
            TxtWater.Text = "";
            TxtCorn.Focus();
        }

        
    }
}
