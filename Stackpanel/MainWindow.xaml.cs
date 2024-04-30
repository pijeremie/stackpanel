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


namespace TD2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object uneLigne;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            private void findButton_Click(object sender, System.EventArgs e)
            {
                UnCanvas.Children.Clear();
                p0.X = -1; p0.Y = -1;
            }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MouseDownCanvas(object sender, MouseButtonEventArgs e)
        {
                Point p0 = new Point(-1,-1);
            
                p = Mouse.GetPosition(UnCanvas);

                if (p0.X == -1 && p0.Y == -1)
                {
                    p0.X = p.X; p0.Y = p.Y;
                    return;
                }

                Line uneLigne = new Line();
                uneLigne.X1 = p0.X; uneLigne.Y1 = p0.Y;
                uneLigne.X2 = p0.X; uneLigne.Y2 = p0.Y;

                switch(cb_couleur.SelectedIndex);
                {
                    case 0; uneLigne.Stroke = Brushes.Orange; break;
                    case 1; uneLigne.Stroke = Brushes.Green; break;
                    case 2; uneLigne.Stroke = Brushes.Blue; break;
                }
                UnCanvas.Children.Add(uneLigne);

                p0.X = p.X; p0.Y = p.Y;
            }
    }
}
