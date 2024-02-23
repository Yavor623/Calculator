using Microsoft.VisualBasic.Logging;
using CalculatorLogic;
using System.Text;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        private Calculations logic;
        private string firstNumber;
        private string secondNumber;
        private string operation;
        private string secondOperation;
        public Form1()
        {
            logic = new Calculations();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string result;

        public Form1(string firstNumber, string secondNumber, string operation)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.operation = operation;
        }
        private void onebtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "1";
                placeHolderLabelOfScreen.Text = "1";
            }
            else
            {
                resulttxt.Text += "1";
                placeHolderLabelOfScreen.Text += "1";
            }
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "2";
                placeHolderLabelOfScreen.Text = "2";
            }
            else
            {
                resulttxt.Text += "2";
                placeHolderLabelOfScreen.Text += "2";
            }
        }



        private void sixbtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "6";
                placeHolderLabelOfScreen.Text = "6";
            }
            else
            {
                resulttxt.Text += "6";
                placeHolderLabelOfScreen.Text += "6";
            }
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "5";
                placeHolderLabelOfScreen.Text = "5";
            }
            else
            {
                resulttxt.Text += "5";
                placeHolderLabelOfScreen.Text += "5";
            }
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "4";
                placeHolderLabelOfScreen.Text = "4";
            }
            else
            {
                resulttxt.Text += "4";
                placeHolderLabelOfScreen.Text += "4";
            }
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "7";
                placeHolderLabelOfScreen.Text = "7";
            }
            else
            {
                resulttxt.Text += "7";
                placeHolderLabelOfScreen.Text += "7";
            }
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "8";
                placeHolderLabelOfScreen.Text = "8";
            }
            else
            {
                resulttxt.Text += "8";
                placeHolderLabelOfScreen.Text += "8";
            }

        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "9";
                placeHolderLabelOfScreen.Text = "9";
            }
            else
            {
                resulttxt.Text += "9";
                placeHolderLabelOfScreen.Text += "9";
            }
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
           
            MainOperation();
            resulttxt.Text = result;
            placeHolderLabelOfScreen.Text += "=";
            if (result != null)
            {
                placeHolderLabelOfScreen.Text = result;
            }
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            this.firstNumber = resulttxt.Text;
            operation = "+";
            if (operation == "%")
            {
                secondOperation = "+";

            }
            resulttxt.Text = string.Empty;
            placeHolderLabelOfScreen.Text += "+";
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            this.firstNumber = resulttxt.Text;

            operation = "-";
            if (operation == "%")
            {
                secondOperation = "-";

            }
            resulttxt.Text = string.Empty;
            placeHolderLabelOfScreen.Text += "-";

        }

        private void removeAllbtn_Click(object sender, EventArgs e)
        {
            resulttxt.Text = "0";
            placeHolderLabelOfScreen.Text = string.Empty;
        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text != "0")
            {
                resulttxt.Text += "0";
                placeHolderLabelOfScreen.Text += "0";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }
        public void MainOperation()
        {
            if (operation != null)
            {
                this.secondNumber = resulttxt.Text;
                double fn;
                double sn;
               
                    switch (operation)
                    {
                        case "+":

                            double.TryParse(firstNumber, out fn);
                            double.TryParse(secondNumber, out sn);
                            double finalResult = logic.Adding(fn, sn);
                            result = $"{finalResult}";
                            break;
                        case "-":
                            double.TryParse(firstNumber, out fn);
                            double.TryParse(secondNumber, out sn);
                            double finalResult1 = logic.Substraction(fn, sn);
                            result = $"{finalResult1}";
                            break;
                        case "*":
                            double.TryParse(firstNumber, out fn);
                            double.TryParse(secondNumber, out sn);
                            double finalResult2 = logic.Multiplicaton(fn, sn);
                            result = $"{finalResult2}";
                            break;
                        case "/":
                            double.TryParse(firstNumber, out fn);
                            double.TryParse(secondNumber, out sn);
                            string finalResult3 = logic.Division(fn, sn);
                            result = finalResult3;
                            break;
                        case "%":
                            double.TryParse(firstNumber, out fn);
                            double.TryParse(secondNumber, out sn);
                        double finalResult4;
                        break;
                    }
                
                
            }


        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = "3";
                placeHolderLabelOfScreen.Text = "3";
            }
            else
            {
                resulttxt.Text += "3";
                placeHolderLabelOfScreen.Text += "3";
            }
        }

        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            this.firstNumber = resulttxt.Text;

            operation = "*";
            if (operation == "%")
            {
                secondOperation = "*";

            }
            resulttxt.Text = string.Empty;
            placeHolderLabelOfScreen.Text += "×";
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            this.firstNumber = resulttxt.Text;

            operation = "/";
            if (operation == "%")
            {
                secondOperation = "/";

            }
            resulttxt.Text = string.Empty;
            placeHolderLabelOfScreen.Text += "÷";
        }

        private void negatebtn_Click(object sender, EventArgs e)
        {
            double result = double.Parse(resulttxt.Text);
            result = result * -1;
            resulttxt.Text = result.ToString();
        }

        private void removeLastOnebtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text != string.Empty)
            {
                StringBuilder sb = new StringBuilder();
                sb.Remove(resulttxt.Text.Length - 1, 1);
                resulttxt.Text = sb.ToString();
            }
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            placeHolderLabelOfScreen.Text = $"²√{resulttxt.Text}";
            double result = double.Parse(resulttxt.Text);
            result = logic.SquareRoot(result);
            resulttxt.Text = result.ToString();
        }

        private void byThePowerOf2Btn_Click(object sender, EventArgs e)
        {
            placeHolderLabelOfScreen.Text = $"{resulttxt.Text}²";
            double result = double.Parse(resulttxt.Text);
            result= Math.Pow(result, 2);
            resulttxt.Text = result.ToString();
        }

        private void XDividedBy1Btn_Click(object sender, EventArgs e)
        {
            placeHolderLabelOfScreen.Text = $"1/{resulttxt.Text}";
            double result = double.Parse(resulttxt.Text);
            result = logic.XBelow1(result);
            resulttxt.Text = result.ToString();
        }

        private void percentbtn_Click(object sender, EventArgs e)
        {
            this.firstNumber = resulttxt.Text;

            operation = "%";
            placeHolderLabelOfScreen.Text += "%";
        }

        private void removeLastbtn_Click(object sender, EventArgs e)
        {

        }

        private void commabtn_Click(object sender, EventArgs e)
        {
            resulttxt.Text += ",";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void resulttxt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    zerobtn.PerformClick();
                    break;
                case Keys.D1:
                    onebtn.PerformClick();
                    break;
                case Keys.D2:
                    twobtn.PerformClick();
                    break;
                case Keys.D3:
                    threebtn.PerformClick();
                    break;
                case Keys.D4:
                    fourbtn.PerformClick();
                    break;
                case Keys.D5:
                    fivebtn.PerformClick();
                    break;
                case Keys.D6:
                    sixbtn.PerformClick();
                    break;
                case Keys.D7:
                    sevenbtn.PerformClick();
                    break;
                case Keys.D8:
                    eightbtn.PerformClick();
                    break;
                case Keys.D9:
                    ninebtn.PerformClick();
                    break;
                case Keys.Decimal:
                    commabtn.PerformClick();
                    break;
                    /*case Keys.D1:
                        onebtn.PerformClick();
                        break;
                    case Keys.D1:
                        onebtn.PerformClick();
                        break;
                    case Keys.D1:
                        onebtn.PerformClick();
                        break;*/
            }
        }
    }
}