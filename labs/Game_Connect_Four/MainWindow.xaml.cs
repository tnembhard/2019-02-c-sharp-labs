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

        void Initialise()
        {
            TurnBox.Text = "PLAYER 1 (BLUE)'s TURN";
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
            for (int i = 5; i > (0 - 1); i--)
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
                        TurnBox.Text = "PLAYER 2 (RED)'s TURN";
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
                        TurnBox.Text = "PLAYER 1 (BLUE)'s TURN";
                        Win(col, i);
                        break;
                    }
                }
            }
        }

        public void Win(int col, int row)
        {

            //for (int i = 0; i <= 3; i++)
            //{              
            //    int count1 = 0;
            //    int count2 = 0;

            //    foreach (var cells in WinCon(col, row, i))
            //    {
            //        if (c4[cells[0], cells[1]] == 1)
            //        {
            //            count1++;
            //        }
            //        else if (c4[cells[0], cells[1]] == 2)
            //        {
            //            count2++;
            //        }
            //        else
            //        {
            //            break;
            //        }

            //        if (count1 == 2)
            //        {
            //            MessageBox.Show("Winner player 1");
            //            break;
            //        }
            //        else if (count2 == 2)
            //        {
            //            MessageBox.Show("Winner player 2");
            //            break;
            //        }
            //    }
            //}

            for (int i = 0; i <= 3; i++)
            {
                int count1 = 0;
                int count2 = 0;

                foreach (var cells in WinCon(col, row, i))
                {
                    if (c4[cells[0], cells[1]] == 1)
                    {
                        count1++;                        
                    }
                    else if (c4[cells[0], cells[1]] == 2)
                    {
                        count2++;
                    }
                    else
                    {
                        count1 = 0;
                        count2 = 0;
                        break;
                    }

                    if (count1 == 2)
                    {
                        MessageBox.Show("Winner player 1");
                        break;
                    }
                    else if (count2 == 2)
                    {
                        MessageBox.Show("Winner player 2");
                        break;
                    }
                }
            }

        }

        public List<int[]> WinCon(int row, int col, int direction)
        {
            List<int[]> incells = new List<int[]>();
            switch (direction)
            {
                case 1:
                    incells.Add(new[] { row - 1, col });
                    incells.Add(new[] { row - 2, col });
                    incells.Add(new[] { row - 3, col });
                    incells.Add(new[] { row - 4, col });
                    incells.Add(new[] { row - 5, col });
                    incells.Add(new[] { row + 1, col });
                    incells.Add(new[] { row + 2, col });
                    incells.Add(new[] { row + 3, col });
                    incells.Add(new[] { row + 4, col });
                    incells.Add(new[] { row + 5, col });
                    break;
                case 2:
                    incells.Add(new[] { row, col + 1 });
                    incells.Add(new[] { row, col + 2 });
                    incells.Add(new[] { row, col + 3 });
                    incells.Add(new[] { row, col + 4 });
                    incells.Add(new[] { row, col + 5 });
                    incells.Add(new[] { row, col + 6 });
                    incells.Add(new[] { row, col - 1 });
                    incells.Add(new[] { row, col - 2 });
                    incells.Add(new[] { row, col - 3 });
                    incells.Add(new[] { row, col - 4 });
                    incells.Add(new[] { row, col - 5 });
                    incells.Add(new[] { row, col - 6 });
                    break;
                case 3:
                    incells.Add(new[] { row + 1, col + 1 });
                    incells.Add(new[] { row + 2, col + 2 });
                    incells.Add(new[] { row + 3, col + 3 });
                    incells.Add(new[] { row + 4, col + 4 });
                    incells.Add(new[] { row + 5, col + 5 });
                    incells.Add(new[] { row - 1, col - 1 });
                    incells.Add(new[] { row - 2, col - 2 });
                    incells.Add(new[] { row - 3, col - 3 });
                    incells.Add(new[] { row - 4, col - 4 });
                    incells.Add(new[] { row - 5, col - 5 });
                    break;
                default:
                    incells.Add(new[] { row - 1, col + 1 });
                    incells.Add(new[] { row - 2, col + 2 });
                    incells.Add(new[] { row - 3, col + 3 });
                    incells.Add(new[] { row - 4, col + 4 });
                    incells.Add(new[] { row - 5, col + 5 });
                    incells.Add(new[] { row + 1, col - 1 });
                    incells.Add(new[] { row + 2, col - 2 });
                    incells.Add(new[] { row + 3, col - 3 });
                    incells.Add(new[] { row + 4, col - 4 });
                    incells.Add(new[] { row + 5, col - 5 });
                    break;
            }

            List<int[]> outCells = new List<int[]>();
            foreach (var cells in incells)
            {
                if (cells[0] >= 0 && cells[0] < 6 && cells[1] >= 0 && cells[1] < 5)
                {
                    outCells.Add(cells);
                }
            }
            return outCells;
        }
    }
}
