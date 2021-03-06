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
{   // BindingSource links controls in VS to data in DB
    public partial class FrmBooks : Form
    {
        DataSet booksDataset = new DataSet();
        SqlDataAdapter booksDataAdapter;
        BindingSource booksBindingSource;
        SqlCommandBuilder dbSQLCommands;



        // Connection String to DB, Step 4
        // Catalogue != Catalog :)

        string DBConnectionString = @"Data Source=DESKTOP-EPUM9AK\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";




        public FrmBooks()
        {
            InitializeComponent();

            // Step 3, Show name, today's date 

            this.Text = "Book Details  - Date: " + DateTime.Today.ToLongDateString();
        }


        private void Frm1_Load(object sender, EventArgs e)
        {


            //Step 10 error handling, if DB is not connected
            try
            {

                // Step 4. Setting up connection. Creating instance of booksDataAdaptor
                // Passing SELECT statement & connection string

                booksDataAdapter = new SqlDataAdapter("SELECT * FROM tblBooks", DBConnectionString);
                booksDataAdapter.Fill(booksDataset, "tblBooks");
                MessageBox.Show("Connected to DB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + ":" + ex.Message);
                Application.Exit();
            }


            // Binds our textboxes to our data in SQL Server
            BindControls();
            // First call to numRecordsCountDisplay() 
            // causes the numRecordsCount textbox to get populated
            // to show the current record number

            numRecordsCountDisplay();

            booksBindingSource.PositionChanged += rowPositionChanged;



        }

        private void rowPositionChanged(object sender, EventArgs e)
        {

            numRecordsCountDisplay();
        }

        // Step 5, 6
        private void BindControls()
        {
            booksBindingSource = new BindingSource(booksDataset, "tblBooks");


            txtISBN.DataBindings.Add("Text", booksBindingSource, "ISBN");

            txtAuthor.DataBindings.Add("Text", booksBindingSource, "Author");

            txtTitle.DataBindings.Add("Text", booksBindingSource, "Title");

            txtGenre.DataBindings.Add("Text", booksBindingSource, "Genre");

            txtPub.DataBindings.Add("Text", booksBindingSource, "Publisher");

            txtYearPub.DataBindings.Add("Text", booksBindingSource, "YearPublished");






        }
        //THis is just changing the colour of the border in the app 
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(31, 61, 12), ButtonBorderStyle.Solid);
        }


        // Step 7
        // All buttons use booksBindingSource to manage the data as it's displayed
        // in the textboxes
        // The booksDataSet to interact with the table.


        // Apply any pending changes to dataset
        //Step 10 Error Handling
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                booksBindingSource.EndEdit(); // no more changes are carried through
                dbSQLCommands = new SqlCommandBuilder(booksDataAdapter); // connecting data adaptor to SQl builder
                booksDataAdapter.Update(booksDataset, "tblBooks");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Database Successfully Updated");

        }

        //Adds new row (object) to the dataset
        private void btnAdd_Click(object sender, EventArgs e)
        {

            booksBindingSource.AddNew();
            dbSQLCommands = new SqlCommandBuilder(booksDataAdapter); // connecting data adaptor to SQl builder
            booksDataAdapter.Update(booksDataset, "tblBooks");


        }

        // remove current row
        private void btnDelete_Click(object sender, EventArgs e)
        {

            booksBindingSource.RemoveCurrent();
            dbSQLCommands = new SqlCommandBuilder(booksDataAdapter); // connecting data adaptor to SQl builder
            booksDataAdapter.Update(booksDataset, "tblBooks");
            MessageBox.Show("Book Deleted");
        }
        // Go to FrmSearch 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch searchFrom = new FrmSearch();
            searchFrom.Show();
        }

        //Cancel Row
        private void btnCancel_Click(object sender, EventArgs e)
        {

            // Cancel editing of current row

            booksBindingSource.CancelEdit();

            // Rollback changes made to data

            booksDataset.RejectChanges();

        }
        // Step 9
        //index no 1 is 0, +1 to make it more readable to humans
        private void numRecordsCountDisplay()

        {

            txtNumRecords.Text = String.Format(" {0} of {1} ",
                booksBindingSource.Position + 1, booksBindingSource.Count);
        }


        //Step 8
        // First Listing in DB
        private void btnFirst_Click(object sender, EventArgs e)
        {
            booksBindingSource.MoveFirst();

        }
        //Previous
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            booksBindingSource.MovePrevious();

        }
        //Next
        private void btnNext_Click(object sender, EventArgs e)
        {
            booksBindingSource.MoveNext();

        }

        //Last
        private void btnLast_Click(object sender, EventArgs e)
        {
            booksBindingSource.MoveLast();

        }


        //Exit Application Safely
        //step 11
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exit Windows program
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblComBookLib_Click(object sender, EventArgs e)
        {

        }


        //This not the correct code for what I want to be happening, but it shows what 
        //if we had more time, how I wished the app behaves - for each record displayed a pop of Synopsis is possible.
        //
        //Pop up of the synopsis for Dante's inferno, record no. 45, Last in series. 


        private void btnSynopsis_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("In the Inferno,  Dante's protagonist - and his reader - is presented with a graphic vision of the dreadful consequences of sin," +
                " and encounters an all-too-human array of noble, grotesque, beguiling,ridiculous and horrific characters.");

        }
    }
}
