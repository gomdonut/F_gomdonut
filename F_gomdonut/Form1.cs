using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_gomdonut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi gomdonut");
            MessageBox.Show("hi gomdonut 222!");
            MessageBox.Show("booting and push");
            #크로스스레드작업이잘못되었을땐invoke로해결하자
        }
    }
}
