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
    /// Interaction logic for ViewDraw.xaml
    /// </summary>
    public partial class ViewDraw : Page
    {
        public ViewDraw()
        {
            InitializeComponent();
        }

        private void Button_Click_View_Draw(object sender, RoutedEventArgs e)
        {
            //pdfWebViewer.Navigate(new Uri(@"about:C:\Users\wesle\Desktop\Submissions\Karen_James_Project_Sem_1\EDSL_Prototype\Draw_Report_Example.pdf"));
            //pdfWebViewer.Navigate(@"about:C:\Users\wesle\Desktop\Submissions\Karen_James_Project_Sem_1\EDSL_Prototype\Draw_Report_Example.pdf");
            //pdfWebViewer.(@"HTTP Succinctly.pdf");
            //pdfViewer.OpenDocument("C:\\Users\\wesle\\Desktop\\Submissions\\Karen_James_Project_Sem_1\\EDSL_Prototype\\Draw_Report_Example.pdf");
            String fileName = "C:\\Users\\wesle\\Desktop\\Submissions\\Karen_James_Project_Sem_1\\EDSL_Prototype\\Draw_Report_Season_1.pdf";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = fileName;
            process.Start();
            process.WaitForExit();
        }

        private void Button_Click_View_Ladder(object sender, RoutedEventArgs e)
        {
            
            String fileName2 = "C:\\Users\\wesle\\Desktop\\Submissions\\Karen_James_Project_Sem_1\\EDSL_Prototype\\Ladder_Report_Season_1.pdf";
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            process2.StartInfo.FileName = fileName2;
            process2.Start();
            process2.WaitForExit();
        }
    }
}
