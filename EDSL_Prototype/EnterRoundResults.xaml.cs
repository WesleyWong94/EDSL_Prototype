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
    /// Interaction logic for EnterRoundResults.xaml
    /// </summary>
    public partial class EnterRoundResults : Page
    {
        private List<Ladder> ladderGames = new List<Ladder>();
        private Ladder ladder1 = new Ladder("Lilydale", 1, 7, 7, 0, 0, 15, 7, 0);
        private Ladder ladder2 = new Ladder("Belgrave", 2, 7, 5, 1, 1, 13, 6, 1);
        private Ladder ladder3 = new Ladder("Ringwood", 3, 5, 3, 2, 0, 11, 4, 3);
        private Ladder ladder4 = new Ladder("Oakleigh", 4, 6, 3, 2, 1, 9, 4, 3);
        private Ladder ladder5 = new Ladder("Wantirna", 5, 5, 3, 1, 1, 6, 3, 4);
        private Ladder ladder6 = new Ladder("Mount Waverly", 6, 7, 3, 2, 2, 5, 2, 5);
        private Ladder ladder7 = new Ladder("Murrumbeena", 7, 7, 2, 2, 3, 3, 2, 5);
        private Ladder ladder8 = new Ladder("Mitcham", 8, 6, 2, 1, 3, 2, 2, 5);
        private Ladder ladder9 = new Ladder("Scoresby", 9, 7, 0, 0, 7, 0, 0, 7);
        private Ladder ladder10 = new Ladder("Mount Evelyn", 10, 7, 0, 0, 7, 0, 0, 7);
        Ladder ladder = new Ladder();
        public EnterRoundResults()
        {
            InitializeComponent();
            this.DataContext = ladder;
            this.DataLadderGames.DataContext = ladderGames;
        }

        private void btnCreateLadder_Click(object sender, RoutedEventArgs e)
        {
            this.ladderGames.Add(this.ladder1);
            this.ladderGames.Add(this.ladder2);
            this.ladderGames.Add(this.ladder3);
            this.ladderGames.Add(this.ladder4);
            this.ladderGames.Add(this.ladder5);
            this.ladderGames.Add(this.ladder6);
            this.ladderGames.Add(this.ladder7);
            this.ladderGames.Add(this.ladder8);
            this.ladderGames.Add(this.ladder9);
            this.ladderGames.Add(this.ladder10);

            MessageBox.Show("Ladder Has Been Created.");
        }

        private void Button_Click_Ladder(object sender, RoutedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(DataLadderGames.ItemsSource).Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Results Are Now Updated.");
        }

        private void Button_Click_Save_Results(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Results Have Been Saved.");
        }
    }
}
