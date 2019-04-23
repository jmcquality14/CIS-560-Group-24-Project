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

        public uxDBSearchForm()
        {
            InitializeComponent();

        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            Hide();
            SubmitEvent();
        }
    }
}
