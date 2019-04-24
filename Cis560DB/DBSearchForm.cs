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
    public delegate void enableSearchButton();

    public partial class uxDBSearchForm : Form
    {
        public event enableSearchButton SubmitEvent;

        private string _title;
        private string _genre;
        private string _director;
        private string _actor;
        private DateTime _releaseDate;
        private int _rating;

        public uxDBSearchForm()
        {
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            /*
             

            */
        }

        private void uxCloseButton_Click(object sender, EventArgs e)
        {

            SubmitEvent();
            Close();
        }

        private void uxTitleBox_TextChanged(object sender, EventArgs e)
        {
            _title = uxTitleBox.Text;
        }

        private void uxGenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genre = uxGenreComboBox.Text;
        }

        private void uxDirectorBox_TextChanged(object sender, EventArgs e)
        {
            _director = uxDirectorBox.Text;
        }

        private void uxActotBox_TextChanged(object sender, EventArgs e)
        {
            _actor = uxActotBox.Text;
        }

        private void uxDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _releaseDate = uxDatePicker.Value.Date;
        }

        private void uxRatingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _rating = Int32.Parse(uxRatingBox.Text.Substring(0, 1));
        }
    }
}
