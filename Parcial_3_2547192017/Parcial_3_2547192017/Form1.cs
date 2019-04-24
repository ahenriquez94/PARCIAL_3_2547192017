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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, passwd;
            usuario = textBox1.Text.TrimEnd();
            passwd = textBox2.Text.TrimEnd();

            if((usuario=="amilcar")&(passwd=="programacion")){
                MessageBox.Show("Bienvenido al Sistema");
                MDIParent1 obj1 = new MDIParent1();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INVALIDA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
