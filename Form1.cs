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
    public partial class Form1 : Form
    {
        double txtBaseCol, txtBaseSngl, txtBaseSplt, txtAreaCol, txtAreaSngle, txtAreaSplt;

        private void txtAreaSngleStory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBasePriceColonial_TextChanged(object sender, EventArgs e)
        {

        }
        //Leave Method
        private void txtBasePriceColonial_Leave(object sender, EventArgs e)
        {
            if (!(txtBasePriceColonial.Text.All(char.IsDigit)) && !(txtBasePriceColonial.Text == ""))
            {
                MessageBox.Show("The Base Price of the Colonial Model is not a valid number!\nPlease try again. ");
            }
        }
        private void txtBasePriceSnglStory_Leave(object sender, EventArgs e)
        {
            if (!(txtBasePriceSnglStory.Text.All(char.IsDigit)) && !(txtBasePriceSnglStory.Text == ""))
            {
                MessageBox.Show("The Base Price of the Single Story Model is not a valid number!\nPlease try again. ");
            }
        }
        private void txtBasePriceSpltNtry_Leave(object sender, EventArgs e)
        {
            if (!(txtBasePriceSpltNtry.Text.All(char.IsDigit)) && !(txtBasePriceSpltNtry.Text == ""))
            {
                MessageBox.Show("The Base Price of the Split Entry Model is not a valid number!\nPlease try again. ");
            }
        }
        private void txtAreaColonial_Leave(object sender, EventArgs e)
        {
            if (!(txtAreaColonial.Text.All(char.IsDigit)) && !(txtAreaColonial.Text == ""))
            {
                MessageBox.Show("The Finished Area in Square Feet of the Colonial Model is not a valid number!\nPlease try again. ");
            }
        }
        private void txtAreaSpltNtry_Leave(object sender, EventArgs e)
        {
            if (!(txtAreaSpltNtry.Text.All(char.IsDigit)) && !(txtAreaSpltNtry.Text == ""))
            {
                MessageBox.Show("The Finished Area in Square Feet of the Split Entry Model is not a valid number!\nPlease try again. ");
            }
        }
        private void txtAreaSngleStory_Leave(object sender, EventArgs e)
        {
            if (!(txtAreaSngleStory.Text.All(char.IsDigit)) && !(txtAreaSngleStory.Text == ""))
            {
                MessageBox.Show("The Finished Area in Square Feet of the Single Story Model is not a valid number!\nPlease try again. ");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSplitEntry_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            {
                txtBasePriceColonial.Text  = null;
                txtBasePriceSpltNtry.Text  = null;
                txtBasePriceSnglStory.Text = null;
                txtAreaColonial.Text       = null;
                txtAreaSpltNtry.Text       = null;
                txtAreaSngleStory.Text     = null;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                txtBaseCol   = Double.Parse(txtBasePriceColonial.Text);
                txtBaseSngl  = Double.Parse(txtBasePriceSnglStory.Text);
                txtBaseSplt  = Double.Parse(txtBasePriceSpltNtry.Text);
                txtAreaCol   = Double.Parse(txtAreaColonial.Text);
                txtAreaSngle = Double.Parse(txtAreaSngleStory.Text);
                txtAreaSplt  = Double.Parse(txtAreaSpltNtry.Text);

                double ppf_colonial = txtBaseCol / txtAreaCol;
                double ppf_single   = txtBaseSngl / txtAreaSngle;
                double ppf_split    = txtBaseSplt / txtAreaSplt;

                String cheap = "Colonial";

                if (ppf_single < ppf_colonial && ppf_single < ppf_split)
                {
                    cheap = "Single-Story";
                }
                else if (ppf_split < ppf_colonial && ppf_split < ppf_single)
                {
                    cheap = "Split Entry";
                }

                MessageBox.Show("The model with the least price per square foot is: " + cheap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\nThere's an input missing!");
            }
        }
    }
}