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
    public partial class uxDBMenu : Form
    {

        public uxDBInsertForm uxInsertForm;
        public uxDBSearchForm uxSearchForm;
        public uxDBReviewForm uxReviewForm;

        public uxDBMenu()
        {
            InitializeComponent();
            /*
            //while (1 > 0)
            //{
                if (uxInsertForm != null || uxSearchForm != null || uxReviewForm != null) {
                    uxSearchDBButton.Enabled = false;
                    uxInsertMoviewButton.Enabled = false;
                    uxAddReviewButton.Enabled = false;
                } else {
                    uxSearchDBButton.Enabled = true;
                    uxInsertMoviewButton.Enabled = true;
                    uxAddReviewButton.Enabled = true;
                }            
            //}
            */
        }

        private void uxInsertMovie_Click(object sender, EventArgs e)
        {
            uxInsertForm = new uxDBInsertForm();
            uxInsertForm.Show();
        }

        private void uxSearchDB_Click(object sender, EventArgs e)
        {
            uxSearchForm = new uxDBSearchForm();
            uxSearchForm.Show();
        }

        private void uxAddReview_Click(object sender, EventArgs e)
        {
            uxReviewForm = new uxDBReviewForm();
            uxReviewForm.Show();
        }

        private void checkAvaialability()
        {
            if (uxInsertForm != null || uxSearchForm != null || uxReviewForm != null)
            {
                uxSearchDBButton.Enabled = false;
                uxInsertMoviewButton.Enabled = false;
                uxAddReviewButton.Enabled = false;
            } else {
                uxSearchDBButton.Enabled = true;
                uxInsertMoviewButton.Enabled = true;
                uxAddReviewButton.Enabled = true;
            }
        }

    }
}
