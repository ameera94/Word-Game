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
            LevelOne();
            GmPlay();
            GmChk();
        }

        public int score = 70;
        

        public static string[] WordsArr = new string[8];
        public static string[] WordsArr1 = new string[] { "CASH", "ACHE", "CASE", "EACH", "WASH", "CHEW", "CHASE", "CASHEW" };
        public static string[] WordsArr2 = new string[] { "GLEE", "EDGE", "LEND", "NEED", "GENE", "GLEN", "LEDGE", "LEGEND" };
        public static string[] WordsArr3 = new string[] { "OUCH", "HOUR", "RUSH", "OURS", "SUCH", "SOUR", "CRUSH", "CHORUS" };
        public static string[] WordsArr4 = new string[] { "UNDO", "LOAD", "LOUD", "LOAN", "LAND", "DUAL", "ALOUD", "UNLOAD" };
        public static string[] WordsArr5 = new string[] { "IRIS", "TIPS", "TRIP", "SPIT", "PITS", "RIPS", "STRIP", "SPIRIT" };
        public static string[] WordsArr6 = new string[] { "COIN", "IONS", "CONS", "SCAN", "CANS", "ICON", "SONIC", "CASINO" };
        public static string[] WordsArr7 = new string[] { "LOBE", "BILE", "LIMO", "LIME", "LIMB", "MILE", "LIMBO", "MOBILE" };
        public static string[] WordsArr8 = new string[] { "FLAW", "FLOW", "WOLF", "FALL", "LOAF", "FOWL", "ALLOW", "FALLOW" };
        public static string[] WordsArr9 = new string[] { "SLAY", "ALMS", "SLUM", "ALUM", "SLAM", "YAMS", "MAULS", "ASYLUM" };



        public static char[] CharArr = new char[6];
        public static char[] CharArr1 = new char[] { 'A', 'C', 'S', 'E', 'H', 'W' };
        public static char[] CharArr2 = new char[] { 'G', 'N', 'L', 'E', 'D', 'E' };
        public static char[] CharArr3 = new char[] { 'R', 'O', 'C', 'H', 'S', 'U' };
        public static char[] CharArr4 = new char[] { 'L', 'A', 'U', 'N', 'D', 'O' };
        public static char[] CharArr5 = new char[] { 'I', 'R', 'S', 'P', 'I', 'T' };
        public static char[] CharArr6 = new char[] { 'I', 'N', 'C', 'A', 'S', 'O' };
        public static char[] CharArr7 = new char[] { 'B', 'L', 'E', 'O', 'M', 'I' };
        public static char[] CharArr8 = new char[] { 'L', 'O', 'L', 'W', 'A', 'F' };
        public static char[] CharArr9 = new char[] { 'Y', 'U', 'M', 'S', 'A', 'L' };

        public static List<Button> buttonList = new List<Button>();

        public int level = 1;
        public int n = 1;

           
        public void LevelOne()
        {
            for (int i = 0; i < WordsArr.Length; i++)
            {
                WordsArr[i] = WordsArr1[i];

            }

            for (int i = 0; i < CharArr.Length; i++)
            {
                CharArr[i] = CharArr1[i];

            }

            
        }
        
        //Resets levels button characters and text blocks and words. 
        public void GmPlay()
        {            
                letter1.Content = CharArr[0];
                letter2.Content = CharArr[1];
                letter3.Content = CharArr[2];
                letter4.Content = CharArr[3];
                letter5.Content = CharArr[4];
                letter6.Content = CharArr[5];

            if (word1.Text == "* * * *")
            {
                word1.Text = "* * * *";
            }
            if (word2.Text == "* * * *")
            {
                word2.Text = "* * * *";
            }
            if (word3.Text == "* * * *")
            {
                word3.Text = "* * * *";
            }
            if (word4.Text == "* * * *")
            {
                word4.Text = "* * * *";
            }
            if (word5.Text == "* * * *")
            {
                word5.Text = "* * * *";
            }
            if (word6.Text == "* * * *")
            {
                word6.Text = "* * * *";
            }
            if (word1.Text == "* * * * *")
            {
                word7.Text = "* * * * *";
            }
            if (word1.Text == "* * * * * *")
            {
                word8.Text = "* * * * * *";
            }
        }

        public string wordAnswer = "";
        
        public void GmChk()
        {
            if (score == n * 80)
           {
                level++;
                n++;
                
            }


            switch (level)
            {
                case 2:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr2[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr2[i];

                    }
                    GmPlay();
                    break;
                case 3:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr3[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr3[i];

                    }
                    GmPlay();
                    break;
                case 4:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr4[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr4[i];

                    }
                    GmPlay();
                    break;
                case 5:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr5[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr5[i];

                    }
                    GmPlay();
                    break;
                case 6:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr6[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr6[i];

                    }
                    GmPlay();
                    break;
                case 7:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr7[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr7[i];

                    }
                    GmPlay();
                    break;
                case 8:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr8[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr8[i];

                    }
                    GmPlay();
                    break;
                case 9:
                    for (int i = 0; i < WordsArr.Length; i++)
                    {
                        WordsArr[i] = WordsArr9[i];

                    }
                    for (int i = 0; i < CharArr.Length; i++)
                    {
                        CharArr[i] = CharArr9[i];

                    }
                    break;
            }

            wordAnswer = wordInput.Text.ToString();
            int pos = Array.IndexOf(WordsArr, wordAnswer);
            
            switch (pos)
            {
                case 0:
                    if (word1.Text == "* * * *")
                    {
                        word1.Text = WordsArr[0];
                        score += 10;
                    }                    
                    break;
                case 1:
                    word2.Text = WordsArr[1];
                    score += 10; 
                    break;
                case 2:
                    word3.Text = WordsArr[2];
                    score += 10;
                    break;
                case 3:
                    word4.Text = WordsArr[3];
                    score += 10;
                    break;
                case 4:
                    word5.Text = WordsArr[4];
                    score += 10;
                    break;
                case 5:
                    word6.Text = WordsArr[5];
                    score += 10;
                    break;
                case 6:
                    word7.Text = WordsArr[6];
                    score += 10;
                    break;
                case 7:
                    word8.Text = WordsArr[7];
                    score += 10;
                    break;
                default:
                    wordInput.Text = "Wrong! Try again!";
                    break;
            }

            wordInput.Text = "";

            

            scoreNum.Text = score.ToString();
        }






        private void Letter_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;


            //if (wordInput.Text.Contains(btn.Content.ToString()) == false)
            //    {
            //    wordInput.Text += btn.Content.ToString();

            //}
            btn.IsEnabled = false;
            wordInput.Text += btn.Content.ToString();
            buttonList.Add(btn);

        }

        

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
             GmChk();
            foreach (var elem in buttonList)
            {
                elem.IsEnabled = true;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            foreach (var elem in buttonList) {
                elem.IsEnabled = true;
            }
            wordInput.Text = "";
        }
    }

    



        
}

