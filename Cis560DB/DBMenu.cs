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
        }

        private void uxInsertMovie_Click(object sender, EventArgs e)
        {
            //if (uxInsertForm == null) {
                uxInsertForm = new uxDBInsertForm();
                uxInsertForm.Show();
            //}
        }

        private void uxSearchDB_Click(object sender, EventArgs e)
        {
            //if (uxSearchForm == null) {
                uxSearchForm = new uxDBSearchForm();
                uxSearchForm.Show();
            //}
        }

        private void uxAddReview_Click(object sender, EventArgs e)
        {
            //if (uxReviewForm == null) {
                uxReviewForm = new uxDBReviewForm();
                uxReviewForm.Show();
            //}
        }
    }
}
