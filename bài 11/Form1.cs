using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("làm sét phi phai!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" game là dễ");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("dag vào phi phai.");
        }
    }
}
