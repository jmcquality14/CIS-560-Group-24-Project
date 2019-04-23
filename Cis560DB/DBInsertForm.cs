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
        public enableInsertButton SubmitEvent;

        public uxDBInsertForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void uxAddMovieButton_Click(object sender, EventArgs e)
        {
            Hide();
            SubmitEvent();
        }
    }
}
