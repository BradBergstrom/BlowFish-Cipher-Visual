using CST407_BlowFish;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
    /// Interaction logic for EncryptionRoundWindow.xaml
    /// </summary>
    public partial class EncryptionRoundWindow : Window
    {
        public static BlowFish blowFish;

        int i = 0;
        int j = 0;
        static int step = 1;
        static string plainText;
        static string currentHex;
        static string fullPlaintextHex;

        static string cipherText = "";
        public EncryptionRoundWindow(string _plainText)
        {
            InitializeComponent();
            plainText = _plainText;

            plainTextLabel.Content += _plainText;
            var plainTextBinary = BlowFish.ConvertStringToBinary(plainText);
            var newPlainTextBinary = BlowFish.PadPlainText(plainTextBinary);

            if (newPlainTextBinary != plainTextBinary)
            {
                plainTextLabel.Content = "Padded Plaintext: " + BlowFish.ConvertBinaryToString(newPlainTextBinary);
            }

            plainTextBinaryLabel.Content += newPlainTextBinary;

            fullPlaintextHex = BlowFish.ConvertBinaryStringToHexString(newPlainTextBinary);
            plainTextHexLabel.Content += fullPlaintextHex;
            nextHexSection();
        }

        private void nextHexSection() {
            
            if(j < fullPlaintextHex.Length)
            {
                currentHex = fullPlaintextHex.Substring(j, 16);
                currentPlainTextHexLabel.Content = "Current Hex: " + currentHex;
                j += 16;
                i = 0;
                step = 0;
                Round(i, currentHex, step);
            } 
        }

        private void Round(int round, string text, int step)
        {
            //step 0
            if(step == 0)
            {
                resetAllLabels();
                roundLabel.Content = "Round " + (round + 1);
                var left = text.Substring(0, 8);
                inputLeftHalfLabel.Content = left;
                var right = text.Substring(8, 8);
                inputRightHalfLabel.Content = right;
                pboxLabel.Content = BlowFish.P[round];
            }
            

            //Step 1
            if (step > 0)
            {
                var left = text.Substring(0, 8);
                var right = text.Substring(8, 8);
                pboxLabel.Content = BlowFish.P[round];
                left = BlowFish.Xor(left, BlowFish.P[round]);
                functionInputlabel.Content = left;

                var fOut = F(left, step);

                //Step 1
                if (step >= 10)
                {
                    skipButton.IsEnabled = false;
                    right = BlowFish.Xor(fOut, right);
                    // swap left and right 
                    nextRoundLeftLabel.Content = right;
                    nextRoundRightLabel.Content = left;
                    currentHex = right + left;
                }
            }            
        }

        private string F(string hex, int step)
        {
            string[] s = new string[4];
            string col0, col1, col2, col3;

            ///step 2
            if (step >= 2)
            {
                col0 = long.Parse(BlowFish.ConvertHexStringToBinaryString(hex.Substring(0, 2))).ToString();
                s0Inputlabel.Content = col0;

                col1 = long.Parse(BlowFish.ConvertHexStringToBinaryString(hex.Substring(2, 2))).ToString();
                s1Inputlabel.Content = col1;

                col2 = long.Parse(BlowFish.ConvertHexStringToBinaryString(hex.Substring(4, 2))).ToString();
                s2Inputlabel.Content = col2;

                col3 = long.Parse(BlowFish.ConvertHexStringToBinaryString(hex.Substring(6, 2))).ToString();
                s3Inputlabel.Content = col3;
                ///step 3
                if (step >= 3)
                {
                    s[0] = BlowFish.S0[Convert.ToInt32(col0, 2)];
                    s0Outputlabel.Content = s[0];
                    ///step 4
                    if (step >= 4)
                    {
                        s[1] = BlowFish.S1[Convert.ToInt32(col1, 2)];
                        s1Outputlabel.Content = s[1];
                        ///step 5
                        if (step >= 5)
                        {
                            s[2] = BlowFish.S2[Convert.ToInt32(col2, 2)];
                            s2Outputlabel.Content = s[2];
                            ///step 6
                            if (step >= 6)
                            {
                                s[3] = BlowFish.S3[Convert.ToInt32(col3, 2)];
                                s3Outputlabel.Content = s[3];
                                ///step 7
                                if (step >= 7)
                                {
                                    var result = BlowFish.BinaryAddition(s[0], s[1]);
                                    addResultLabel.Content = result;
                                    ///step 8
                                    if (step >= 8)
                                    {
                                        result = BlowFish.Xor(result, s[2]);
                                        xorResultLabel.Content = result;
                                        ///step 9
                                        if (step >= 9)
                                        {
                                            result = BlowFish.BinaryAddition(result, s[3]);
                                            finalResultLabel.Content = result;

                                            return result;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }

            return null;

        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            

            //if we have reached the end of one round
            if (step >= 11 && i <= 15)
            {
                i++;
                if (i > 15)
                {
                    // postprocessing 
                    // output whitening
                    var right = currentHex.Substring(0, 8);
                    var left = currentHex.Substring(8, 8);
                    right = BlowFish.Xor(right, BlowFish.P[16]);
                    left = BlowFish.Xor(left, BlowFish.P[17]);
                    cipherText += left + right;

                    if (j < fullPlaintextHex.Length)
                    {
                        nextHexSection();
                    }
                    else
                    {
                        // encryption is done
                        var dper = cipherText;
                        nextButton.IsEnabled = false;
                        skipButton.IsEnabled = false;

                    }
                } else
                {
                    // ready for next round
                    step = 0;
                    Round(i, currentHex, step);
                    step++;
                    skipButton.IsEnabled = true;
                }
               
            } 
            else if (i <= 15)
            {
                Round(i, currentHex, step);
                step++; 
                skipButton.IsEnabled = true;
            }

        }
        private void skipButton_Click(object sender, RoutedEventArgs e)
        {
            step = 11;
            Round(i, currentHex, step);
            skipButton.IsEnabled = false;
        }
        private void resetAllLabels()
        {
            functionInputlabel.Content = "";
            s0Inputlabel.Content = "";
            s1Inputlabel.Content = "";
            s2Inputlabel.Content = "";
            s3Inputlabel.Content = "";
            s0Outputlabel.Content = "";
            s3Outputlabel.Content = "";
            s1Outputlabel.Content = "";
            s2Outputlabel.Content = "";
            addResultLabel.Content = "";
            xorResultLabel.Content = "";
            finalResultLabel.Content = "";
            nextRoundLeftLabel.Content = "";
            nextRoundRightLabel.Content = "";
        }

    }

   
}
