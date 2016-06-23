using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.IO;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int ccc;
       
        public Form1()
        {
            InitializeComponent();
            datagridview1.Visible = false;
            dataGridView2.Visible = false;
            
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


           
         
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSSEMBLERDataSet1.read_pgm' table. You can move, or remove it, as needed.
            this.read_pgmTableAdapter.Fill(this.aSSEMBLERDataSet1.read_pgm);
            // TODO: This line of code loads data into the 'aSSEMBLERDataSet.Mnemoni' table. You can move, or remove it, as needed.
            this.mnemoniTableAdapter.Fill(this.aSSEMBLERDataSet.Mnemoni);
            label1.Visible = false;
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        { //Form1 obj1 = new Form1();
            
            dataGridView2.Visible = true;
            string[] s = new string[200];
            string line;
            int m = 0;
            ccc =0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

                 openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Opening the selected file to read.
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Reading from the file
                    try { while ((line = reader.ReadLine()) != null)

                        {
                           
                           
                            s[m++] = line;
                            
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    reader.Close();
                    for(int k=0;s[k]!=null;k++)
                    {
                        string[] mcs = s[k].Split(' ');

                       
                        int leng = mcs.Count();
                       
                        if(leng == 1)
                        {
                            System.Data.OleDb.OleDbConnection con1 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");
                            try
                            {
                                ccc++;
                                con1.Open();
                                System.Data.OleDb.OleDbCommand top = new System.Data.OleDb.OleDbCommand(
                        "INSERT INTO read_pgm (" +
                                "ID,operand" +
                            ") VALUES (?,?)", con1);
                                top.Parameters.AddWithValue("?",ccc);

                                top.Parameters.AddWithValue("?", mcs[0]);
                               
                                top.ExecuteNonQuery();
                                con1.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if(leng == 2)
                        {
                            System.Data.OleDb.OleDbConnection con1 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");
                            try
                            {
                                ccc++;
                                con1.Open();
                                System.Data.OleDb.OleDbCommand top = new System.Data.OleDb.OleDbCommand(
                        "INSERT INTO read_pgm (" +
                                "ID,operand,op" +
                            ") VALUES (?,?,?)", con1);
                                top.Parameters.AddWithValue("?", ccc);

                                top.Parameters.AddWithValue("?", mcs[0]);
                                top.Parameters.AddWithValue("?", mcs[1]);
                                top.ExecuteNonQuery();
                                con1.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            System.Data.OleDb.OleDbConnection con1 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");
                            try
                            {
                                ccc++;
                                con1.Open();
                                System.Data.OleDb.OleDbCommand top = new System.Data.OleDb.OleDbCommand(
                        "INSERT INTO read_pgm (" +
                                "ID,opcode,operand,op" +
                            ") VALUES (?,?,?,?)", con1);
                                top.Parameters.AddWithValue("?",ccc);

                                top.Parameters.AddWithValue("?", mcs[0]);
                                top.Parameters.AddWithValue("?", mcs[1]);
                                top.Parameters.AddWithValue("?",mcs[2]);
                                top.ExecuteNonQuery();
                                con1.Close();
                            }
                           
                        
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                           
                        }

                    }
                }
         
                start_adress();
            }
        }
        public static void start_adress()
        {
            System.Data.OleDb.OleDbConnection con1 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");

            try
            {

                con1.Open();
                System.Data.OleDb.OleDbDataReader reader = null;
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand("select operand from read_pgm where operand='START'", con1);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string opcode = reader["operand"].ToString();
                    if (opcode == "START")
                    {
                        // string f = "FIRST";
                        System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand("select op from read_pgm where operand ='START'", con1);
                        reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            int lc = 0;
                            lc = lc + Convert.ToInt16(reader["op"].ToString());
                            System.Data.OleDb.OleDbConnection con2 = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=D:/ASSEMBLER.mdb");
                            con2.Open();

                            System.Data.OleDb.OleDbCommand top1 = new System.Data.OleDb.OleDbCommand("UPDATE read_pgm SET[Adress] = ? where opcode = ?", con2);
                            string cv = Convert.ToString(lc);
                            top1.Parameters.AddWithValue("?", Convert.ToString(lc));
                            top1.Parameters.AddWithValue("?", "FIRST");

                            top1.ExecuteNonQuery();

                            //lc = lc + 3;

                            con2.Close();

                        }


                    }

                }
                con1.Close();
                // Form1 ob = new Form1();
                // ob.pgm();
               // this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.Source);


            }
            finally
            {

                Form obj = new Form2();
                obj.Show();
            }
        }
        void pgm()
        {
          

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
