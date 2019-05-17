using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VcsRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            int days = (int)numericUpDown1.Value;

            RentalList rlist = new RentalList();
            rlist.Load();

            dataGridView1.Rows.Clear();
            foreach(Item item in rlist.Items)
            {
                dataGridView1.Rows.Add(item.Category,item.Title,item.GetPrice(days));
            }

            labelTotal.Text = rlist.getTotal(days) + "円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
