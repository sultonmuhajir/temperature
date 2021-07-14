using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature
{
    public partial class temperature : Form
    {

        public temperature()
        {
            InitializeComponent();
        }

        private void inputClear(TextBox a, TextBox b, TextBox c)
        {
            a.Clear();
            b.Clear();
            c.Clear();
        }

        private void inputEnabled(TextBox a, TextBox b, TextBox c)
        {
            inputClear(a, b, c);
            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
        }

        private void inputDisabled(TextBox a, TextBox b, TextBox c)
        {
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            celsius.Clear();
            fahrenheit.Clear();
            kelvin.Clear();
            reamur.Clear();
        }

        private void celsius_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(celsius.Text))
            {
                inputEnabled(fahrenheit, kelvin, reamur);
            }
            else
            {
                inputDisabled(fahrenheit, kelvin, reamur);
                if (Regex.IsMatch(celsius.Text, "^-?\\d*(\\,\\d+)?$"))
                {
                    float c = float.Parse(celsius.Text);
                    fahrenheit.Text = Math.Round((c*(9/5f))+32, 2).ToString();
                    kelvin.Text = Math.Round(c+273.15, 2).ToString();
                    reamur.Text = Math.Round((4/5f)*c, 2).ToString();
                }
                else
                {
                    inputClear(fahrenheit, kelvin, reamur);
                }
            }
        }

        private void fahrenheit_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(fahrenheit.Text))
            {
                inputEnabled(celsius, kelvin, reamur);
            }
            else
            {
                inputDisabled(celsius, kelvin, reamur);
                if (Regex.IsMatch(fahrenheit.Text, "^-?\\d*(\\,\\d+)?$"))
                {
                    float f = float.Parse(fahrenheit.Text);
                    celsius.Text = Math.Round((f-32)*(5/9f), 2).ToString();
                    kelvin.Text = Math.Round((f-32)*(5/9f)+273.15, 2).ToString();
                    reamur.Text = Math.Round((4/9f)*(f-32), 2).ToString();
                }
                else
                {
                    inputClear(celsius, kelvin, reamur);
                }
            }
        }

        private void kelvin_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(kelvin.Text))
            {
                inputEnabled(celsius, fahrenheit, reamur);
            }
            else
            {
                inputDisabled(celsius, fahrenheit, reamur);
                if (Regex.IsMatch(kelvin.Text, "^-?\\d*(\\,\\d+)?$"))
                {
                    float k = float.Parse(kelvin.Text);
                    celsius.Text = Math.Round(k-273.15, 2).ToString();
                    fahrenheit.Text = Math.Round((k-273.15)*(9/5f)+32, 2).ToString();
                    reamur.Text = Math.Round((4/5f)*(k-273.15), 2).ToString();
                }
                else
                {
                    inputClear(celsius, fahrenheit, reamur);
                }
            }
        }

        private void reamur_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(reamur.Text))
            {
                inputEnabled(celsius, fahrenheit, kelvin);
            }
            else
            {
                inputDisabled(celsius, fahrenheit, kelvin);
                if (Regex.IsMatch(reamur.Text, "^-?\\d*(\\,\\d+)?$"))
                {
                    float r = float.Parse(reamur.Text);
                    celsius.Text = Math.Round((5/4f)*r, 2).ToString();
                    fahrenheit.Text = Math.Round((9/4f)*r+32, 2).ToString();
                    kelvin.Text = Math.Round((5/4f)*r+273.15, 2).ToString();
                }
                else
                {
                    inputClear(celsius, fahrenheit, kelvin);
                }
            }
        }
    }
}
