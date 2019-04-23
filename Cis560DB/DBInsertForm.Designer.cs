namespace Cis560DB
{
    partial class uxDBInsertForm
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
            this.uxSearchBar = new System.Windows.Forms.TextBox();
            this.uxMovieLabel = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uxProfitLabel = new System.Windows.Forms.Label();
            this.uxCostLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.uxReviewLabel = new System.Windows.Forms.Label();
            this.uxReviewBox = new System.Windows.Forms.TextBox();
            this.uxAddMovieButton = new System.Windows.Forms.Button();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxSearchBar
            // 
            this.uxSearchBar.Location = new System.Drawing.Point(105, 9);
            this.uxSearchBar.Name = "uxSearchBar";
            this.uxSearchBar.Size = new System.Drawing.Size(260, 20);
            this.uxSearchBar.TabIndex = 1;
            // 
            // uxMovieLabel
            // 
            this.uxMovieLabel.AutoSize = true;
            this.uxMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieLabel.Location = new System.Drawing.Point(12, 9);
            this.uxMovieLabel.Name = "uxMovieLabel";
            this.uxMovieLabel.Size = new System.Drawing.Size(87, 20);
            this.uxMovieLabel.TabIndex = 7;
            this.uxMovieLabel.Text = "Movie Title:";
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorLabel.Location = new System.Drawing.Point(12, 35);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(65, 20);
            this.uxDirectorLabel.TabIndex = 8;
            this.uxDirectorLabel.Text = "Director";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 9;
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingLabel.Location = new System.Drawing.Point(385, 61);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(101, 20);
            this.uxRatingLabel.TabIndex = 14;
            this.uxRatingLabel.Text = "Movie Rating";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Five Stars",
            "Four Stars",
            "Three Stars",
            "Two Stars ",
            "One Star"});
            this.comboBox1.Location = new System.Drawing.Point(498, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "--Select Rating--";
            // 
            // uxProfitLabel
            // 
            this.uxProfitLabel.AutoSize = true;
            this.uxProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProfitLabel.Location = new System.Drawing.Point(12, 61);
            this.uxProfitLabel.Name = "uxProfitLabel";
            this.uxProfitLabel.Size = new System.Drawing.Size(273, 20);
            this.uxProfitLabel.TabIndex = 18;
            this.uxProfitLabel.Text = "Box Office Revenue( per million USD)";
            // 
            // uxCostLabel
            // 
            this.uxCostLabel.AutoSize = true;
            this.uxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCostLabel.Location = new System.Drawing.Point(12, 91);
            this.uxCostLabel.Name = "uxCostLabel";
            this.uxCostLabel.Size = new System.Drawing.Size(249, 20);
            this.uxCostLabel.TabIndex = 19;
            this.uxCostLabel.Text = "Production Cost( per million USD) ";
            this.uxCostLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteCustomSource.AddRange(new string[] {
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Documentary",
            "Horror",
            "Sci-Fi",
            "Space-Opera",
            "Thriller"});
            this.textBox5.Location = new System.Drawing.Point(291, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(291, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 22;
            // 
            // uxReviewLabel
            // 
            this.uxReviewLabel.AutoSize = true;
            this.uxReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReviewLabel.Location = new System.Drawing.Point(11, 115);
            this.uxReviewLabel.Name = "uxReviewLabel";
            this.uxReviewLabel.Size = new System.Drawing.Size(60, 20);
            this.uxReviewLabel.TabIndex = 23;
            this.uxReviewLabel.Text = "Review";
            // 
            // uxReviewBox
            // 
            this.uxReviewBox.Location = new System.Drawing.Point(15, 138);
            this.uxReviewBox.Multiline = true;
            this.uxReviewBox.Name = "uxReviewBox";
            this.uxReviewBox.Size = new System.Drawing.Size(598, 77);
            this.uxReviewBox.TabIndex = 24;
            // 
            // uxAddMovieButton
            // 
            this.uxAddMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddMovieButton.Location = new System.Drawing.Point(15, 221);
            this.uxAddMovieButton.Name = "uxAddMovieButton";
            this.uxAddMovieButton.Size = new System.Drawing.Size(598, 27);
            this.uxAddMovieButton.TabIndex = 17;
            this.uxAddMovieButton.Text = "Add Movie";
            this.uxAddMovieButton.UseVisualStyleBackColor = true;
            this.uxAddMovieButton.Click += new System.EventHandler(this.uxAddMovieButton_Click);
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenreLabel.Location = new System.Drawing.Point(385, 9);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(54, 20);
            this.uxGenreLabel.TabIndex = 25;
            this.uxGenreLabel.Text = "Genre";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(445, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.Text = "--Select Genre--";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(498, 37);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(109, 21);
            this.comboBox3.TabIndex = 28;
            this.comboBox3.Text = "--Select Year--";
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateLabel.Location = new System.Drawing.Point(385, 35);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(107, 20);
            this.uxDateLabel.TabIndex = 27;
            this.uxDateLabel.Text = "Release Date";
            // 
            // uxDBInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 260);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxReviewBox);
            this.Controls.Add(this.uxReviewLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.uxCostLabel);
            this.Controls.Add(this.uxProfitLabel);
            this.Controls.Add(this.uxAddMovieButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxMovieLabel);
            this.Controls.Add(this.uxSearchBar);
            this.Name = "uxDBInsertForm";
            this.Text = "DBInsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxSearchBar;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label uxProfitLabel;
        private System.Windows.Forms.Label uxCostLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label uxReviewLabel;
        private System.Windows.Forms.TextBox uxReviewBox;
        private System.Windows.Forms.Button uxAddMovieButton;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label uxDateLabel;
    }
}

