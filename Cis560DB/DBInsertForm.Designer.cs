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
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxMovieLabel = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxDirectorBox = new System.Windows.Forms.TextBox();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.uxProfitLabel = new System.Windows.Forms.Label();
            this.uxCostLabel = new System.Windows.Forms.Label();
            this.uxProfitBox = new System.Windows.Forms.TextBox();
            this.uxCostBox = new System.Windows.Forms.TextBox();
            this.uxAddMovieButton = new System.Windows.Forms.Button();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxGenreBox = new System.Windows.Forms.ComboBox();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Location = new System.Drawing.Point(105, 9);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(260, 20);
            this.uxTitleBox.TabIndex = 1;
            this.uxTitleBox.TextChanged += new System.EventHandler(this.uxTitleBox_TextChanged);
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
            // uxDirectorBox
            // 
            this.uxDirectorBox.Location = new System.Drawing.Point(105, 35);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(260, 20);
            this.uxDirectorBox.TabIndex = 9;
            this.uxDirectorBox.TextChanged += new System.EventHandler(this.uxDirectorBox_TextChanged);
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingLabel.Location = new System.Drawing.Point(385, 35);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(101, 20);
            this.uxRatingLabel.TabIndex = 14;
            this.uxRatingLabel.Text = "Movie Rating";
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.FormattingEnabled = true;
            this.uxRatingBox.Items.AddRange(new object[] {
            "5 Stars",
            "4 Stars",
            "3 Stars",
            "2 Stars ",
            "1 Star"});
            this.uxRatingBox.Location = new System.Drawing.Point(505, 34);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(109, 21);
            this.uxRatingBox.TabIndex = 16;
            this.uxRatingBox.Text = "--Select Rating--";
            this.uxRatingBox.SelectedIndexChanged += new System.EventHandler(this.uxRatingBox_SelectedIndexChanged);
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
            // 
            // uxProfitBox
            // 
            this.uxProfitBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Documentary",
            "Horror",
            "Sci-Fi",
            "Space-Opera",
            "Thriller"});
            this.uxProfitBox.Location = new System.Drawing.Point(291, 61);
            this.uxProfitBox.Name = "uxProfitBox";
            this.uxProfitBox.Size = new System.Drawing.Size(74, 20);
            this.uxProfitBox.TabIndex = 21;
            this.uxProfitBox.TextChanged += new System.EventHandler(this.uxProfitBox_TextChanged);
            // 
            // uxCostBox
            // 
            this.uxCostBox.Location = new System.Drawing.Point(291, 93);
            this.uxCostBox.Name = "uxCostBox";
            this.uxCostBox.Size = new System.Drawing.Size(74, 20);
            this.uxCostBox.TabIndex = 22;
            this.uxCostBox.TextChanged += new System.EventHandler(this.uxCostBox_TextChanged);
            // 
            // uxAddMovieButton
            // 
            this.uxAddMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddMovieButton.Location = new System.Drawing.Point(12, 147);
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
            // uxGenreBox
            // 
            this.uxGenreBox.FormattingEnabled = true;
            this.uxGenreBox.Items.AddRange(new object[] {
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
            this.uxGenreBox.Location = new System.Drawing.Point(504, 7);
            this.uxGenreBox.Name = "uxGenreBox";
            this.uxGenreBox.Size = new System.Drawing.Size(110, 21);
            this.uxGenreBox.TabIndex = 26;
            this.uxGenreBox.Text = "--Select Genre--";
            this.uxGenreBox.SelectedIndexChanged += new System.EventHandler(this.uxGenreBox_SelectedIndexChanged);
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateLabel.Location = new System.Drawing.Point(12, 121);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(107, 20);
            this.uxDateLabel.TabIndex = 27;
            this.uxDateLabel.Text = "Release Date";
            // 
            // uxDatePicker
            // 
            this.uxDatePicker.Location = new System.Drawing.Point(148, 121);
            this.uxDatePicker.Name = "uxDatePicker";
            this.uxDatePicker.Size = new System.Drawing.Size(217, 20);
            this.uxDatePicker.TabIndex = 30;
            this.uxDatePicker.ValueChanged += new System.EventHandler(this.uxDatePicker_ValueChanged);
            // 
            // uxDBInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 187);
            this.Controls.Add(this.uxDatePicker);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxGenreBox);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxCostBox);
            this.Controls.Add(this.uxProfitBox);
            this.Controls.Add(this.uxCostLabel);
            this.Controls.Add(this.uxProfitLabel);
            this.Controls.Add(this.uxAddMovieButton);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxMovieLabel);
            this.Controls.Add(this.uxTitleBox);
            this.Name = "uxDBInsertForm";
            this.Text = "DBInsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.Label uxMovieLabel;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.TextBox uxDirectorBox;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.Label uxProfitLabel;
        private System.Windows.Forms.Label uxCostLabel;
        private System.Windows.Forms.TextBox uxProfitBox;
        private System.Windows.Forms.TextBox uxCostBox;
        private System.Windows.Forms.Button uxAddMovieButton;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.ComboBox uxGenreBox;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.DateTimePicker uxDatePicker;
    }
}

