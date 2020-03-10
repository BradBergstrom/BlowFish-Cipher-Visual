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
        public static BlowFish blowFish;

        public MainWindow()
        {
            InitializeComponent();
            blowFish = new BlowFish();
        }

        public void onGeneratePBox(object sender, RoutedEventArgs e)
        {
            //blowFish.SetupKey(keyTextBox.Text);

            PBoxWindow keyWindow = new PBoxWindow(keyTextBox.Text);
            keyWindow.Show();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            if(keyTextBox.Text != "")
            {
                blowFish.SetupKey(keyTextBox.Text);
                EncryptionRoundWindow encrpyt = new EncryptionRoundWindow(plainTextBox.Text);
                encrpyt.Show();
            }
        }
    }
}
