using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TD2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point p0 = new Point(-1,-1);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UnCanvas.Children.Clear();
            p0.X = -1; p0.Y = -1;
        }

        private void MouseDownCanvas(object sender, MouseButtonEventArgs e)
        {       
            Point p = new Point();

            p = Mouse.GetPosition(UnCanvas);

            if (p0.X==-1 && p0.Y== -1)
            {
                p0.X = p.X;
                p0.Y = p.Y;
                return;
            }

            Line uneligne = new Line();

            uneligne.X1 = p0.X; uneligne.Y1 = p0.Y;
            uneligne.X2 = p.X; uneligne.Y2 = p.Y;

            switch(Combo.SelectedIndex)
            {
                case 0: uneligne.Stroke = Brushes.Orange; break;
                case 1: uneligne.Stroke = Brushes.Green; break;
                case 2: uneligne.Stroke = Brushes.Blue; break;
            }
            UnCanvas.Children.Add(uneligne);

            p0.X = p.X;
            p0.Y = p.Y;
        }
    }
}
