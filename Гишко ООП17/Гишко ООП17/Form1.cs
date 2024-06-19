using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гишко_ООП17
{
    public partial class Form1 : Form
    {
        Currency dollar;
        Currency euro;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                euro = new Euro(result);
                label1.Text = euro.ToString(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                dollar = new Dollar(result);
                label1.Text = dollar.ToString();
            }
        }
    }
}
