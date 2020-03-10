using CST407_BlowFish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlowFish_Cypher_App
{
    /// <summary>
    /// Interaction logic for PBoxWindow.xaml
    /// </summary>
    public partial class PBoxWindow : Window
    {
        private static char xorChar = '⊕';
        private static string hexKey;
        private static int i;
        private static int j;

        public PBoxWindow(string key)
        {
            InitializeComponent();
            i = 0;
            j = 0;

            hexKey = BlowFish.ConvertStringToBinary(key);
            hexKey = BlowFish.PadKey(hexKey);
            keyTextBox.Text = hexKey;
            
            string keys = "";
            foreach(string subKey in BlowFish.P)
            {
                keys += subKey + ", ";
            }
            PboxTextBox_before.Text = keys.Substring(0, keys.Length - 1);
        }
        
        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            string currentCalculation = BlowFish.P[i] + " " + xorChar + " " + hexKey.Substring(j, 8) + " = " + BlowFish.Xor(BlowFish.P[i], hexKey.Substring(j, 8));
            XOR_TextBlock.Text = currentCalculation;
            PboxTextBox_after.Text += BlowFish.Xor(BlowFish.P[i], hexKey.Substring(j, 8)) + ", ";

            j = (j + 8) % hexKey.Length;
            i++;
            if (i == BlowFish.P.Length)
            {
                nextButton.IsEnabled = false;
                nextButton.Visibility = Visibility.Hidden;
                skipButton.IsEnabled = false;
                finishButton.Visibility = Visibility.Visible;
                finishButton.IsEnabled = true;
            }
        }

        private void skipButton_Click(object sender, RoutedEventArgs e)
        {
            while(i < BlowFish.P.Length)
            {
                string currentCalculation = BlowFish.P[i] + " " + xorChar + " " + hexKey.Substring(j, 8) + " = " + BlowFish.Xor(BlowFish.P[i], hexKey.Substring(j, 8));
                XOR_TextBlock.Text = currentCalculation;
                PboxTextBox_after.Text += BlowFish.Xor(BlowFish.P[i], hexKey.Substring(j, 8)) + ", ";

                j = (j + 8) % hexKey.Length;
                i++;
            }
            nextButton.IsEnabled = false;
            nextButton.Visibility = Visibility.Hidden;
            skipButton.IsEnabled = false;
            finishButton.Visibility = Visibility.Visible;
            finishButton.IsEnabled = true;
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
