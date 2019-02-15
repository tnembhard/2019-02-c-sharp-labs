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

namespace lab_107_list_folders_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                Initialise();
            }
            catch (FileNotFoundException)
            {
                
            }
            
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

        private void Save()
        {
            File.WriteAllText("lab_107_Output.txt", usrNameTxt.Text + Environment.NewLine + usrLevelTxt.Text + Environment.NewLine + usrScoreTxt.Text + Environment.NewLine + usrCurrentScoreTxt.Text);
        }

        private void Initialise()
        {
            string[] init = File.ReadAllLines("lab_107_Output.txt");
            usrNameTxt.Text = init[0];
            usrLevelTxt.Text = init[1];
            usrScoreTxt.Text = init[2];
            usrCurrentScoreTxt.Text = init[3];
            folderList.ItemsSource = init;
            //var fileArray = Directory.GetFiles("");
            fileList.ItemsSource = Directory.GetFiles("../");
        }



        // list box - list all folder in project root
        // manually create folders
    }
}
