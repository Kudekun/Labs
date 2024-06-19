using System;
using System.Windows.Forms;


namespace Гишко_ООП16
{
    public partial class Form1 : Form
    {
        LinkedList<string> MyList;

        public Form1()
        {
            InitializeComponent();
            MyList = new LinkedList<string>();
        }

        private void AddToHead_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            MyList.AddFirst(data);
            PrintList();
        }

        private void RemoveAtHead_Click(object sender, EventArgs e)
        {
            MyList.RemoveFirst();
            PrintList();
        }

        private void AddToTail_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            MyList.AddLast(data);
            PrintList();
        }

        private void RemoveAtTail_Click(object sender, EventArgs e)
        {
            MyList.RemoveLast();
            PrintList();
        }

        private void RemoveAll_Click(object sender, EventArgs e)
        {
            MyList.Clear();
            PrintList();
        }

        private void PrintList()
        {
            StringLabel.Text = MyList.ToString();
        }
    }
}
