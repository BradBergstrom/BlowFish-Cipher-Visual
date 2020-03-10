using CST407_BlowFish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlowFish_Cypher_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow me;
        public static BlowFish blowFish;
        public static bool areKeysSetup;

        public static void setCipherText(string text)
        {
            me.cipherTextBox.Text = text;
        }
        public static void setPlainTextText(string text)
        {
            me.plainTextBox.Text = text;
        }

        public MainWindow()
        {
            InitializeComponent();
            me = this;
            areKeysSetup = false;
            blowFish = new BlowFish();
        }

        public void onGeneratePBox(object sender, RoutedEventArgs e)
        {
            //blowFish.SetupKey(keyTextBox.Text);
            areKeysSetup = true;
            PBoxWindow keyWindow = new PBoxWindow(keyTextBox.Text);
            keyWindow.Show();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            if(keyTextBox.Text != "")
            {
                if(areKeysSetup == false)
                {
                    blowFish.SetupKey(keyTextBox.Text);
                }
                EncryptionRoundWindow encrpyt = new EncryptionRoundWindow(plainTextBox.Text, true);
                encrpyt.Show();
            }
        }

        private void decryptButton_Click(object sender, RoutedEventArgs e)
        {
            if (keyTextBox.Text != "")
            {
                if (areKeysSetup == false)
                {
                    blowFish.SetupKey(keyTextBox.Text);
                }
                EncryptionRoundWindow encrpyt = new EncryptionRoundWindow(cipherTextBox.Text, false);
                encrpyt.Show();
            }
        }
    }
}
