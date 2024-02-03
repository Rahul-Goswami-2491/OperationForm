using System;
using System.Windows.Forms;

namespace PrcaticeForms
{
    public partial class Form5 : Form
    {
        public double getGovTax()
        {
            if (rdo10per.Checked)
            {
                return 10;
            }
            else if (rdo15per.Checked)
            {
                return 15;
            }
            else if (rdo20per.Checked)
            {
                return 20;
            }
            else
            {
                return 25;
            }
        }

        public double getCharge()
        {
            double charge = 0;
            int flag1 = 0;
            int flag2 = 0;
            int flag3 = 0;
            int flag4 = 0;
            int flag5 = 0;
            double units = 0;
            if (double.TryParse(txtEnterUnits.Text, out double result) || txtEnterUnits.Text == ".")
            {
                if (txtEnterUnits.Text == ".")
                {
                    units = 0;
                }
                else
                {
                    units = Convert.ToDouble(txtEnterUnits.Text);

                }
            }
            else if (txtEnterUnits.Text.ToString() == "")
            {
                txtBillAmount.Text = "0";
            }
            else
            {
                MessageBox.Show("Please enter valid value");
                txtEnterUnits.Text = txtEnterUnits.Text.ToString().Remove(txtEnterUnits.TextLength - 1);
                txtEnterUnits.SelectAll();
            }

            if (!double.TryParse(txt50fifty.Text, out double result3))
            {

                flag1 = 1;
                txt50fifty.Text = "0";
            }
            else if (txt50fifty.Text == "")
            {
                txt50fifty.Text = "0";
            }
            else
            {
                flag1 = 0;
            }

            if (!double.TryParse(txt100hundred.Text, out double result4))
            {
                flag2 = 1;
                txt100hundred.Text = "0";
            }
            else if (txt100hundred.Text == "")
            {
                txt100hundred.Text = "0";
            }
            else
            {
                flag2 = 0;
            }

            if (!double.TryParse(txt200twohundred.Text, out double result5))
            {
                txt200twohundred.Text = "0";
                flag3 = 1;
            }
            else if (txt200twohundred.Text == "")
            {
                txt200twohundred.Text = "0";
            }
            else
            {
                flag3 = 0;
            }
            if (!double.TryParse(txt_400equalfourhundred.Text, out double result6))
            {
                txt_400equalfourhundred.Text = "0";
                flag4 = 1;
            }
            else if (txt_400equalfourhundred.Text == "")
            {
                txt_400equalfourhundred.Text = "0";
            }
            else
            {
                flag4 = 0;
            }
            if (!double.TryParse(txt400fourhundred.Text, out double result7))
            {
                txt400fourhundred.Text = "0";
                flag5 = 1;
            }
            else if (txt400fourhundred.Text == "")
            {
                txt400fourhundred.Text = "0";
            }
            else
            {
                flag5 = 0;
            }

            charge = 0;
            if (units < 50 && flag1 == 0)
            {
                charge = Convert.ToDouble(txt50fifty.Text);
            }
            else if (units < 100 && flag2 == 0)
            {
                charge = Convert.ToDouble(txt100hundred.Text);
            }
            else if (units < 200 && flag3 == 0)
            {
                charge = Convert.ToDouble(txt200twohundred.Text);
            }
            else if (units <= 400 && flag4 == 0)
            {
                charge = Convert.ToDouble(txt_400equalfourhundred.Text);
            }
            else if (units > 400 && flag5 == 0)
            {
                charge = Convert.ToDouble(txt400fourhundred.Text);
            }
            return charge;
        }

        public void getBillAmount()
        {
            Double gov = getGovTax();
            double charge = getCharge();
            Double fix = getFixCharge();

            double fpppa = getFPPPACharge();

            
            //Double charge = 0;
            Double ans = 1;
            double units = 0;
            if (double.TryParse(txtEnterUnits.Text, out double result) || txtEnterUnits.Text == ".")
            {

                if (txtEnterUnits.Text == ".")
                {
                    units = 0;
                    txtEnterUnits.Text = ".";
                }
                else
                {
                    units = Convert.ToDouble(txtEnterUnits.Text);

                }

                ans = (units * charge);
                ans = ans * fpppa;
                ans = ans + fix;
                ans = ans + (ans * (gov / 100));
                if (txtEnterUnits.Text == "0" || charge == 0 || units == 0)
                {
                    txtBillAmount.Text = "0";
                }
                else
                {
                    txtBillAmount.Text = ans.ToString();
                }
            }
            else if (txtEnterUnits.Text.ToString() == "")
            {
                txtBillAmount.Text = "0";
            }
            else
            {
                MessageBox.Show("Please enter valid value");
                txtEnterUnits.Text = txtEnterUnits.Text.ToString().Remove(txtEnterUnits.TextLength - 1);
                txtEnterUnits.SelectAll();
            }
        }

        public double getFPPPACharge()
        {
            double fpppa = 0;
            if (!double.TryParse(txtFPPPACharge.Text, out double result2))
            {
                txtFPPPACharge.Text = "0";
                fpppa = 1;
            }
            else if (txtFPPPACharge.Text == "")
            {
                fpppa = 1;
            }
            else
            {
                fpppa = Convert.ToDouble(txtFPPPACharge.Text);
            }



            return fpppa;
        }

        public double getFixCharge()
        {
            if (rdo10rupees.Checked)
            {
                return 10;
            }
            else if (rdo15rupees.Checked)
            {
                return 15;
            }
            else if (rdo20rupees.Checked)
            {
                return 20;
            }
            else
            {
                return 25;
            }
        }
    }
}
