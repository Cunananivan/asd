using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form{
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double n1, hou, dei;
            n1 = int.Parse(perhour.Text);
            hou = n1 * 8;
            dei = hou * 24;
            
            hourday.Text = hou.ToString();
            perday.Text = dei.ToString();
            salary.Text = dei.ToString();

            double n15, n5, n2, tutal;
            n15 = dei * 0.15;
            n5 = dei * 0.05;
            n2 = dei * 0.02;

            tutal = n15 + n5 + n2;
            minos.Text = n15.ToString();
            philh.Text = n5.ToString();
            sss.Text = n2.ToString();
            total.Text = tutal.ToString();

            double gg, dedoc, yes;
            gg = dei;
            dedoc = tutal;
            yes = gg - dedoc;

            gsalary.Text = dei.ToString();
            deduc.Text = tutal.ToString();
            nsalary.Text = yes.ToString();
        }

        private void EmployeeName_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
