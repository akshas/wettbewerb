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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWettbewerb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Sender;
        private int Staerke;
        Spieler sp1;
        Spieler sp2;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameStarten();
        }

        private void GameStarten()
        {
            if (Player1.Text != "" && Player2.Text != "")
            {
                 sp1 = new Spieler(Player1.Text);
                 sp2 = new Spieler(Player2.Text);

                NamePlayer1.Text = sp1.Name + "s Leben: " + sp1.Leben;
                NamePlayer2.Text = sp2.Name + "s Leben: " + sp2.Leben;

                Schlag1.Text = sp1.Schlag.ToString();
                Schlag2.Text = sp2.Schlag.ToString();

            }
        }

        private void OnMouseDown(object sender, RoutedEventArgs e)
        {

        }

        private void OnMouseLeave(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            Sender = btn.Name;

        }
        private static void SchlagSettings(string btnName)
        {
             
        }

    }
}
