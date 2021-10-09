using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            int[] mas = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(0, 100);
                dataGridView1[i, 0].Value = mas[i].ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int n = dataGridView1.ColumnCount;
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            /*/int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + mas[i];
            }
            MessageBox.Show(sum.ToString());*/
            double[] b = new double[n-2];
            for(int i=0; i<n-2; i++)
            {
                b[i] = (mas[i] + mas[i + 1] * mas[i + 1] + mas[i + 2] * mas[i + 2]) / (mas[i + 1] * mas[i]);
                textBox1.Text = textBox1.Text + b[i] + "\r\n";

            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
