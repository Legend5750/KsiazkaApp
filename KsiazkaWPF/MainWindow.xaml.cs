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
using KsiazkaApp;
using System.IO;

namespace KsiazkaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\Dane.txt");
        static string[] tablicaStron = daneZPliku.Split(";");


        Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);
        int wybranaStrona = 1;
        public MainWindow()
        {
            InitializeComponent();
            

            for (int i = 1; i < tablicaStron.Length; i++)
            {
                ksiazka.DodajStrone(tablicaStron[i]);
            }
            textBlock1.Text += ksiazka.strony[0].trescStrony;
            textBox1.Text = ksiazka.strony[1].trescStrony;
            textBox2.Text = ksiazka.strony[2].trescStrony;
            textBlock2.Text = "Strony: 2,3/"+ksiazka.strony.Count;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (wybranaStrona + 3 < ksiazka.strony.Count)
            {
                wybranaStrona = wybranaStrona + 2;
                textBox1.Text = ksiazka.strony[wybranaStrona].trescStrony;
                textBox2.Text = ksiazka.strony[wybranaStrona + 1].trescStrony;
                textBlock2.Text = "Strony: " + (wybranaStrona + 1) + "," + (wybranaStrona + 2) + "/" + ksiazka.strony.Count;
            }
            else if(wybranaStrona + 3 <= ksiazka.strony.Count)
            {
                wybranaStrona = wybranaStrona + 2;
                textBox1.Text = ksiazka.strony[wybranaStrona].trescStrony;
                textBox2.Text = "";
                textBlock2.Text = "Strony: " + (wybranaStrona + 1) + "/" + ksiazka.strony.Count;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(wybranaStrona - 3 >= 0)
            {
                wybranaStrona = wybranaStrona - 2;
                textBox1.Text = ksiazka.strony[wybranaStrona].trescStrony;
                textBox2.Text = ksiazka.strony[wybranaStrona + 1].trescStrony;
                textBlock2.Text = "Strony: " + (wybranaStrona + 1) + "," + (wybranaStrona + 2) + "/" + ksiazka.strony.Count;
            }
        }
    }
}