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

namespace EDSL_Prototype
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

        private void Button_Click_Season(object sender, RoutedEventArgs e)
        {
            Main.Content = new CreateSeason();
        }

        private void Button_Click_Results(object sender, RoutedEventArgs e)
        {
            Main.Content = new EnterRoundResults();
        }

        private void Button_Click_Ladder(object sender, RoutedEventArgs e)
        {
            Main.Content = new CreateLadder();
        }
        private void Button_Click_Create_Draw(object sender, RoutedEventArgs e)
        {
            Main.Content = new CreateDraw();
        }

        private void Button_Click_View_Draw(object sender, RoutedEventArgs e)
        {
            Main.Content = new ViewDraw();
        }


    }
}
