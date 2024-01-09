using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem2Model_House
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLoadMode.Width += 2;

            if (pnlLoadMode.Width >= 500)
            {
                timer1.Stop();
                this.Hide();
                Form1 mode = new Form1();
                mode.Closed += (s, args) => this.Close();
                mode.Show();
            }
        }

        private void lblLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
