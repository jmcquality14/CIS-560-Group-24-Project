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
    public delegate void enableInsertButton();

    public partial class uxDBInsertForm : Form
    {
        private string _movieTitle;
        private string _director;
        private string _genre;
        private int _rating;
        private double _revenue;
        private double _productionCost;
        private DateTime _releaseDate;

        public enableInsertButton SubmitEvent;

        public uxDBInsertForm()
        {
            InitializeComponent();
        }

        private void uxTitleBox_TextChanged(object sender, EventArgs e)
        {
            _movieTitle = uxTitleBox.Text;
        }

        private void uxDirectorBox_TextChanged(object sender, EventArgs e)
        {
            _director = uxDirectorBox.Text;
        }

        private void uxGenreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genre = uxGenreBox.Text;
        }

        private void uxRatingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _rating = Int32.Parse(uxRatingBox.Text.Substring(0, 1));
        }

        private void uxProfitBox_TextChanged(object sender, EventArgs e)
        {
            _revenue = Convert.ToDouble(uxProfitBox.Text);
        }

        private void uxCostBox_TextChanged(object sender, EventArgs e)
        {
            _productionCost = Convert.ToDouble(uxCostBox.Text);
        }

        private void uxDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _releaseDate = uxDatePicker.Value.Date;
        }

        private void uxAddMovieButton_Click(object sender, EventArgs e)
        {
            if (_movieTitle != null && _director != null && _releaseDate != null && _rating > 1) {
                SubmitEvent();
                Close();
            } else {
                MessageBox.Show("Please fill out all fields.");
            }
        }

    }
}
