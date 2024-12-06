using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BPNN_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 orGate = new Form3();
            orGate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 andGate = new Form2();
            andGate.Show();
        }
    }
}
