using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrcaticeForms
{
    public partial class desOperations : Form
    {
        public desOperations()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            if(chkSum.Checked && !(chkDivision.Checked || chkMultiplication.Checked || chkSubtraction.Checked))
            {
                txtResult.Text = Convert.ToInt32(number1 + number2).ToString();
            }else if (chkSubtraction.Checked && !(chkDivision.Checked || chkMultiplication.Checked || chkSum.Checked))
            {
                txtResult.Text = Convert.ToInt32(number1 - number2).ToString();
            }
            else if (chkDivision.Checked && !(chkSum.Checked || chkMultiplication.Checked || chkSubtraction.Checked))
            {
                txtResult.Text = Convert.ToInt32(number1 / number2).ToString();
            }
            else if (chkMultiplication.Checked && !(chkDivision.Checked || chkSum.Checked || chkSubtraction.Checked))
            {
                txtResult.Text = Convert.ToInt32(number1 * number2).ToString();
            }
            else if(!(chkSum.Checked || chkDivision.Checked || chkMultiplication.Checked || chkSubtraction.Checked))
            {
                MessageBox.Show("Please select any option.");
            }
            else
            {
                MessageBox.Show("Please select only one option.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
