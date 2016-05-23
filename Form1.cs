using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.dBDataSet.Bill);
            // TODO: This line of code loads data into the 'dBDataSet.served' table. You can move, or remove it, as needed.
            this.servedTableAdapter.Fill(this.dBDataSet.served);
            // TODO: This line of code loads data into the 'dBDataSet.table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dBDataSet.table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form obj = new Form2();
            obj.Show();
        }
    }
}
