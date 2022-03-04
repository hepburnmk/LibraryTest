namespace LibraryTest
{
    partial class FrmSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.tblBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBRARYDataSet = new LibraryTest.LIBRARYDataSet();
            this.title_SearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleToolStrip = new System.Windows.Forms.ToolStrip();
            this.titleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.titleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.titleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.author_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.authorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.authorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.author_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.genreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.genreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lIBRARYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBooksTableAdapter = new LibraryTest.LIBRARYDataSetTableAdapters.tblBooksTableAdapter();
            this.tableAdapterManager = new LibraryTest.LIBRARYDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).BeginInit();
            this.titleToolStrip.SuspendLayout();
            this.author_ToolStrip.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBooksDataGridView
            // 
            this.tblBooksDataGridView.AutoGenerateColumns = false;
            this.tblBooksDataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.tblBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tblBooksDataGridView.DataSource = this.tblBooksBindingSource;
            this.tblBooksDataGridView.Location = new System.Drawing.Point(0, 133);
            this.tblBooksDataGridView.Name = "tblBooksDataGridView";
            this.tblBooksDataGridView.RowHeadersWidth = 51;
            this.tblBooksDataGridView.RowTemplate.Height = 24;
            this.tblBooksDataGridView.Size = new System.Drawing.Size(808, 273);
            this.tblBooksDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YearPublished";
            this.dataGridViewTextBoxColumn5.HeaderText = "YearPublished";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Edition";
            this.dataGridViewTextBoxColumn7.HeaderText = "Edition";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn8.HeaderText = "Language";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn9.HeaderText = "Age";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Pages";
            this.dataGridViewTextBoxColumn10.HeaderText = "Pages";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Synopsis";
            this.dataGridViewTextBoxColumn11.HeaderText = "Synopsis";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // tblBooksBindingSource
            // 
            this.tblBooksBindingSource.DataMember = "tblBooks";
            this.tblBooksBindingSource.DataSource = this.lIBRARYDataSet;
            // 
            // lIBRARYDataSet
            // 
            this.lIBRARYDataSet.DataSetName = "LIBRARYDataSet";
            this.lIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // title_SearchToolStrip
            // 
            this.title_SearchToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.title_SearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.title_SearchToolStrip.Location = new System.Drawing.Point(0, 515);
            this.title_SearchToolStrip.Name = "title_SearchToolStrip";
            this.title_SearchToolStrip.Size = new System.Drawing.Size(808, 25);
            this.title_SearchToolStrip.TabIndex = 1;
            this.title_SearchToolStrip.Text = "title_SearchToolStrip";
            // 
            // titleToolStrip
            // 
            this.titleToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.titleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripLabel,
            this.titleToolStripTextBox,
            this.titleToolStripButton});
            this.titleToolStrip.Location = new System.Drawing.Point(0, 487);
            this.titleToolStrip.Name = "titleToolStrip";
            this.titleToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.titleToolStrip.Size = new System.Drawing.Size(808, 28);
            this.titleToolStrip.TabIndex = 2;
            this.titleToolStrip.Text = "titleToolStrip";
            // 
            // titleToolStripLabel
            // 
            this.titleToolStripLabel.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleToolStripLabel.Name = "titleToolStripLabel";
            this.titleToolStripLabel.Size = new System.Drawing.Size(48, 25);
            this.titleToolStripLabel.Text = "Title:";
            // 
            // titleToolStripTextBox
            // 
            this.titleToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titleToolStripTextBox.Name = "titleToolStripTextBox";
            this.titleToolStripTextBox.Size = new System.Drawing.Size(100, 28);
            // 
            // titleToolStripButton
            // 
            this.titleToolStripButton.BackColor = System.Drawing.Color.SeaGreen;
            this.titleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.titleToolStripButton.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleToolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleToolStripButton.Name = "titleToolStripButton";
            this.titleToolStripButton.Size = new System.Drawing.Size(119, 25);
            this.titleToolStripButton.Text = "Search by Title";
            this.titleToolStripButton.Click += new System.EventHandler(this.titleToolStripButton_Click);
            // 
            // author_ToolStrip
            // 
            this.author_ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.author_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.author_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripLabel,
            this.authorToolStripTextBox,
            this.author_ToolStripButton});
            this.author_ToolStrip.Location = new System.Drawing.Point(0, 459);
            this.author_ToolStrip.Name = "author_ToolStrip";
            this.author_ToolStrip.Size = new System.Drawing.Size(808, 28);
            this.author_ToolStrip.TabIndex = 3;
            this.author_ToolStrip.Text = "author_ToolStrip";
            // 
            // authorToolStripLabel
            // 
            this.authorToolStripLabel.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorToolStripLabel.Name = "authorToolStripLabel";
            this.authorToolStripLabel.Size = new System.Drawing.Size(66, 25);
            this.authorToolStripLabel.Text = "Author:";
            // 
            // authorToolStripTextBox
            // 
            this.authorToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authorToolStripTextBox.Name = "authorToolStripTextBox";
            this.authorToolStripTextBox.Size = new System.Drawing.Size(100, 28);
            // 
            // author_ToolStripButton
            // 
            this.author_ToolStripButton.BackColor = System.Drawing.Color.SeaGreen;
            this.author_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.author_ToolStripButton.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_ToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.author_ToolStripButton.Name = "author_ToolStripButton";
            this.author_ToolStripButton.Size = new System.Drawing.Size(140, 25);
            this.author_ToolStripButton.Text = "Search  by Author";
            this.author_ToolStripButton.ToolTipText = "Search Records";
            this.author_ToolStripButton.Click += new System.EventHandler(this.author_ToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripLabel,
            this.genreToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 431);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(808, 28);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // genreToolStripLabel
            // 
            this.genreToolStripLabel.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreToolStripLabel.Name = "genreToolStripLabel";
            this.genreToolStripLabel.Size = new System.Drawing.Size(60, 25);
            this.genreToolStripLabel.Text = "Genre:";
            // 
            // genreToolStripTextBox
            // 
            this.genreToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.genreToolStripTextBox.Name = "genreToolStripTextBox";
            this.genreToolStripTextBox.Size = new System.Drawing.Size(100, 28);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.BackColor = System.Drawing.Color.SeaGreen;
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(131, 25);
            this.fillByToolStripButton.Text = "Search by Genre";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // lIBRARYDataSetBindingSource
            // 
            this.lIBRARYDataSetBindingSource.DataSource = this.lIBRARYDataSet;
            this.lIBRARYDataSetBindingSource.Position = 0;
            // 
            // tblBooksTableAdapter
            // 
            this.tblBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBooksTableAdapter = this.tblBooksTableAdapter;
            this.tableAdapterManager.tblLibaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryTest.LIBRARYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(638, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Results";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Proza Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(638, 479);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 33);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(808, 540);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.author_ToolStrip);
            this.Controls.Add(this.titleToolStrip);
            this.Controls.Add(this.title_SearchToolStrip);
            this.Controls.Add(this.tblBooksDataGridView);
            this.Font = new System.Drawing.Font("Proza Libre", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSearch";
            this.Text = "Search Records";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).EndInit();
            this.titleToolStrip.ResumeLayout(false);
            this.titleToolStrip.PerformLayout();
            this.author_ToolStrip.ResumeLayout(false);
            this.author_ToolStrip.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource lIBRARYDataSetBindingSource;
        private LIBRARYDataSet lIBRARYDataSet;
        private System.Windows.Forms.BindingSource tblBooksBindingSource;
        private LIBRARYDataSetTableAdapters.tblBooksTableAdapter tblBooksTableAdapter;
        private LIBRARYDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblBooksDataGridView;
        private System.Windows.Forms.ToolStrip title_SearchToolStrip;
        private System.Windows.Forms.ToolStrip titleToolStrip;
        private System.Windows.Forms.ToolStripLabel titleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox titleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton titleToolStripButton;
        private System.Windows.Forms.ToolStrip author_ToolStrip;
        private System.Windows.Forms.ToolStripTextBox authorToolStripTextBox;
        private System.Windows.Forms.ToolStripButton author_ToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel genreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox genreToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripLabel authorToolStripLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHome;
    }
}