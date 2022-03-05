using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryTest
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        //Fills the dataGridView with data from tblBooks 
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'lIBRARYDataSet.tblBooks' table. 
            this.tblBooksTableAdapter.Fill(this.lIBRARYDataSet.tblBooks);

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {


        }
        //Changes the colour of the border in the app. 
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(31, 61, 12), ButtonBorderStyle.Solid);
        }

        //title search method
        private void titleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblBooksTableAdapter.Title(this.lIBRARYDataSet.tblBooks, titleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //author search method
        private void author_ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblBooksTableAdapter.Author_(this.lIBRARYDataSet.tblBooks, authorToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //genre search method
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblBooksTableAdapter.FillBy(this.lIBRARYDataSet.tblBooks, genreToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //replaces the list of books with the entire list of books 
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tblBooksTableAdapter.Fill(this.lIBRARYDataSet.tblBooks);
        }
        // this will return to FrmBooks, where you can exit as well. 
        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmBooks homefrm = new FrmBooks();
            homefrm.Show();

        }

        private void tblBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
