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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CreateSeason : Page
    {
        private List<Round> roundDates = new List<Round>();
        private Round round1 = new Round(1, (new DateTime(2020, 10, 3, 7, 0, 0).ToLongDateString()));
        private Round round2 = new Round(2, (new DateTime(2020, 10, 10, 7, 0, 0).ToLongDateString()));
        private Round round3 = new Round(3, (new DateTime(2020, 10, 17, 7, 0, 0).ToLongDateString()));
        private Round round4 = new Round(4, (new DateTime(2020, 10, 24, 7, 0, 0).ToLongDateString()));
        private Round round5 = new Round(5, (new DateTime(2020, 10, 31, 7, 0, 0).ToLongDateString()));
        private Round round6 = new Round(6, (new DateTime(2020, 11, 7, 7, 0, 0).ToLongDateString()));
        private Round round7 = new Round(7, (new DateTime(2020, 11, 14, 7, 0, 0).ToLongDateString()));
        private Round round8 = new Round(8, (new DateTime(2020, 11, 21, 7, 0, 0).ToLongDateString()));
        private Round round9 = new Round(9, (new DateTime(2020, 11, 28, 7, 0, 0).ToLongDateString()));
        private Round round10 = new Round(10, (new DateTime(2020, 12, 5, 7, 0, 0).ToLongDateString()));
        Round round = new Round();


        public CreateSeason()
        {
            InitializeComponent();
            this.DataContext = round;
            this.DataGridDates.DataContext = roundDates;

        }

        private void btnSaveDates_Click(object sender, RoutedEventArgs e)
        {
            this.roundDates.Add(this.round1);
            this.roundDates.Add(this.round2);
            this.roundDates.Add(this.round3);
            this.roundDates.Add(this.round4);
            this.roundDates.Add(this.round5);
            this.roundDates.Add(this.round6);
            this.roundDates.Add(this.round7);
            this.roundDates.Add(this.round8);
            this.roundDates.Add(this.round9);
            this.roundDates.Add(this.round10);

            MessageBox.Show("Dates Have Been Created.");

        }

        private void btnViewDates_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Round Number: " + roundDates[1].RoundNumber + "\nDate: " + roundDates[1].RoundDate.ToShortDateString());
            CollectionViewSource.GetDefaultView(DataGridDates.ItemsSource).Refresh();
        }

        private void btnCreateDraw_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Draw Has Been Created.");
        }

        private void btnSaveSeason_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Season Has Been Saved.");
            
        }
    }
}
