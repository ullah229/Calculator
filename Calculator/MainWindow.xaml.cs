using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "1";
            }
            else
            {
                textbox1.Text = textbox1.Text + "1";

            }
            path.Text += "1";
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "2";
            }
            else
            {
                textbox1.Text = textbox1.Text + "2";
            }
            path.Text += "2";
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "3";
            }
            else
            {
                textbox1.Text = textbox1.Text + "3";
            }
            path.Text = path.Text += "3";
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "4";
            }
            else
            {
                textbox1.Text = textbox1.Text + "4";
            }
            path.Text = path.Text += "4";
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "5";
            }
            else
            {
                textbox1.Text = textbox1.Text + "5";
            }
            path.Text = path.Text += "5";
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "6";
            }
            else
            {
                textbox1.Text = textbox1.Text + "6";
            }
            path.Text = path.Text += "6";
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "7";
            }
            else
            {
                textbox1.Text = textbox1.Text + "7";
            }
            path.Text = path.Text += "7";
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "8";
            }
            else
            {
                textbox1.Text = textbox1.Text + "8";
            }
            path.Text = path.Text += "8";
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "9";
            }
            else
            {
                textbox1.Text = textbox1.Text + "9";
            }
            path.Text = path.Text += "9";
        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "0";
            }
            else
            {
                textbox1.Text = textbox1.Text + "0";
            }
            path.Text = path.Text += "0";
        }
        private void buttondot_Click(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text += ".";
            }
            else
            {
                textbox1.Text = textbox1.Text + ".";
            }
            path.Text = path.Text += ".";
        }

        private void buttonad_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "+";
            path.Text += "+";
        }
        private void buttonsub_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "-";
            path.Text += "-";
        }
        private void buttonmul_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "*";
            path.Text += "*";
        }
        private void buttondiv_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "/";
            path.Text += "/";
        }

        public void buttoneq_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string value = new DataTable().Compute(textbox1.Text, null).ToString();
                string newvalue = value.Replace(",", ".");
                textbox1.Text = newvalue;
                path.Text = newvalue;
            }
            catch (Exception)
            {
                textbox1.Text = "Something went wrong. I can feel it!";
            }
        }



        private void buttonc_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0";
            path.Text = "0";
        }

        private void buttondel_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != string.Empty)
            {
                textbox1.Text = textbox1.Text.Remove(textbox1.Text.Length - 1);
                path.Text = path.Text.Remove(path.Text.Length - 1);
            }
            else if (textbox1.Text == string.Empty)
            {
                textbox1.Text = "0";
                path.Text = "0";
            }
        }

        private void textbox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9.+-/*]+").IsMatch(e.Text);
        }

        private void Pi_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text += Math.PI;
            }
            else
            {
                textbox1.Text = textbox1.Text + Math.PI;
            }
            path.Text = path.Text += Math.PI;
        }
    }

}
