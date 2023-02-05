using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_to_print_image
{

    public partial class Form1 : Form
    {
        class CurrencyConverter
        {
            private Dictionary<string, double> currencyRates = new Dictionary<string, double>
        {
            {"THB-WON", 33.72},
            {"THB-USD", 0.028},
            {"THB-YEN", 3.4}

        };

            public double Convert(string fromCurrency, double amount, string toCurrency)
            {
                string key = fromCurrency + "-" + toCurrency;
                double exchangeRate = currencyRates[key];
                return amount * exchangeRate;
            }
        }
        public Form1()
        {
            InitializeComponent();
            input_money.KeyPress += new KeyPressEventHandler(input_money_KeyPress);
            //input_money.TextChanged += new EventHandler(input_money_TextChanged);
            output_money.ReadOnly = true;
        }
        private void input_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one comma
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        //private void input_money_TextChanged(object sender, EventArgs e)
        //{
        //    int cursorPosition = input_money.SelectionStart;
        //    if (input_money.Text == "")
        //    {
        //        input_money.Text = Convert.ToDecimal("0").ToString("#,##.00");

        //    }
        //    else {
        //        input_money.Text = Convert.ToDecimal(input_money.Text).ToString("#,##.00");

        //    }
        //    input_money.SelectionStart = cursorPosition;
            
            
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrencyConverter converter = new CurrencyConverter();
            if (string.IsNullOrWhiteSpace(input_money.Text) || string.IsNullOrWhiteSpace(input_type.Text) || string.IsNullOrWhiteSpace(output_type.Text))
            {
                MessageBox.Show("Error: No input detected");
                return;
            }
            string imoney = input_money.Text;
            string itype = input_type.Text; 
            string otype = output_type.Text;
            if (double.TryParse(imoney, out double result))
            {
                double convertedAmount = converter.Convert(itype, result, otype);
                output_money.Text = convertedAmount.ToString("#,##0.00");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
