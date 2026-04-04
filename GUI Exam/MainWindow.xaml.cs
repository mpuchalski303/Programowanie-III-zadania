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
        string liczba2;
        string liczba3;
        int punkty;
        int gdzie_znak;
        int losowa_typ_zadania;
        string pytanie_liczba2;
        string pytanie_liczba3;

        public MainWindow()
        {
            InitializeComponent();

            LosowaniePytan();



        }
        private void LosowaniePytan()
        {
            losowa_typ_zadania = Random.Shared.Next(1, 3);
            if(losowa_typ_zadania == 1)
            {
                Pytanie_typ1();
            }
            else
            {
                Pytanie_typ2();
            }
            
            

        }
        private void Pytanie_typ1()
        {
            odpowiedzi.Clear();
            liczba1 = Random.Shared.Next(-10, 10);
            liczba2 = (Random.Shared.Next(-10, 10)).ToString();
            
            if (liczba1 == 0)
            {
                liczba1 = 1;
            }
            if (liczba2 == "0")
            {
                liczba2 = "1";
            }
            pytanie_liczba2 = liczba2;
            if ( int.Parse(liczba2) < 0)
            {
                pytanie_liczba2 = "(" + liczba2 + ")";
            }
            
            odpowiedzi.Add((liczba1 * int.Parse(liczba2)).ToString());
            odpowiedzi.Add((liczba1 * int.Parse(liczba2) * -1).ToString());
            odpowiedzi.Add((liczba1 * (int.Parse(liczba2) - 1)).ToString());
            odpowiedzi.Add((liczba1 * (int.Parse(liczba2) + 1)).ToString());



            Pytanie.Text = "ILE TO: " + liczba1.ToString() + " × " + pytanie_liczba2;
            poprawna_odp = (liczba1 * int.Parse(liczba2)).ToString();

            ODP_1.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_1.Text);
            ODP_2.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_2.Text);
            ODP_3.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_3.Text);
            ODP_4.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
        }
        private void Pytanie_typ2()
        {
            odpowiedzi.Clear();
            liczba1 = Random.Shared.Next(-8, 8);
            liczba2 = Random.Shared.Next(-8, 8).ToString();
            liczba3 = Random.Shared.Next(-8, 8).ToString();
            
            gdzie_znak = Random.Shared.Next(1, 5);

            if (liczba1 == 0)
            {
                liczba1 = 1;
            }
            if (liczba2 == "0")
            {
                liczba2 = "1";
            }
            if (liczba3 == "0")
            {
                liczba3 = "1";
            }
            pytanie_liczba2 = liczba2;
            pytanie_liczba3 = liczba3;

            if (int.Parse(liczba2) < 0)
            {
                pytanie_liczba2 = "(" + liczba2 + ")";
            }
            
            if (int.Parse(liczba3) < 0)
            {
                pytanie_liczba3 = "(" + liczba3 + ")";
            }

            if (gdzie_znak == 1)
            {
                Pytanie.Text = "ILE TO: " + liczba1.ToString() + " - " + pytanie_liczba2 + " \u00D7 " + pytanie_liczba3;
                poprawna_odp = (liczba1 - int.Parse(liczba2) * int.Parse(liczba3)).ToString();
            }
            else if (gdzie_znak == 2)
            {
                Pytanie.Text = "ILE TO: " + liczba1.ToString() + " + " + pytanie_liczba2 + " \u00D7 " + pytanie_liczba3;
                poprawna_odp = (liczba1 + int.Parse(liczba2) * int.Parse(liczba3)).ToString();
            }
            else if(gdzie_znak == 3)
            {
                Pytanie.Text = "ILE TO: " + liczba1.ToString() + " \u00D7 " + pytanie_liczba2 + " + " + pytanie_liczba3;
                poprawna_odp = (liczba1 * int.Parse(liczba2) + int.Parse(liczba3)).ToString();
            }
            else if(gdzie_znak == 4)
            {
                Pytanie.Text = "ILE TO: " + liczba1.ToString() + " \u00D7 " + pytanie_liczba2 + " - " + pytanie_liczba3;
                poprawna_odp = (liczba1 * int.Parse(liczba2) - int.Parse(liczba3)).ToString();
            }

            odpowiedzi.Add((liczba1 - int.Parse(liczba2) * int.Parse(liczba3)).ToString());
            odpowiedzi.Add((liczba1 + int.Parse(liczba2) * int.Parse(liczba3)).ToString());
            odpowiedzi.Add((liczba1 * int.Parse(liczba2) + int.Parse(liczba3)).ToString());
            odpowiedzi.Add((liczba1 * int.Parse(liczba2) - int.Parse(liczba3)).ToString());

            ODP_1.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_1.Text);
            ODP_2.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_2.Text);
            ODP_3.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            odpowiedzi.Remove(ODP_3.Text);
            ODP_4.Text = odpowiedzi[Random.Shared.Next(odpowiedzi.Count)];
            


        }
        private void Pytanie_typ3()
        {
            odpowiedzi.Clear();

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