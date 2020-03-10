using CST407_BlowFish;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for FinishedWindow.xaml
    /// </summary>
    public partial class FinishedWindow : Window
    {
        public FinishedWindow(string currentHex, string cipherSoFar, bool isFinished, bool encrypt)
        {
            InitializeComponent();
            cihperTextBox.AppendText(cipherSoFar);
            if(isFinished == true)
            {
                if (encrypt)
                {
                    finLabel.Content = "Complete CipherText:";
                } else
                {
                    finLabel.Content = "Complete Plaintext:";
                }
            }
            var right = currentHex.Substring(0, 8);
            inputLeftLabel.Content = right;
            var left = currentHex.Substring(8, 8);
            inputRightLabel.Content = left;

            if (encrypt)
            {
                p16TextBlock.Text = BlowFish.P[16];
                p17TextBlock.Text = BlowFish.P[17];

                right = BlowFish.Xor(right, BlowFish.P[16]);
                left = BlowFish.Xor(left, BlowFish.P[17]);
                cihperTextBox.AppendText(left + right);
                MainWindow.setCipherText(cihperTextBox.Text);
            }
            else
            {
                p16label.Content = "P[0]";
                p17label.Content = "P[1]";
                p16TextBlock.Text = BlowFish.P[1];
                p17TextBlock.Text = BlowFish.P[0];

                right = BlowFish.Xor(right, BlowFish.P[1]);
                left = BlowFish.Xor(left, BlowFish.P[0]);
                cihperTextBox.AppendText(BlowFish.ConvertHexStringToString(left + right));
                MainWindow.setPlainTextText(cihperTextBox.Text);
            }
        }
    }
}
