using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3_2547192017
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cant, tanto, total, totalsum;

            if(radioButton1.Checked==true){
                cant = double.Parse(textBox1.Text);
                tanto = double.Parse(textBox2.Text);

                total = (cant / 100) * tanto;

                textBox3.Text = total.ToString();

                totalsum = total + cant;

                textBox4.Text = totalsum.ToString();

            }else if(radioButton2.Checked==true){

                cant = double.Parse(textBox1.Text);
                tanto = double.Parse(textBox2.Text);

                total = (cant / 100) * tanto;

                textBox3.Text = total.ToString();

                textBox4.Text = cant.ToString();
            }

           

        }
    }
}
