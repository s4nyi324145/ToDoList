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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> feladatok = new List<string>();
        List<string> keresettFeladatok = new List<string>();
        StackPanel kulsoStackpanel = new StackPanel();
        StackPanel belsoStackpanel = new StackPanel();
        TextBlock textBlock = new TextBlock();
        Button torlesGomb = new Button();
        CheckBox checkBox = new CheckBox();







        public MainWindow()
        {
            InitializeComponent();
            bezaras.Click += Bezaras_Click;
            menuElohozas.Click += MenuElohozas_Click;
            hozzadas.Click += Hozzadas_Click;
            megseGomb.Click += MegseGomb_Click;
            hozzadasGomb.Click += HozzadasGomb_Click;
            kereses.Click += Kereses_Click;
            keresoSav.GotFocus += KeresoSav_GotFocus;
            keresoSav.KeyDown += KeresoSav_KeyDown;
            torles.Click += Torles_Click;
            torlesGomb.Click += TorlesGomb_Click;
            bevitel.GotFocus += Bevitel_GotFocus;





        }


        private void Bevitel_GotFocus(object sender, RoutedEventArgs e)
        {
            bevitel.Text = "";
        }

        private void TorlesGomb_Click(object sender, RoutedEventArgs e)
        {

            Button torlesGomb = sender as Button;
            string feladatTorles = torlesGomb.Tag.ToString();
            feladatok.Remove(feladatTorles);
            if (keresoSav.Visibility == Visibility.Visible) Kereses(); //baj
            else Frissites();
        }
        private void Torles_Click(object sender, RoutedEventArgs e)
        {
            var mostaniszin = torles.Background as SolidColorBrush;
            var mostaniszin2 = keresoSav.Background as SolidColorBrush;
            if (mostaniszin.Color == Colors.Gray)
            {
                feladatoksav.Background = new SolidColorBrush(Colors.LightGray);
                torles.Background = new SolidColorBrush(Colors.White);
                torles.Foreground = new SolidColorBrush(Colors.Gray);
                Frissites();
            }
            else
            {
                feladatoksav.Background = new SolidColorBrush(Colors.Gray);
                torles.Background = new SolidColorBrush(Colors.Gray);
                torles.Foreground = new SolidColorBrush(Colors.White);

                Frissites();



            }
        }

        private void KeresoSav_KeyDown(object sender, KeyEventArgs e)
        {
            var mostaniszin = torles.Background as SolidColorBrush;
            var mostaniszin2 = keresoSav.Background as SolidColorBrush;

            if (e.Key == Key.Enter)
            {
                Kereses();
            }

        }
        private void Kereses()
        {
            feladatoksav.Children.Clear();
            keresettFeladatok.Clear();
            feladatok.Where(x => x.Contains(keresoSav.Text)).ToList().ForEach(x => keresettFeladatok.Add(x));
            var mostaniszin = torles.Background as SolidColorBrush;
            string keresettFeladat = "";
            for (int i = 0; i < keresettFeladatok.Count(); i++)
            {
                keresettFeladat = keresettFeladatok[i];

                StackPanel kulsoStackpanel = new StackPanel();
                StackPanel belsoStackpanel = new StackPanel();
                TextBlock textBlock = new TextBlock();
                Button torlesGomb = new Button();
                CheckBox checkBox = new CheckBox();

                textBlock.Margin = new Thickness(10, 0, 10, 0);
                textBlock.Padding = new Thickness(5, 5, 5, 5);
                textBlock.Text = keresettFeladat;
                textBlock.FontWeight = FontWeights.Medium;

                textBlock.FontStyle = FontStyles.Oblique;

                kulsoStackpanel.Margin = new Thickness(0, 10, 0, 10);
                kulsoStackpanel.Orientation = Orientation.Horizontal;
                kulsoStackpanel.Background = new SolidColorBrush(Colors.LightGray);


                belsoStackpanel.HorizontalAlignment = HorizontalAlignment.Right;
                belsoStackpanel.VerticalAlignment = VerticalAlignment.Center;
                belsoStackpanel.Orientation = Orientation.Horizontal;
                checkBox.Margin = new Thickness(0, 0, 10, 0);
                checkBox.VerticalAlignment = VerticalAlignment.Center;
                torlesGomb.Content = "X";
                torlesGomb.Tag = feladatok[i];
                torlesGomb.Click += TorlesGomb_Click;
                if (mostaniszin.Color == Colors.Gray) torlesGomb.Visibility = Visibility.Visible;
                else torlesGomb.Visibility = Visibility.Collapsed;

                torlesGomb.Padding = new Thickness(5, 2, 5, 2);
                torlesGomb.Background = new SolidColorBrush(Colors.Red);
                torlesGomb.Foreground = new SolidColorBrush(Colors.White);

                belsoStackpanel.Children.Add(checkBox);
                belsoStackpanel.Children.Add(torlesGomb);
                kulsoStackpanel.Children.Add(textBlock);
                kulsoStackpanel.Children.Add(belsoStackpanel);

                feladatoksav.Children.Add(kulsoStackpanel);

                keresettFeladat = "";
            }

        }

        private void KeresoSav_GotFocus(object sender, RoutedEventArgs e)
        {          
            keresoSav.Text = "";          
        }

        private void Kereses_Click(object sender, RoutedEventArgs e)
        {
            var mostaniszin = kereses.Background as SolidColorBrush;
            var mostaniszin2 = torles.Background as SolidColorBrush;

            if (mostaniszin.Color == Colors.Gray)
            {
                keresoSav.Visibility = Visibility.Collapsed;                              
                kereses.Background = new SolidColorBrush(Colors.White);
                kereses.Foreground = new SolidColorBrush(Colors.Gray);
                Frissites();

            }
            else
            {
                keresoSav.Visibility = Visibility.Visible;
                kereses.Background = new SolidColorBrush(Colors.Gray);
                kereses.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void Frissites()
        {
            feladatoksav.Children.Clear();
            var mostaniszin = torles.Background as SolidColorBrush;

            for (int i = 0; i < feladatok.Count(); i++)
            {
                StackPanel kulsoStackpanel = new StackPanel();
                StackPanel belsoStackpanel = new StackPanel();
                TextBlock textBlock = new TextBlock();
                Button torlesGomb = new Button();
                CheckBox checkBox = new CheckBox();

                textBlock.Margin = new Thickness(10, 0, 10, 0);
                textBlock.Padding = new Thickness(5, 5, 5, 5);
                textBlock.Text = feladatok[i];
                textBlock.FontWeight = FontWeights.Medium;
                textBlock.FontStyle = FontStyles.Oblique;

                kulsoStackpanel.Margin = new Thickness(0, 10, 0, 10);
                kulsoStackpanel.Orientation = Orientation.Horizontal;
                kulsoStackpanel.Background = new SolidColorBrush(Colors.LightGray);

                belsoStackpanel.HorizontalAlignment = HorizontalAlignment.Right;
                belsoStackpanel.VerticalAlignment = VerticalAlignment.Center;
                belsoStackpanel.Orientation = Orientation.Horizontal;

                checkBox.Margin = new Thickness(0, 0, 10, 0);
                checkBox.VerticalAlignment = VerticalAlignment.Center;

                torlesGomb.Content = "X";
                torlesGomb.Tag = feladatok[i];
                if (mostaniszin.Color == Colors.Gray) torlesGomb.Visibility = Visibility.Visible;
                else torlesGomb.Visibility = Visibility.Collapsed;
                torlesGomb.Click += TorlesGomb_Click;
                torlesGomb.Padding = new Thickness(5, 2, 5, 2);
                torlesGomb.Background = new SolidColorBrush(Colors.Red);
                torlesGomb.Foreground = new SolidColorBrush(Colors.White);


                belsoStackpanel.Children.Add(checkBox);
                belsoStackpanel.Children.Add(torlesGomb);
                kulsoStackpanel.Children.Add(textBlock);
                kulsoStackpanel.Children.Add(belsoStackpanel);

                feladatoksav.Children.Add(kulsoStackpanel);
            }
        }
    


        private void HozzadasGomb_Click(object sender, RoutedEventArgs e)
        {

            var mostaniszin2 = torles.Background as SolidColorBrush;
            string feladat = bevitel.Text;
            feladatok.Add(feladat);
            Frissites();
            
        }
       
        private void MegseGomb_Click(object sender, RoutedEventArgs e)
        {
            bevitel.Text = "";
        }

        private void Hozzadas_Click(object sender, RoutedEventArgs e)
        {
            ;

             var mostaniszin = hozzadas.Background as SolidColorBrush;

            if (mostaniszin.Color == Colors.Gray) {

                hozzadassav.Visibility = Visibility.Collapsed;
                hozzadasGomb.Visibility = Visibility.Collapsed;
                megseGomb.Visibility = Visibility.Collapsed;
                hozzadas.Background = new SolidColorBrush(Colors.White);
                hozzadas.Foreground = new SolidColorBrush(Colors.Gray);

            }
            else
            {
                hozzadassav.Visibility = Visibility.Visible;
                hozzadasGomb.Visibility = Visibility.Visible;
                megseGomb.Visibility = Visibility.Visible;
                hozzadas.Background = new SolidColorBrush(Colors.Gray);
                hozzadas.Foreground = new SolidColorBrush(Colors.White);
            }

            
        }

        private void MenuElohozas_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            
            menuElohozas.Visibility = Visibility.Collapsed;
        }

        private void Bezaras_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            
            menuElohozas.Visibility = Visibility.Visible;
            
        }
    }
}
