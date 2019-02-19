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
using System.Diagnostics;

namespace Word_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
            cashewGmPlay();
        }

        public int score = 0;
        //scoreNum.Text.ToString() = score; 




        public static string[] cashewWd = new string[] { "CASH", "ACHE", "CASE", "EACH", "WASH", "CHEW", "CHASE", "CASHEW" };
        public static char[] cashewCh = new char[] { 'A', 'C', 'S', 'E', 'H', 'W' };

        public static string[] legendWd = new string[] { "glee", "edge", "lend", "need", "gene", "glen", "ledge", "legend" };
        public static char[] legendCh = new char[] { 'g', 'n', 'l', 'e', 'd', 'e' }; 


        public void cashewGmPlay()
        {

            letter1.Content = cashewCh[0];  
            letter2.Content = cashewCh[1];
            letter3.Content = cashewCh[2];
            letter4.Content = cashewCh[3];
            letter5.Content = cashewCh[4];
            letter6.Content = cashewCh[5];

        }

        public string wordAnswer = "";

        public void cashewGmChk()
        {
            wordAnswer = wordInput.Text.ToString();
            int pos = Array.IndexOf(cashewWd, wordAnswer);
            switch (pos)
            {
                case 0:
                    word1.Text = cashewWd[0];
                    score += 10;
                    break;
                case 1:
                    word2.Text = cashewWd[1];
                    score += 10;
                    break;
                case 2:
                    word3.Text = cashewWd[2];
                    score += 10;
                    break;
                case 3:
                    word4.Text = cashewWd[3];
                    score += 10;
                    break;
                case 4:
                    word5.Text = cashewWd[4];
                    score += 10;
                    break;
                case 5:
                    word6.Text = cashewWd[5];
                    score += 10;
                    break;
                case 6:
                    word7.Text = cashewWd[6];
                    score += 10;
                    break;
                case 7:
                    word8.Text = cashewWd[7];
                    score += 10;
                    break;
                default:
                    wordInput.Text = "Wrong! Try again!";
                    break;
            }

            wordInput.Text = "";
            if (score == 80)
            {
                 

                
            }
            

        }



        private void Letter_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            

            if (wordInput.Text.Contains(btn.Content.ToString()) == false)
                {
                wordInput.Text += btn.Content.ToString();

            }

        }

        

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            cashewGmChk();
        }
    }

    



        
}

