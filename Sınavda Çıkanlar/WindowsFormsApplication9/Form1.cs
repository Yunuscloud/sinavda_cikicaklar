using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayi = new int [100];
        Random yunus = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Clear();

            for (int i = 0; i < sayi.Length ; i++)
            {
                sayi[i] = yunus.Next(sayi1,sayi2);
                listBox1.Items.Add(i + 1 + "=" + sayi[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(sayi);
            listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++)
            {
                listBox1.Items.Add(i + 1 + "=" + sayi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i< sayi.Length; i++)
            {
                if (sayi[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayi[i]);
                }
                else
                {
                    listBox3.Items.Add(sayi[i]);
                }
   
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            int tam = Convert.ToInt32(textBox3.Text);
            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] % tam == 0) 
                {
                    listBox4.Items.Add(sayi[i]);
                }
            }
        }
    }
}
