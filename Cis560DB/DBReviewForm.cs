using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cis560DB
{
    public delegate void enableReviewButton();

    public partial class uxDBReviewForm : Form
    {

        private int _rating;
        private string _movieTitle;
        private string _review;

        public event enableReviewButton SubmitEvent;

        public uxDBReviewForm()
        {
            InitializeComponent();
            /*
             * foreach(string title in movieList){
             *      uxMovietTitleBox.Items.Add(title);
             * }
             */
        }

        private void uxRatingChanged(object sender, EventArgs e)
        {
            _rating = Int32.Parse(uxRatingBox.Text.Substring(0, 1));
        }

        private void uxMovieChanged(object sender, EventArgs e)
        {
            _movieTitle = uxMovietTitleBox.Text;
        }

        private void uxReviewTextBox_TextChanged(object sender, EventArgs e)
        {
            _review = uxReviewTextBox.Text;
        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {          
            if (_rating > 0 && _movieTitle != null && _review != null){                   
                SubmitEvent();
                Close();
            } else {
                MessageBox.Show("Please fill out all fields.");
            }
        }
    }
}
