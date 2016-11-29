using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calculateDate()
        {
            DateTime sDate, fDate;
            double timeToAdd;
            sDate = dateTimePicker1.Value.Date;
            timeToAdd = (double)(numericUpDown1.Value)*7;
            fDate = sDate.Add(TimeSpan.FromDays(timeToAdd));
            dateTimePicker2.Value = fDate;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calculateDate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculateDate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
