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

namespace Game_Connect_Four
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        public bool player1 = true;

        public int[,] c4 = new int[7, 6];
        public int count1 = 0;
        public int count2 = 0;

        void Initialise()
        {
            TurnLabel.Content = "PLAYER 1 (BLUE)'s TURN";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Box(0);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Box(1);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Box(2);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Box(3);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Box(4);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Box(5);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Box(6);
        }

        public void Box(int col)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (c4[col, i] == 0)
                {
                    if (player1)
                    {
                        c4[col, i] = 1;
                        var test = new Label();
                        var brush = new BrushConverter();
                        test.Background = (Brush)brush.ConvertFromString("#0460f4");
                        Grid.SetColumn(test, col);
                        Grid.SetRow(test, i);
                        cgrid.Children.Add(test);
                        player1 = false;
                        TurnLabel.Content = "PLAYER 2 (RED)'s TURN";
                        Win(col, i);
                        break;
                    }
                    else
                    {
                        c4[col, i] = 2;
                        var test = new Label();
                        var brush = new BrushConverter();
                        test.Background = (Brush)brush.ConvertFromString("#ea0707");
                        Grid.SetColumn(test, col);
                        Grid.SetRow(test, i);
                        cgrid.Children.Add(test);
                        player1 = true;
                        TurnLabel.Content = "PLAYER 1 (BLUE)'s TURN";
                        Win(col, i);
                        break;
                    }
                }
            }
        }

        public void Win(int col, int row)
        {         
            for (int i = 0; i < 4; i++)
            {
                Check((row - i), col);
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check((row + i), col);
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check(row, (col - i));
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check(row, (col + i));
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check((row - i), (col - i));
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check((row + i), (col + i));
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check((row + i), (col - i));
            }
            WinText();
            for (int i = 0; i < 4; i++)
            {
                Check((row - i), (col + i));
            }
            WinText();
        }

        public int Check (int col, int row)
        { 
            try
            {
                if (c4[row , col] == 1)
                { 
                    count1++; 
                }
                else if (c4[row, col] == 2)
                {
                    count2++;
                }
                else if (c4[row, col] == 0)
                {
                    return count1;
                }
            }
            catch { }            
            return count1;
        }

        public void WinText ()
        {
            if (count1 == 4)
            {
                MessageBox.Show("Winner player 1");
            }
            else if (count2 == 4)
            {
                MessageBox.Show("Winner player 2");
            }
            count1 = 0;
            count2 = 0;
        }
    }
}
