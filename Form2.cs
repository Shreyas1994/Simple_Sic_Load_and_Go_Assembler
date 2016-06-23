using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string opcode;
        string labelz;
        string operand;
        string m;
        string fg;
        string d;
        bool vc;
        int a = 0;
        string value;
        static System.Data.OleDb.OleDbConnection con1 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");
        public Form2()
        {
            InitializeComponent();
            grid1();
            grid2();
            grid3();

        }
        private void grid1()
        {
            try
            {

                DataSet ds = new DataSet();
                System.Data.OleDb.OleDbDataAdapter adapReport = new System.Data.OleDb.OleDbDataAdapter("select Adress as [address], opcode as [Symbol],operand as [opco],op as [operand],ooo as[obj] from read_pgm" + "'", con1);
                adapReport.Fill(ds, "read_pgm");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "read_pgm";


                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {


                    dataGridView1.Rows[i].Cells[0].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView1.Rows[i].Cells[1].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView1.Rows[i].Cells[2].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView1.Rows[i].Cells[3].Style.Font = new Font("Arial", 9, FontStyle.Bold);

                }
                Int16 b = Convert.ToInt16(dataGridView1.Rows[1].Cells[0].Value);

                //start_address = Convert.ToString(dataGridView1.Rows[1].Cells[0].Value);

                // MessageBox.Show(add + " in second form");

                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void grid2()
        {


            con1.Open();
            try
            {

                DataSet ds1 = new DataSet();
                System.Data.OleDb.OleDbDataAdapter adapReport = new System.Data.OleDb.OleDbDataAdapter("select SYMBOLE as [Symbol],ADDRESS as [ADDRESS] from SYMBOL_TABLE" + "'", con1);
                adapReport.Fill(ds1, "SYMBOL_TABLE");
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = ds1;
                dataGridView2.DataMember = "SYMBOL_TABLE";


                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {


                    dataGridView2.Rows[i].Cells[0].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView2.Rows[i].Cells[1].Style.Font = new Font("Arial", 9, FontStyle.Bold);

                }
                //Int16 b = Convert.ToInt16(dataGridView1.Rows[1].Cells[0].Value);

                //start_address = Convert.ToString(dataGridView1.Rows[1].Cells[0].Value);

                // MessageBox.Show(add + " in second form");

                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //con1.Close();
        }
        private void grid3()
        {


            con1.Open();
            try
            {

                DataSet ds2 = new DataSet();
                System.Data.OleDb.OleDbDataAdapter adapReport = new System.Data.OleDb.OleDbDataAdapter("select opcode as [opcode],val as [value] from Mnemoni" + "'", con1);
                adapReport.Fill(ds2, "Mnemoni");
                dataGridView3.AutoGenerateColumns = true;
                dataGridView3.DataSource = ds2;
                dataGridView3.DataMember = "Mnemoni";


                foreach (DataGridViewColumn col in dataGridView3.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {


                    dataGridView3.Rows[i].Cells[0].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    dataGridView3.Rows[i].Cells[1].Style.Font = new Font("Arial", 9, FontStyle.Bold);

                }
                //Int16 b = Convert.ToInt16(dataGridView1.Rows[1].Cells[0].Value);

                //start_address = Convert.ToString(dataGridView1.Rows[1].Cells[0].Value);

                // MessageBox.Show(add + " in second form");

                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void cal(DataGridView dataGridView1, DataGridView dataGridView2, DataGridView dataGridView3)
        {

            string start_address = Convert.ToString(dataGridView1.Rows[1].Cells[0].Value);


            ///   MessageBox.Show("this is start adder" + start_address);
            for (int i = 1; i < dataGridView1.Rows.Count - 2; i++)
            {
                labelz = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                opcode = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                operand = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                string objcod = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                a = a + Convert.ToInt16(3);
                string s = a.ToString("X");
                string bv = a.ToString();

                if (dataGridView1.Rows[i].Cells[2].Value.ToString() != "END")
                {
                    if (bv.Length == 2)
                    {
                        string tr = start_address.Remove(1, 2);
                        dataGridView1.Rows[i + 1].Cells[0].Value = tr + s;
                    }

                    else if (bv.Length < 2)
                    {
                        string tr = start_address.Remove(2, 1);
                        dataGridView1.Rows[i + 1].Cells[0].Value = tr + s;
                    }
                }
                d = dataGridView1.Rows[i].Cells[0].Value.ToString();
              
                if (labelz != null && labelz != "")
                {


                    try
                    {
                        for (int lab = 0; lab < dataGridView2.Rows.Count; lab++)
                        {
                            if (labelz == dataGridView2.Rows[lab].Cells[0].Value.ToString())
                            {
                                 cv(dataGridView1.Rows[i].Cells[0].Value.ToString(), labelz);
                                grid2();
                                break;

                            }
                        }
                    }

                    catch (NullReferenceException v)
                    {
                        im(labelz, d);
                        grid2();
                        //break;

                    }
                }
                if (opcode != null)
                {
                    for (int kj = 0; kj < dataGridView3.Rows.Count; kj++)
                    {
                        try
                        {
                            if (dataGridView3.Rows[kj].Cells[0].Value.ToString() == opcode)
                            {
                                dataGridView1.Rows[i].Cells[4].Value = dataGridView3.Rows[kj].Cells[1].Value.ToString();
                                value = dataGridView3.Rows[kj].Cells[1].Value.ToString();
                                MessageBox.Show(value);
                                //MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            string qw = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            if (qw.Length == 4)
                            {
                                value = "00" + qw;
                                dataGridView1.Rows[i].Cells[4].Value = value;
                                // MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                            }
                            if (qw.Length == 1)
                            {
                                value = "00000" + qw;
                                dataGridView1.Rows[i].Cells[4].Value = value;
                                // MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                            }
                            if (qw.Length == 2)
                            {
                                value = "0000" + qw;
                                dataGridView1.Rows[i].Cells[4].Value = value;
                                // MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                            }
                            if (qw.Length == 3)
                            {
                                value = "000" + qw;
                                dataGridView1.Rows[i].Cells[4].Value = value;
                                // MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                            }
                        }
                    }
                }
                if (operand == "")
                {
                    dataGridView1.Rows[i].Cells[4].Value = value + "0000";
                    // MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                }

                if (operand != "")
                {
                    try
                    {
                        for (int jm = 0; jm <i; jm++)
                        {

                            //break;

                            if (dataGridView2.Rows[jm].Cells[0].Value.ToString() == operand)
                            {


                                for (int hj = 0; hj < i; hj++)
                                {
                                    if (dataGridView1.Rows[hj].Cells[1].Value.ToString() == operand)
                                    {

                                      //  m = dataGridView1.Rows[hj].Cells[0].Value.ToString();
                                      //  MessageBox.Show("symbole" + operand + " is already in symbol table" + "with address" + m);
                                      //  cv(operand, m);
                                      //  grid2();
                                        break;

                                    }
                                    /* else
                                     {
                                         cv(operand,"XXXX");
                                         grid2();
                                     }*/
                                }

                                break;
                            }
                        }

                    }
                    catch (NullReferenceException e)
                    {
                        int vcc;
                        bool vc = Convert.ToBoolean(int.TryParse(operand, out vcc));

                        if (!vc)
                        {
                          //  MessageBox.Show("symbol" + operand + "is not present in symbol table & entered with value" + "xxxx");
                            im(operand, "XXXX");
                            grid2();
                        }
                    
                    }
                }
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "")
                {
                    for (int jh = 0; jh < dataGridView2.Rows.Count ; jh++)
                    {
                        try
                        {
                            if (dataGridView2.Rows[jh].Cells[0].Value.ToString() == operand)
                            {

                                fg = dataGridView2.Rows[jh].Cells[1].Value.ToString();

                                dataGridView1.Rows[i].Cells[4].Value = value + fg;
                                //  MessageBox.Show("object code is" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                                // MessageBox.Show(operand);
                                break;
                            }
                        }
                        catch (NullReferenceException v)
                        {
                            break;

                        }

                    }
                }


                objcode(dataGridView1, dataGridView2, dataGridView3);
                MessageBox.Show("symbol_table content");
                for (int sym = 0; sym < dataGridView2.Rows.Count - 1; sym++)
                {
                    try
                    {
                        MessageBox.Show(dataGridView2.Rows[sym].Cells[0].Value.ToString() + "" + dataGridView2.Rows[sym].Cells[1].Value.ToString());
                    }
                    catch (NullReferenceException b)
                    { }
                }
                //break;
                MessageBox.Show("object_code");
                for (int ad = 2; ad < i; ad++)
                {
                    MessageBox.Show(dataGridView1.Rows[ad].Cells[4].Value.ToString());
                }

            }
        }



        private static void objcode(DataGridView dataGridView1, DataGridView dataGridView2, DataGridView dataGridView3)
        {
            for (int mi = 1; mi < dataGridView1.Rows.Count - 2; mi++)
            {

                if (dataGridView1.Rows[mi].Cells[0].Value.ToString().Length == 3)
                {
                    string sd = dataGridView1.Rows[mi].Cells[0].Value.ToString();
                    sd = sd.Insert(1, "0");
                    dataGridView1.Rows[mi].Cells[0].Value = sd;
                    //  MessageBox.Show("object code is in if loop" + dataGridView1.Rows[mi].Cells[4].Value.ToString());
                    break;
                }
                try
                {
                    string kj = dataGridView1.Rows[mi].Cells[4].Value.ToString();
                    //  MessageBox.Show("kj length is" + kj.Length);
                    if (kj.Contains("XXXX"))
                    {
                        for (int re = 0; re < dataGridView2.Rows.Count; re++)
                        { 
                            if (dataGridView2.Rows[re].Cells[0].Value.ToString() == dataGridView1.Rows[mi].Cells[3].Value.ToString())
                            {
                                string vv = dataGridView2.Rows[re].Cells[1].Value.ToString();
                                if (vv != "XXXX")
                                {
                                    for (int fg = 0; fg < dataGridView3.Rows.Count; fg++)
                                    {
                                        if (dataGridView3.Rows[fg].Cells[0].Value.ToString() == dataGridView1.Rows[mi].Cells[2].Value.ToString())
                                        {
                                            kj = dataGridView3.Rows[fg].Cells[1].Value.ToString();
                                            dataGridView1.Rows[mi].Cells[4].Value = kj + vv;
                                        }

                                    }
                                   
                                }
                                // MessageBox.Show("object code is " + dataGridView1.Rows[re].Cells[4].Value.ToString());
                                break;

                            }
                        }
                    }

                    if (kj.Length < 6)
                    {
                        for (int re = 0; re < dataGridView2.Rows.Count ; re++)
                        {
                            if (dataGridView2.Rows[re].Cells[0].Value.ToString() == dataGridView1.Rows[mi].Cells[3].Value.ToString())
                            {
                                string vv = dataGridView2.Rows[re].Cells[1].Value.ToString();
                                dataGridView1.Rows[mi].Cells[4].Value = kj + vv;
                                // MessageBox.Show("object code is " + dataGridView1.Rows[re].Cells[4].Value.ToString());
                                break;

                            }

                        }
                    }
                }
                catch (NullReferenceException v)
                {

                }
            }
        }
        private static void im(string lab, string d)
        {

            System.Data.OleDb.OleDbConnection con1 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");
            try
            {
                con1.Open();

                System.Data.OleDb.OleDbCommand top = new System.Data.OleDb.OleDbCommand(
        "INSERT INTO SYMBOL_TABLE (" +
                "SYMBOLE,ADDRESS" +
            ") VALUES (?,?)", con1);

                top.Parameters.AddWithValue("?", lab);
                top.Parameters.AddWithValue("?", d);
                //  top.Parameters.AddWithValue("?", mcs[2]);
                top.ExecuteNonQuery();
                con1.Close();
                Form2 obj = new Form2();
                obj.grid2();

            }


            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }
        }
        public static void cv(string a, string b)
        {

            try
            {
                con1.Open();
                System.Data.OleDb.OleDbCommand top1 = new System.Data.OleDb.OleDbCommand("UPDATE SYMBOL_TABLE SET[ADDRESS] = ? where SYMBOLE = ?", con1);
                top1.Parameters.AddWithValue("?", a);
                top1.Parameters.AddWithValue("?", b);

                top1.ExecuteNonQuery();
                con1.Close();
                Form2 obj = new Form2();
                obj.grid2();


            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cal(dataGridView1, dataGridView2, dataGridView3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

