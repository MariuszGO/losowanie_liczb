using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace losowanie_liczb
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
            int zakres1, zakres2, ile_liczb, liczba;

            zakres1 = Convert.ToInt32(od.Text);
            zakres2 = Convert.ToInt32(do1.Text);
            ile_liczb = Convert.ToInt32(ilosc.Text);

            string nasze_liczby="";

            Random los = new Random();

            for (int i = 0; i < ile_liczb; i++) { 
            
                liczba = los.Next(zakres1,zakres2);

                nasze_liczby = nasze_liczby + Convert.ToString(liczba) + " ";

                if(i % 20 == 0 && i != 0) {

                    nasze_liczby = nasze_liczby + " \n";


                }



            
            }

            wynik.Text = nasze_liczby; 

        }
    }
}