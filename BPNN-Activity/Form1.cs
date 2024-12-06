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
        public NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(2, 100, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nn == null) return;
            for(int x = 0; x < 100; x++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nn == null) return;
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.run();
 
            textBox3.Text = "" + nn.getOuputData(0);
        }

        private void inputANDGateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ANDGateForm = new Form2();
            ANDGateForm.Show();
        }
    }
}
