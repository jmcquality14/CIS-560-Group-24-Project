namespace Cis560DB
{
    partial class uxDBSearchForm
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
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxDirectorBox = new System.Windows.Forms.TextBox();
            this.uxYearComboBox = new System.Windows.Forms.ComboBox();
            this.uxGenreComboBox = new System.Windows.Forms.ComboBox();
            this.uxOrderedByLabel = new System.Windows.Forms.Label();
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.MovieIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevenueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxSearchByLabel = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxOBCheckList = new System.Windows.Forms.CheckedListBox();
            this.uxOrderByCheckList = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(12, 458);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(847, 23);
            this.uxSearchButton.TabIndex = 0;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.FormattingEnabled = true;
            this.uxRatingBox.Items.AddRange(new object[] {
            "4 Stars and Above",
            "3 Stars and Above",
            "2 Stars and Above ",
            "1 Star and Above"});
            this.uxRatingBox.Location = new System.Drawing.Point(364, 391);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(213, 21);
            this.uxRatingBox.TabIndex = 1;
            this.uxRatingBox.Text = "--Select Rating--";
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Location = new System.Drawing.Point(364, 283);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(213, 20);
            this.uxTitleBox.TabIndex = 2;
            // 
            // uxDirectorBox
            // 
            this.uxDirectorBox.Location = new System.Drawing.Point(364, 327);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(213, 20);
            this.uxDirectorBox.TabIndex = 5;
            // 
            // uxYearComboBox
            // 
            this.uxYearComboBox.FormattingEnabled = true;
            this.uxYearComboBox.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.uxYearComboBox.Location = new System.Drawing.Point(364, 369);
            this.uxYearComboBox.Name = "uxYearComboBox";
            this.uxYearComboBox.Size = new System.Drawing.Size(213, 21);
            this.uxYearComboBox.TabIndex = 8;
            this.uxYearComboBox.Text = "--Select Year--";
            // 
            // uxGenreComboBox
            // 
            this.uxGenreComboBox.FormattingEnabled = true;
            this.uxGenreComboBox.Items.AddRange(new object[] {
            "Action ",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Historical",
            "Historical Fiction",
            "Horror",
            "Magical Realism",
            "Mystery",
            "Paranoid Fiction",
            "Philosophical",
            "Political",
            "Romance",
            "Saga",
            "Satire",
            "Science Ficition",
            "Thriller",
            "Western"});
            this.uxGenreComboBox.Location = new System.Drawing.Point(364, 305);
            this.uxGenreComboBox.Name = "uxGenreComboBox";
            this.uxGenreComboBox.Size = new System.Drawing.Size(213, 21);
            this.uxGenreComboBox.TabIndex = 16;
            this.uxGenreComboBox.Text = "--Select Genre--";
            // 
            // uxOrderedByLabel
            // 
            this.uxOrderedByLabel.AutoSize = true;
            this.uxOrderedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOrderedByLabel.Location = new System.Drawing.Point(12, 261);
            this.uxOrderedByLabel.Name = "uxOrderedByLabel";
            this.uxOrderedByLabel.Size = new System.Drawing.Size(93, 20);
            this.uxOrderedByLabel.TabIndex = 19;
            this.uxOrderedByLabel.Text = "Ordered By:";
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieIDCol,
            this.MovieTitle,
            this.GenreCol,
            this.DirectorCol,
            this.ReleaseDateCol,
            this.ReleaseYearCol,
            this.RatingCol,
            this.CostCol,
            this.RevenueCol});
            this.uxDataGrid.Location = new System.Drawing.Point(16, 12);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.Size = new System.Drawing.Size(843, 233);
            this.uxDataGrid.TabIndex = 20;
            // 
            // MovieIDCol
            // 
            this.MovieIDCol.HeaderText = "Movie ID";
            this.MovieIDCol.Name = "MovieIDCol";
            // 
            // MovieTitle
            // 
            this.MovieTitle.HeaderText = "Movie Title";
            this.MovieTitle.Name = "MovieTitle";
            // 
            // GenreCol
            // 
            this.GenreCol.HeaderText = "Genre";
            this.GenreCol.Name = "GenreCol";
            // 
            // DirectorCol
            // 
            this.DirectorCol.HeaderText = "Director";
            this.DirectorCol.Name = "DirectorCol";
            // 
            // ReleaseDateCol
            // 
            this.ReleaseDateCol.HeaderText = "Release Date";
            this.ReleaseDateCol.Name = "ReleaseDateCol";
            // 
            // ReleaseYearCol
            // 
            this.ReleaseYearCol.HeaderText = "Release Year";
            this.ReleaseYearCol.Name = "ReleaseYearCol";
            // 
            // RatingCol
            // 
            this.RatingCol.HeaderText = "Movie Rating";
            this.RatingCol.Name = "RatingCol";
            // 
            // CostCol
            // 
            this.CostCol.HeaderText = "Production Cost";
            this.CostCol.Name = "CostCol";
            // 
            // RevenueCol
            // 
            this.RevenueCol.HeaderText = "Total Revenue";
            this.RevenueCol.Name = "RevenueCol";
            // 
            // uxSearchByLabel
            // 
            this.uxSearchByLabel.AutoSize = true;
            this.uxSearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchByLabel.Location = new System.Drawing.Point(202, 261);
            this.uxSearchByLabel.Name = "uxSearchByLabel";
            this.uxSearchByLabel.Size = new System.Drawing.Size(86, 20);
            this.uxSearchByLabel.TabIndex = 21;
            this.uxSearchByLabel.Text = "Search By:";
            // 
            // uxDatePicker
            // 
            this.uxDatePicker.Location = new System.Drawing.Point(364, 348);
            this.uxDatePicker.Name = "uxDatePicker";
            this.uxDatePicker.Size = new System.Drawing.Size(213, 20);
            this.uxDatePicker.TabIndex = 34;
            // 
            // uxOBCheckList
            // 
            this.uxOBCheckList.BackColor = System.Drawing.SystemColors.Menu;
            this.uxOBCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxOBCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOBCheckList.FormattingEnabled = true;
            this.uxOBCheckList.Items.AddRange(new object[] {
            "Title",
            "Genre",
            "Director",
            "Released Date",
            "Released Year",
            "Rating",
            "Production Cost",
            "Total Revenue"});
            this.uxOBCheckList.Location = new System.Drawing.Point(12, 284);
            this.uxOBCheckList.Name = "uxOBCheckList";
            this.uxOBCheckList.Size = new System.Drawing.Size(152, 168);
            this.uxOBCheckList.TabIndex = 37;
            // 
            // uxOrderByCheckList
            // 
            this.uxOrderByCheckList.BackColor = System.Drawing.SystemColors.Menu;
            this.uxOrderByCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxOrderByCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOrderByCheckList.FormattingEnabled = true;
            this.uxOrderByCheckList.Items.AddRange(new object[] {
            "Title",
            "Genre",
            "Director",
            "Released Date",
            "Released Year",
            "Rating"});
            this.uxOrderByCheckList.Location = new System.Drawing.Point(206, 284);
            this.uxOrderByCheckList.Name = "uxOrderByCheckList";
            this.uxOrderByCheckList.Size = new System.Drawing.Size(152, 126);
            this.uxOrderByCheckList.TabIndex = 38;
            // 
            // uxDBSearchForm
            // 
            this.AccessibleName = "uxRatingRadio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 502);
            this.ControlBox = false;
            this.Controls.Add(this.uxOrderByCheckList);
            this.Controls.Add(this.uxOBCheckList);
            this.Controls.Add(this.uxDatePicker);
            this.Controls.Add(this.uxSearchByLabel);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.uxOrderedByLabel);
            this.Controls.Add(this.uxGenreComboBox);
            this.Controls.Add(this.uxYearComboBox);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxTitleBox);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.uxSearchButton);
            this.Name = "uxDBSearchForm";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.uxDBSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.TextBox uxDirectorBox;
        private System.Windows.Forms.ComboBox uxYearComboBox;
        private System.Windows.Forms.ComboBox uxGenreComboBox;
        private System.Windows.Forms.Label uxOrderedByLabel;
        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Label uxSearchByLabel;
        private System.Windows.Forms.DateTimePicker uxDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYearCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevenueCol;
        private System.Windows.Forms.CheckedListBox uxOBCheckList;
        private System.Windows.Forms.CheckedListBox uxOrderByCheckList;
    }
}