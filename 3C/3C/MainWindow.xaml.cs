using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using ConsoleApp1;

namespace _3C
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Window_MouseUp1(object sender, MouseButtonEventArgs e)
        {
            Point point = e.MouseDevice.GetPosition(dots);
            Class1 c1=new Class1();
        
            dots.Children.Add(new Ellipse()
            {
                Width = 7,
                Height = 7,
                Fill = Brushes.Black,         // Заливка  
                RenderTransform = new TranslateTransform(point.X - 3, point.Y - 3)
            });

            poly.Points.Add(point);
        }
        internal void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point point = e.MouseDevice.GetPosition(dots);

            dots.Children.Add(new Ellipse()      // Создание круга 
            {
                Width = 7,
                Height = 7,
                Fill = Brushes.Black,
                RenderTransform = new TranslateTransform(point.X - 3, point.Y - 3)
            });

            poly.Points.Add(point);
        }
    }
}
