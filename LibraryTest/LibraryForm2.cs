using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTest
{
    public partial class frmSearch : Form

    {
        Frm1 callingForm;
        DataView booksTableView;


        public frmSearch()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("1", "XX");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = booksTableView;
            dataGridView1.Columns["YearPublished"].
                DefaultCellStyle.Format = "int";

            this.Text = "Task A Search - Megan Kelly - Date: " +
                DateTime.Now.ToShortDateString();

            cboField.Items.Add("Author");
            cboField.Items.Add("Title");
            cboField.Items.Add("Genre");
            cboField.Items.Add("Available");


            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            callingForm.Show();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboField.Text) ||
                String.IsNullOrEmpty(cboOperator.Text) ||
                String.IsNullOrEmpty(textBoxFilterValue.Text))
            {
                MessageBox.Show("Missing search criteria!");
            }
            else
            {
                string filter = String.Format("{0} {1} '{2}'",
                    cboField.Text, cboOperator.Text,
                    textBoxFilterValue.Text);

                booksTableView.RowFilter = filter;
                MessageBox.Show(booksTableView.Count.ToString() + " matching rows found.");
            }
        }

        private void lblField_Click(object sender, EventArgs e)
        {

        }
    }
}

