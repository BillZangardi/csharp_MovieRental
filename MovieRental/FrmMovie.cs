using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class frmMovie : Form
    {
        public frmMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            button1.Text = movie.test("Test");
        }
    }
}
