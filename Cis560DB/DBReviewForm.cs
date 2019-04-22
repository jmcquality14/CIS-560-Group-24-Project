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
    public partial class uxDBReviewForm : Form
    {

        int rating;
        string movieTitle;

        public uxDBReviewForm()
        {
            InitializeComponent();
        }

        private void uxRatingChanged(object sender, EventArgs e)
        {
            rating = Int32.Parse(uxRatingBox.Text.Substring(0, 1));
        }

        private void uxMovieChanged(object sender, EventArgs e)
        {
            movieTitle = uxMovietTitleBox.Text;
        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {
            uxReviewTextBox.Clear();
        }

    }
}
