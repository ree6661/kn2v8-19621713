using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kontrolno_2_V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mjele.DESKTOP-G1OVLAV\Desktop\kn2v8-19621713\Database21.accdb;Persist Security Info=False;";
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Bank";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mjele.DESKTOP-G1OVLAV\Desktop\kn2v8-19621713\Database21.accdb;Persist Security Info=False;";
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "insert into Bank (Holder,Account,IBAN,Currency,Balance,Type of operation,Reason for payment,Accouting date,Debit/Credit,Period) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + dateTimePicker1.Value.ToShortDateString()+ "','" + textBox9.Text + "','" + dateTimePicker2.Value.ToShortDateString() + "',)";
                command.CommandText = query;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mjele.DESKTOP-G1OVLAV\Desktop\kn2v8-19621713\Database21.accdb;Persist Security Info=False;";
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "delite from Bank where id=" + textBox10.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mjele.DESKTOP-G1OVLAV\Desktop\kn2v8-19621713\Database21.accdb;Persist Security Info=False;";
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from sp1";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
    }

