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

namespace lab_105_game_name_and_score_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                                 
            File.WriteAllText("lab_105_Output.txt",usrNameTxt.Text+ Environment.NewLine+usrLevelTxt.Text+Environment.NewLine+ usrScoreTxt.Text);
        }

        // Create a Gaming home page
        // Name of gamer (saved to text file)
        // Level reached (saved to text file)
        // Top score
        // Prize for best presented interface

    }
}
