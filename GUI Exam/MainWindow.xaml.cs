using System.Runtime.InteropServices;
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

namespace GUI_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> odpowiedzi = new List<string>();
        //string[] odpowiedzi = {"1410", "966", "1025", "1939"};
        string odp;

        string poprawna_odp = "1410";
        public MainWindow()
        {
            InitializeComponent();

            odpowiedzi.Add("1410");
            odpowiedzi.Add("966");
            odpowiedzi.Add("1025");
            odpowiedzi.Add("1939");


            odp = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            Pytanie.Text = "Kiedy byla bitwa pod Grunwaldem?";


            ODP_1.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_1.Text);
            ODP_2.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_2.Text);
            ODP_3.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_3.Text);
            ODP_4.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];


        }

        private void Button_A_Click(object sender, RoutedEventArgs e)
        {
            
            if(ODP_1.Text == poprawna_odp)
            {
                Wynik.Text = "Dobrze";
            }
            else
            {
                Wynik.Text = "Zle";
            }
        }

        private void Button_B_Click(object sender, RoutedEventArgs e)
        {
            
            if(ODP_2.Text == poprawna_odp)
            {
                Wynik.Text = "Dobrze";
            }
            else
            {
                Wynik.Text = "Zle";
            }

        }

        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            
            if (ODP_3.Text == poprawna_odp)
            {
                Wynik.Text = "Dobrze";
            }
            else
            {
                Wynik.Text = "Zle";
            }
        }

        private void Button_D_Click(object sender, RoutedEventArgs e)
        {
            
            if (ODP_4.Text == poprawna_odp)
            {
                Wynik.Text = "Dobrze";
            }
            else
            {
                Wynik.Text = "Zle";
            }
        }
    }
}