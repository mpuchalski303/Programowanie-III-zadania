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
        string poprawna_odp;
        int liczba1;
        int liczba2;
        int punkty;
        


        public MainWindow()
        {
            InitializeComponent();

            LosowaniePytan();




        }
        private void LosowaniePytan()
        {
            odpowiedzi.Clear();
            liczba1 = Random.Shared.Next(-10, 10);
            liczba2 = Random.Shared.Next(-10, 21);


            odpowiedzi.Add((liczba1 * liczba2).ToString());
            odpowiedzi.Add((liczba1 * liczba2 * -1).ToString());
            odpowiedzi.Add((liczba1 * (liczba2 - 1)).ToString());
            odpowiedzi.Add((liczba1 * (liczba2 + 1)).ToString());



            Pytanie.Text = "ILE TO: " + liczba1.ToString() + " * " + liczba2.ToString();
            poprawna_odp = (liczba1 * liczba2).ToString();

            ODP_1.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_1.Text);
            ODP_2.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_2.Text);
            ODP_3.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_3.Text);
            ODP_4.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
        }
        private void Odpowiadanie(string wybrana)
        {
            if (wybrana == poprawna_odp)
            {
                punkty++;
                Licznik.Text = punkty.ToString();
                Wynik.Text = "Dobrze";
                LosowaniePytan();
            }
            else
            {
                punkty--;
                Licznik.Text = punkty.ToString();
                Wynik.Text = "Zle";
                LosowaniePytan();
            }
        }
        private void Button_A_Click(object sender, RoutedEventArgs e)
        {
            Odpowiadanie(ODP_1.Text);
        }

        private void Button_B_Click(object sender, RoutedEventArgs e)
        {
            Odpowiadanie(ODP_2.Text);
        }

        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            Odpowiadanie(ODP_3.Text);
        }

        private void Button_D_Click(object sender, RoutedEventArgs e)
        {
            Odpowiadanie(ODP_4.Text);
        }
    }
}