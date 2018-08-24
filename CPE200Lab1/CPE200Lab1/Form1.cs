using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public double FirstNumber { get; private set; }
        public string Operation { get; private set; }
        double Result;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Operation = ((Button)sender).Text;
        
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "1";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "1";
                }
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "2";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "2";
                }
            }
            
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "3";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "3";
                }
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "4";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "4";
                }
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "5";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "5";
                }
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "6";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "6";
                }
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "7";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "7";
                }
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "8";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "8";
                }
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = "9";
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + "9";
                }
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text.Length < 8)
                {
                    if (lblDisplay.Text == "0")
                    {
                        lblDisplay.Text = "0";
                    }
                    else
                    {
                        lblDisplay.Text = lblDisplay.Text + "0";
                    }
                }
            }
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
           
            {
                if (lblDisplay.Text.Contains(".") == false)
                {
                    lblDisplay.Text = lblDisplay.Text + ".";
                }

            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            {
                FirstNumber = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = "0";
                Operation = "+";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            {
                FirstNumber = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = "0";
                Operation = "-";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            {
                FirstNumber = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = "0";
                Operation = "*";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            {
                FirstNumber = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = "0";
                Operation = "/";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            {
                double SecondNumber;
                double Result;

                SecondNumber = Convert.ToDouble(lblDisplay.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    lblDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    lblDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    lblDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        lblDisplay.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        lblDisplay.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
                if (Operation == "%")
                {
                    Result = (FirstNumber * SecondNumber) / 100;
                    lblDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if(lblDisplay.Text.Length > 8 && lblDisplay.Text.Contains('.') == false)
                {
                    lblDisplay.Text = "Error!";
                }
                if (lblDisplay.Text.Length > 9 && lblDisplay.Text.Contains('.') == true)
                {
                    lblDisplay.Text = "Error!";
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }
    
        private void btnSign_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            
            SecondNumber = double.Parse(lblDisplay.Text);
            SecondNumber = (SecondNumber / 100) * FirstNumber;
            if(Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
            }
            else
            {
                if (Operation == "-")
                {
                    Result = FirstNumber - SecondNumber;
                }
                lblDisplay.Text = Result.ToString();
            }
        }
    }

}
