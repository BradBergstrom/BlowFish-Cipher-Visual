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

            p16TextBlock.Text = BlowFish.P[16];
            p17TextBlock.Text = BlowFish.P[17];

            if (encrypt)
            {
                right = BlowFish.Xor(right, BlowFish.P[16]);
                left = BlowFish.Xor(left, BlowFish.P[17]);
                MainWindow.setCipherText(cihperTextBox.Text);
                cihperTextBox.AppendText(left + right);
            }
            else
            {
                right = BlowFish.Xor(right, BlowFish.P[0]);
                left = BlowFish.Xor(left, BlowFish.P[1]);
                MainWindow.setPlainTextText(cihperTextBox.Text);
                cihperTextBox.AppendText(left + right);
            }

        }
    }
}
