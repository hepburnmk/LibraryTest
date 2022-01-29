using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTest
{
    public partial class Frm1 : Form
    {
        DataSet booksDataset = new DataSet();
        SqlDataAdapter booksDataAdapter;
        BindingSource booksBindingSource;
        SqlCommandBuilder dbSQLCommands;


       
            //Connection String to DB, Step 4

        string DBConnectionString = @"Data Source=DESKTOP-EPUM9AK\SQLSERVER2019;Initial Catalogue=Library;Integrated Security=True;";




        public Frm1()
        {
            InitializeComponent();

// Step 3, Show name, today's date 

            this.Text = "Book Details  - Date: " + DateTime.Today.ToLongDateString();
        }
          

        private void Frm1_Load(object sender, EventArgs e)
        {
            //Step 4. Setting up connection. Creating instance of booksDataAdaptor
            //Passing SELECT statement & connection string

            booksDataAdapter = new SqlDataAdapter("SELECT FROM + FROM tblBooks", DBConnectionString);
            booksDataAdapter.Fill(booksDataset, "tblBooks");
            MessageBox.Show("Connected to DB");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            booksBindingSource.EndEdit();
            dbSQLCommands = new SqlCommandBuilder(booksDataAdapter);
            booksDataAdapter.Update(booksDataset,"tblBooks");
            
            MessageBox.Show("Databas Successfully Updated");

        }
    }
}
