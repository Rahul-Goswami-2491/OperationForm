using System;
using System.Linq;
using System.Windows.Forms;

namespace PrcaticeForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            DeligateHandler();
        }

        private void DeligateHandler()
        {
            btnClose.Click += BtnClose_Click;
            btnClose.BackColorChanged += BtnClose_BkColorChange;



        }
        private void BtnClose_BkColorChange(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        public void getUserValue(object sender, EventArgs e)
        {
            getBillAmount();
        } 
    }
}
