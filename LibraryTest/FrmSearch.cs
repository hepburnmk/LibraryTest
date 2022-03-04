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

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBRARYDataSet.tblBooks' table. You can move, or remove it, as needed.
            this.tblBooksTableAdapter.Fill(this.lIBRARYDataSet.tblBooks);

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
       

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(31, 61, 12), ButtonBorderStyle.Solid);
        }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tblBooksTableAdapter.Fill(this.lIBRARYDataSet.tblBooks);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmBooks homefrm = new FrmBooks();
            homefrm.Show(); 
           
        }
    }
    }
