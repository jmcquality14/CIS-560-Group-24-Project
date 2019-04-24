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
            this.uxCloseButton = new System.Windows.Forms.Button();
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxDirectorBox = new System.Windows.Forms.TextBox();
            this.uxGenreComboBox = new System.Windows.Forms.ComboBox();
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
            this.uxOrderByCheckList = new System.Windows.Forms.CheckedListBox();
            this.uxActotBox = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCloseButton
            // 
            this.uxCloseButton.Location = new System.Drawing.Point(12, 458);
            this.uxCloseButton.Name = "uxCloseButton";
            this.uxCloseButton.Size = new System.Drawing.Size(847, 23);
            this.uxCloseButton.TabIndex = 0;
            this.uxCloseButton.Text = "Close Form";
            this.uxCloseButton.UseVisualStyleBackColor = true;
            this.uxCloseButton.Click += new System.EventHandler(this.uxCloseButton_Click);
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.FormattingEnabled = true;
            this.uxRatingBox.Items.AddRange(new object[] {
            "4 Stars and Above",
            "3 Stars and Above",
            "2 Stars and Above ",
            "1 Star and Above"});
            this.uxRatingBox.Location = new System.Drawing.Point(183, 389);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(213, 21);
            this.uxRatingBox.TabIndex = 1;
            this.uxRatingBox.Text = "--Select Rating--";
            this.uxRatingBox.SelectedIndexChanged += new System.EventHandler(this.uxRatingBox_SelectedIndexChanged);
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Location = new System.Drawing.Point(183, 283);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(213, 20);
            this.uxTitleBox.TabIndex = 2;
            this.uxTitleBox.TextChanged += new System.EventHandler(this.uxTitleBox_TextChanged);
            // 
            // uxDirectorBox
            // 
            this.uxDirectorBox.Location = new System.Drawing.Point(183, 327);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(213, 20);
            this.uxDirectorBox.TabIndex = 5;
            this.uxDirectorBox.TextChanged += new System.EventHandler(this.uxDirectorBox_TextChanged);
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
            this.uxGenreComboBox.Location = new System.Drawing.Point(183, 305);
            this.uxGenreComboBox.Name = "uxGenreComboBox";
            this.uxGenreComboBox.Size = new System.Drawing.Size(213, 21);
            this.uxGenreComboBox.TabIndex = 16;
            this.uxGenreComboBox.Text = "--Select Genre--";
            this.uxGenreComboBox.SelectedIndexChanged += new System.EventHandler(this.uxGenreComboBox_SelectedIndexChanged);
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
            this.uxSearchByLabel.Location = new System.Drawing.Point(21, 260);
            this.uxSearchByLabel.Name = "uxSearchByLabel";
            this.uxSearchByLabel.Size = new System.Drawing.Size(86, 20);
            this.uxSearchByLabel.TabIndex = 21;
            this.uxSearchByLabel.Text = "Search By:";
            // 
            // uxDatePicker
            // 
            this.uxDatePicker.Location = new System.Drawing.Point(183, 368);
            this.uxDatePicker.Name = "uxDatePicker";
            this.uxDatePicker.Size = new System.Drawing.Size(213, 20);
            this.uxDatePicker.TabIndex = 34;
            this.uxDatePicker.ValueChanged += new System.EventHandler(this.uxDatePicker_ValueChanged);
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
            "Actor",
            "Released Date",
            "Rating"});
            this.uxOrderByCheckList.Location = new System.Drawing.Point(25, 283);
            this.uxOrderByCheckList.Name = "uxOrderByCheckList";
            this.uxOrderByCheckList.Size = new System.Drawing.Size(152, 126);
            this.uxOrderByCheckList.TabIndex = 38;
            // 
            // uxActotBox
            // 
            this.uxActotBox.Location = new System.Drawing.Point(183, 347);
            this.uxActotBox.Name = "uxActotBox";
            this.uxActotBox.Size = new System.Drawing.Size(213, 20);
            this.uxActotBox.TabIndex = 39;
            this.uxActotBox.TextChanged += new System.EventHandler(this.uxActotBox_TextChanged);
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(12, 429);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(847, 23);
            this.uxSearchButton.TabIndex = 40;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            // 
            // uxDBSearchForm
            // 
            this.AccessibleName = "uxRatingRadio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 502);
            this.ControlBox = false;
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxActotBox);
            this.Controls.Add(this.uxOrderByCheckList);
            this.Controls.Add(this.uxDatePicker);
            this.Controls.Add(this.uxSearchByLabel);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.uxGenreComboBox);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxTitleBox);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.uxCloseButton);
            this.Name = "uxDBSearchForm";
            this.Text = "Rating";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCloseButton;
        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.TextBox uxDirectorBox;
        private System.Windows.Forms.ComboBox uxGenreComboBox;
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
        private System.Windows.Forms.CheckedListBox uxOrderByCheckList;
        private System.Windows.Forms.TextBox uxActotBox;
        private System.Windows.Forms.Button uxSearchButton;
    }
}