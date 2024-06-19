using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гишко_ООП19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int len) &&
                int.TryParse(textBox3.Text, out int pos))
            {
                char[] arr = textBox1.Text.ToCharArray();

                if (len > arr.Length || len < 0 ||
                    pos > arr.Length || pos < 0)
                {
                    return;
                }

                char[] res = RemoveSubstring(arr, pos, len);
                string strRes = new string(res);
                label1.Text = strRes;
            }
        }

        public static char[] RemoveSubstring(char[] input, int position, int length)
        {
            // Визначення довжини нового масиву
            int newLength = input.Length - length;

            // Створення нового масиву для зберігання результату
            char[] result = new char[newLength];

            // Копіювання частин масиву до позиції видалення
            for (int i = 0; i < position; i++)
            {
                result[i] = input[i];
            }

            // Копіювання частин масиву після видалення
            for (int i = position + length; i < input.Length; i++)
            {
                result[i - length] = input[i];
            }

            return result;
        }
    }
}
