using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        double memoryNumber = -1;
        double globalAns = 0;
        double currentNumber = 0;
        double prevNumber = default;
        Operations prevOperation;
        string operation = ""; 
        bool ansShowed = false;

        enum Operations { Add, Minus, Mult, Div, Percent, Reverse, Sqr, Sqrt, DivOne}; 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_mr.Enabled = false;
            btn_mc.Enabled = false;
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            memoryNumber = 0;
            btn_mr.Enabled = false;
            btn_mc.Enabled = false; 
        }

        private void btn_mr_Click(object sender, EventArgs e)
        {
            txtCurrentDisplay.Text = memoryNumber.ToString(); 
        }

        private void btn_mStore_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                memoryNumber = double.Parse(txtCurrentDisplay.Text);
                btn_mc.Enabled = true;
                btn_mr.Enabled = true;
            }
        }

        private void btn_mplus_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                memoryNumber += double.Parse(txtCurrentDisplay.Text);
                btn_mr.Enabled = true;
                btn_mc.Enabled = true;

            }
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            txtDisplayGeneral.Clear();
            txtCurrentDisplay.Clear();
            prevNumber = default;
            currentNumber = default;
            prevOperation = default;
            globalAns = 0; 
        }
        private void btn_clearRow_Click(object sender, EventArgs e)
        {
            txtCurrentDisplay.Clear(); 
        }
        private void btn_backSpace_Click(object sender, EventArgs e)
        {
            if ( txtCurrentDisplay.Text.Length > 0)
            {
                txtCurrentDisplay.Text = txtCurrentDisplay.Text.Remove(txtCurrentDisplay.Text.Length - 1); 
            }
        }

        private void btn_Num_Click(object sender, EventArgs e)
        {
            var t = (sender as Button); 
            if ( t.Text == "." && txtCurrentDisplay.Text.Contains("."))
            {
                return; 
            }
            txtCurrentDisplay.Text += (sender as Button).Text;
            
        }

        private void btn_Operation_Click(object sender, EventArgs e)
        {
            var btnInfo = (Button)sender;
            operation = btnInfo.Text;
            ansShowed = false; 
            currentNumber = double.Parse(txtCurrentDisplay.Text);
            prevNumber = currentNumber; 
            if ( txtCurrentDisplay.Text == "Неправильный формат" || txtCurrentDisplay.Text == "Нельзя делить на ноль" )
            {
                txtCurrentDisplay.Text = "";
                return; 
            }
            if (txtCurrentDisplay.Text.StartsWith("0") && txtCurrentDisplay.Text.Length > 1)
            {
                if (txtCurrentDisplay.Text.ElementAt(1) != '.')
                {
                    txtDisplayGeneral.Text = "";
                    txtCurrentDisplay.Text = "Неправильный формат";
                    return;
                }
            }
            double result = 0f;
            if (!double.TryParse(txtCurrentDisplay.Text, out result))
            {
                txtCurrentDisplay.Text = "";
                return;
            }
            if (ansShowed == true)
            {
                ansShowed = false;
                txtDisplayGeneral.Text = txtCurrentDisplay.Text + btnInfo.Text;
                txtCurrentDisplay.Text = "";
                return;
            }
            // If ans clicked and currentTextField is empty
            if (txtCurrentDisplay.Text.Length == 0 && checkLastElement(txtDisplayGeneral) )
            {
                txtDisplayGeneral.Text = txtDisplayGeneral.Text.Remove(txtDisplayGeneral.Text.Length - 1) + btnInfo.Text;
                return;
            }
            if ( txtCurrentDisplay.Text.Length == 0 && !checkLastElement(txtDisplayGeneral))
            {
                txtDisplayGeneral.Text += btnInfo.Text;
                return; 
            }

            txtDisplayGeneral.Text += currentNumber.ToString();
            //DataTable dt = new DataTable();
            //txtCurrentDisplay.Text = (dt.Compute(txtDisplayGeneral.Text, "").ToString());
            txtCurrentDisplay.Text = "";
            txtDisplayGeneral.Text += btnInfo.Text;
        }

        

        private void btn_DivideOne_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                currentNumber = double.Parse(txtCurrentDisplay.Text);
                performCalculation(Operations.DivOne); 
            }

        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                currentNumber = double.Parse(txtCurrentDisplay.Text);
                performCalculation(Operations.Sqr);
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                currentNumber = double.Parse(txtCurrentDisplay.Text);
                performCalculation(Operations.Sqrt);
            }
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                currentNumber = double.Parse(txtCurrentDisplay.Text);
                performCalculation(Operations.Percent);
            }
        }

        private void btn_reverse_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text.Length > 0)
            {
                currentNumber = double.Parse(txtCurrentDisplay.Text);
                performCalculation(Operations.Reverse);
            }
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            if (txtCurrentDisplay.Text == "Неправильный формат" || txtCurrentDisplay.Text == "Нельзя делить на ноль")
            {
                txtCurrentDisplay.Text = "";
                txtDisplayGeneral.Text = ""; 
                return;
            }
            if (txtCurrentDisplay.Text.StartsWith("0") && txtCurrentDisplay.Text.Length > 1)
            {
                if (txtCurrentDisplay.Text.ElementAt(1) != '.')
                {
                    txtDisplayGeneral.Text = "";
                    txtCurrentDisplay.Text = "Неправильный формат";
                    return;
                }
            }
            //double result = 0f;
            //if (!double.TryParse(txtCurrentDisplay.Text, out result))
            //{
            //    txtCurrentDisplay.Text = "";
            //    return;
            //}

            if ( ansShowed == true)
            {
                txtDisplayGeneral.Text = txtCurrentDisplay.Text + operation + prevNumber;
                DataTable DT = new DataTable();
                ansShowed = true;

                txtCurrentDisplay.Text = txtCurrentDisplay.Text.Replace('.', ',');

                var ANS = 0.0;
                string MessageToUser = "";
                int AnsInt = 0;
                double AnsDouble = 0f; 
                try
                {
                    var ans = DT.Compute((txtDisplayGeneral.Text), "");
                    Console.WriteLine(ans.GetType());
                    if (ans.GetType() == typeof(int))
                    {
                        AnsInt = (int)ans;
                    }
                    if (ans.GetType() == typeof(double))
                    {
                        AnsDouble = (double)ans;
                    }
                    txtCurrentDisplay.Text = ans.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (double.IsInfinity((double)AnsDouble))
                {

                    MessageToUser = "Нельзя делить на ноль";
                    txtCurrentDisplay.Text = MessageToUser;
                }
                if (double.IsNaN(AnsDouble))
                {
                    txtCurrentDisplay.Text = "Not a Number type";
                }
                DT.Reset();
                //ans = Math.Floor(ans * 1000) / 1000; 
                return; 
            }


            if (txtCurrentDisplay.Text.Length != 0)
            {
                txtDisplayGeneral.Text += txtCurrentDisplay.Text;
                double.TryParse(txtCurrentDisplay.Text, out prevNumber);
            }
            DataTable dt = new DataTable();
            ansShowed = true;

            txtCurrentDisplay.Text = txtCurrentDisplay.Text.Replace('.', ',');

            string messageToUser = "";
            double ansDouble = 0f;
            int ansInt = 0;
            try
            {
                var ans = dt.Compute((txtDisplayGeneral.Text), "");
                Console.WriteLine(ans.GetType()); 
                if ( ans.GetType() == typeof(int))
                {
                    ansInt = (int)ans;
                }
                if ( ans.GetType() == typeof(double))
                {
                    ansDouble = (double)ans; 
                }
                txtCurrentDisplay.Text = ans.ToString();
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            if (double.IsInfinity((double)ansDouble))
            {

                messageToUser = "Нельзя делить на ноль";
                txtCurrentDisplay.Text = messageToUser;
            }
            if ( double.IsNaN(ansDouble))
            {
                txtCurrentDisplay.Text = "Not a Number type"; 
            }
            dt.Reset(); 
        }

        private void performCalculation(Operations operation)
        {
            switch (operation)
            {
                case Operations.Add:
                    {
                        if (txtDisplayGeneral.Text.Length != 0)
                        {
                            globalAns += currentNumber;
                            prevNumber = currentNumber;
                            //txtCurrentDisplay.Text = (globalAns).ToString(); 
                        }
                        else
                        {
                            prevNumber = currentNumber;
                            globalAns = currentNumber;
                        }
                        prevOperation = Operations.Add;
                        Console.WriteLine(globalAns);
                    }
                    break;
                case Operations.Minus:
                    {
                        if (txtDisplayGeneral.Text.Length != 0)
                        {
                            globalAns -= currentNumber;
                            prevNumber = currentNumber;
                            //txtCurrentDisplay.Text = (globalAns).ToString();
                        }
                        else
                        {
                            prevNumber = currentNumber;
                            globalAns = currentNumber;
                        }
                        Console.WriteLine(globalAns);
                    }
                    break;
                case Operations.Mult:
                    break;
                case Operations.Div:
                    break;
                case Operations.Percent:
                    {
                        if (prevNumber != default)
                        {
                            txtCurrentDisplay.Text = (prevNumber / (currentNumber * 100)).ToString();
                        }
                    }
                    break;
                case Operations.Reverse:
                    {
                        currentNumber = currentNumber * (-1);
                        txtCurrentDisplay.Text = (currentNumber).ToString();
                    }
                    break;
                case Operations.Sqr:
                    {
                        currentNumber = (currentNumber) * (currentNumber);
                        txtCurrentDisplay.Text = (prevNumber).ToString();
                    }
                    break;
                case Operations.Sqrt:
                    {
                        currentNumber = Math.Floor(Math.Sqrt(currentNumber) * 1000) / 1000;
                        txtCurrentDisplay.Text = (prevNumber).ToString();
                    }
                    break;
                case Operations.DivOne:
                    {
                        currentNumber = Math.Floor((1 / currentNumber) * 1000) / 1000;
                        txtCurrentDisplay.Text = (prevNumber).ToString();
                    }
                    break;
            }
        }

        private bool checkLastElement(TextBox text)
        {
            char last = Convert.ToChar(text.Text.ElementAt(text.Text.Length - 1));
            bool t = false;
            if (last == '-' || last == '+' || last == '*' || last == '/')
            {
                t = true;
            }
            return t;
        }
    }
}