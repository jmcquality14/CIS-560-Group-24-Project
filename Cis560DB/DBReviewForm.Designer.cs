namespace Cis560DB
{
    partial class uxDBReviewForm
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
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxReviewTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uxMovietTitleBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.FormattingEnabled = true;
            this.uxRatingBox.Items.AddRange(new object[] {
            "Five Stars",
            "Four Stars",
            "Three Stars",
            "Two Stars ",
            "One Star"});
            this.uxRatingBox.Location = new System.Drawing.Point(361, 11);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(93, 21);
            this.uxRatingBox.TabIndex = 20;
            this.uxRatingBox.Text = "--Select Rating--";
            this.uxRatingBox.SelectedIndexChanged += new System.EventHandler(this.uxRatingChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Movie Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Movie Title:";
            // 
            // uxReviewTextBox
            // 
            this.uxReviewTextBox.Location = new System.Drawing.Point(15, 54);
            this.uxReviewTextBox.Multiline = true;
            this.uxReviewTextBox.Name = "uxReviewTextBox";
            this.uxReviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxReviewTextBox.Size = new System.Drawing.Size(439, 77);
            this.uxReviewTextBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Review";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Submit Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.uxSubmit_Click);
            // 
            // uxMovietTitleBox
            // 
            this.uxMovietTitleBox.FormattingEnabled = true;
            this.uxMovietTitleBox.Location = new System.Drawing.Point(80, 11);
            this.uxMovietTitleBox.Name = "uxMovietTitleBox";
            this.uxMovietTitleBox.Size = new System.Drawing.Size(199, 21);
            this.uxMovietTitleBox.TabIndex = 29;
            this.uxMovietTitleBox.Text = "--Select Movie--";
            this.uxMovietTitleBox.SelectedIndexChanged += new System.EventHandler(this.uxMovieChanged);
            // 
            // uxDBReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 172);
            this.Controls.Add(this.uxMovietTitleBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxReviewTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "uxDBReviewForm";
            this.Text = "DBReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxReviewTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox uxMovietTitleBox;
    }
}