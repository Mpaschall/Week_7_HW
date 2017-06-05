using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace _15_10
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        string cName, product, date, order;
        int bought;

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\xdark\Documents\Visual Studio 2015\Projects\15_10\15_10\bin\Sales.mdb;
                                     Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tom");
            comboBox1.Items.Add("Jerry");
            comboBox2.Items.Add("Doritos");
            comboBox2.Items.Add("Cheetos");
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            cName = comboBox1.Text;
            product = comboBox2.Text;
            OleDbCommand comm = new OleDbCommand();
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM OurSales WHERE CustomerName= '" 
                    + cName + "' and ProductName= '" + product + "'";
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    order = "name: " + (reader["CustomerName"].ToString()) 
                        + ", product: " + (reader["ProductName"].ToString()) 
                        + ", quantity: " + int.Parse(reader["Quantity"].ToString()) 
                        + ", date: " + (reader["OrderDate"].ToString());
                    listBox1.Items.Add(order);
                }
                conn.Close();
            }
            catch (OleDbException f)
            {
                MessageBox.Show("Error with database connection.");
            }
        }
    }
}
