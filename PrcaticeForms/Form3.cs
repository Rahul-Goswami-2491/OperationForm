using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrcaticeForms
{
    public partial class Form3 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();
        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        //for keeps the track of time.
        int timeLeft;

        int flag1 = 1;
        int flag2 = 1;
        int flag3 = 1;
        int flag4 = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                    "Congratulations!");
                Application.Exit();
            }
            else if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

                if (addend1 + addend2 == sum.Value)
                {
                    flag1 = flag1 - 1;
                }
                if(minuend - subtrahend == difference.Value)
                {
                    flag2 = flag2 - 1;
                }
                if(multiplicand * multiplier == product.Value)
                {
                    flag3 = flag3 - 1;
                }
                if(dividend / divisor == quotient.Value)
                {
                    flag4 = flag4 - 1;
                }
                if (flag1 == 0)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Downloads\interface-124464.wav");
                    simpleSound.Play();
                    flag1 = -1;
                }
                if (flag2 == 0)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Downloads\interface-124464.wav");
                    simpleSound.Play();
                    flag2 = -1;
                }
                if (flag3 == 0)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Downloads\interface-124464.wav");
                    simpleSound.Play();
                    flag3 = -1;
                }
                if (flag4 == 0)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Downloads\interface-124464.wav");
                    simpleSound.Play();
                    flag4 = -1;
                }

                if ((timeLeft < 11) && (timeLeft % 2 == 0))
                {
                    timeLabel.BackColor = Color.Red;
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Downloads\beep-01a.wav");
                    simpleSound.Play();
                }
                else
                {
                    timeLabel.BackColor= Color.White;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Downloads\negative_beeps-6008 (1).wav");
                simpleSound.Play();
                MessageBox.Show("You didn't finish in time", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null )
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
