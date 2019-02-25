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
using System.IO;

namespace lab_106_game_increase_score_01
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
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Save();
            
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            usrCurrentScoreTxt.Text = Convert.ToString(Convert.ToInt16(usrCurrentScoreTxt.Text) + 1);
            Save();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            usrCurrentScoreTxt.Text = Convert.ToString(Convert.ToInt16(usrCurrentScoreTxt.Text) - 1);
            Save();
        }

        private void Save ()
        {
            File.WriteAllText("lab_106_Output.txt", usrNameTxt.Text + Environment.NewLine + usrLevelTxt.Text + Environment.NewLine + usrScoreTxt.Text + Environment.NewLine + usrCurrentScoreTxt.Text);
        }

        private void Initialise()
        {
            string[] init = File.ReadAllLines("lab_106_Output.txt");
            usrNameTxt.Text = init[0];
            usrLevelTxt.Text = init[1];
            usrScoreTxt.Text = init[2];
            usrCurrentScoreTxt.Text = init[3];

        }

        // Create a Gaming home page
        // Name of gamer (saved to text file)
        // Level reached (saved to text file)
        // Top score
        //CUrrent score
        // Prize for best presented interface

        // Next iteration - add an up/down button to increase the score
    }
}
