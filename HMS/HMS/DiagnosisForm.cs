using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
