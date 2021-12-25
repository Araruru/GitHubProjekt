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

namespace _3B
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Action<int, double, string> hj = (f,g,r) =>
            {
                return;    
            };
            hj(1, 2, "chisla");

            InitializeComponent();
        }

        private int rotate = 0;
        private double scale = 0;
        private int translate = 0;

        private void Rotate(object sender, RoutedEventArgs e)
        { 
            rotate += 45;
            img.RenderTransform = new RotateTransform(rotate, 0, 0);
            rect.RenderTransform = new RotateTransform(rotate, 0, 0);
            ell.RenderTransform = new RotateTransform(rotate, 0, 0);
            line.RenderTransform = new RotateTransform(rotate, 0, 0);
            poly.RenderTransform = new RotateTransform(rotate, 0, 0);
        }

        private void Scale(object sender, RoutedEventArgs e)
        {
            scale += 1.1;
            img.RenderTransform = new ScaleTransform(scale, scale, 0, 0);
            rect.RenderTransform = new ScaleTransform(scale, scale, 0, 0);
            ell.RenderTransform = new ScaleTransform(scale, scale, 0, 0);
            line.RenderTransform = new ScaleTransform(scale, scale, 0, 0);
            poly.RenderTransform = new ScaleTransform(scale, scale, 0, 0);
        }

        private void Translate(object sender, RoutedEventArgs e)
        {
            translate += 45;
            img.RenderTransform = new TranslateTransform(translate, translate);
            rect.RenderTransform = new TranslateTransform(translate, translate);
            ell.RenderTransform = new TranslateTransform(translate, translate);
            line.RenderTransform = new TranslateTransform(translate, translate);
            poly.RenderTransform = new TranslateTransform(translate, translate);
        }
    }
}
