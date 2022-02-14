namespace LibraryTest
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSelectValues = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.cboValue = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaliable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbSelectValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSelectValues
            // 
            this.grbSelectValues.Controls.Add(this.btnClose);
            this.grbSelectValues.Controls.Add(this.btnRun);
            this.grbSelectValues.Controls.Add(this.cboOperator);
            this.grbSelectValues.Controls.Add(this.cboValue);
            this.grbSelectValues.Controls.Add(this.cboField);
            this.grbSelectValues.Controls.Add(this.lblValue);
            this.grbSelectValues.Controls.Add(this.lblField);
            this.grbSelectValues.Controls.Add(this.lblOperator);
            this.grbSelectValues.Location = new System.Drawing.Point(24, 29);
            this.grbSelectValues.Name = "grbSelectValues";
            this.grbSelectValues.Size = new System.Drawing.Size(739, 133);
            this.grbSelectValues.TabIndex = 0;
            this.grbSelectValues.TabStop = false;
            this.grbSelectValues.Text = "Select Values";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(614, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(614, 43);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(195, 88);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(173, 24);
            this.cboOperator.TabIndex = 5;
            // 
            // cboValue
            // 
            this.cboValue.FormattingEnabled = true;
            this.cboValue.Location = new System.Drawing.Point(415, 88);
            this.cboValue.Name = "cboValue";
            this.cboValue.Size = new System.Drawing.Size(121, 24);
            this.cboValue.TabIndex = 4;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(21, 88);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 24);
            this.cboField.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(412, 43);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(42, 16);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(18, 43);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(37, 16);
            this.lblField.TabIndex = 1;
            this.lblField.Text = "Field";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(192, 43);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(60, 16);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "Operator";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Author,
            this.Title,
            this.Genre,
            this.Publisher,
            this.YearPublished,
            this.Avaliable});
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Genre.Width = 125;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.Width = 125;
            // 
            // YearPublished
            // 
            this.YearPublished.HeaderText = "Year Published";
            this.YearPublished.MinimumWidth = 6;
            this.YearPublished.Name = "YearPublished";
            this.YearPublished.Width = 125;
            // 
            // Avaliable
            // 
            this.Avaliable.HeaderText = "Available";
            this.Avaliable.MinimumWidth = 6;
            this.Avaliable.Name = "Avaliable";
            this.Avaliable.Width = 125;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbSelectValues);
            this.Name = "frmSearch";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.grbSelectValues.ResumeLayout(false);
            this.grbSelectValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSelectValues;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboValue;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox textBoxFilterValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublished;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Avaliable;
    }
}