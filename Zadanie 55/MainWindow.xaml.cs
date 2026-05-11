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
using System.Threading;

namespace Zadanie_55
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string Pracuj()
        {
            Thread.Sleep(5000);
            return $"Zakonczono:{DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}";

        }
        private Task<string> PracujTask()
        {
            return Task.Run(() => Pracuj());
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn == null)
            {
                return;
            }
            string orginalny_tekst = btn.Content.ToString();
            string status = $"Uruchomino ({orginalny_tekst})";
            Komunikat.Text = status;
            btn.Content = status;

            btn.IsEnabled = false;
            try
            {
                string wynik = await PracujTask();
                Komunikat.Text = wynik;
            }
            catch (Exception ex)
            {
                Komunikat.Text = "Blad: " + ex.Message;
            }
            finally
            {
                btn.Content = orginalny_tekst;
                btn.IsEnabled = true;
            }

        }
    }
}