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

namespace _3D
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VisualBrush(object sender, RoutedEventArgs e)
        {
            VisualBrush myVisualBrush = new VisualBrush();

            // Create the visual brush's contents.
            StackPanel myStackPanel = new StackPanel();
            myStackPanel.Background = Brushes.White;

            Rectangle redRectangle = new Rectangle();
            redRectangle.Width = 80;
            redRectangle.Height = 25;
            redRectangle.Fill = Brushes.Azure;
            redRectangle.Margin = new Thickness(2);
            myStackPanel.Children.Add(redRectangle);

            TextBlock someText = new TextBlock();
            FontSizeConverter myFontSizeConverter = new FontSizeConverter();
            someText.FontSize = (double)myFontSizeConverter.ConvertFrom("15pt");
            someText.Text = "145";
            someText.Margin = new Thickness(2);
            myStackPanel.Children.Add(someText);

            Button aButton = new Button();
            aButton.Content = "Это кнопка";
            aButton.Margin = new Thickness(2);
            myStackPanel.Children.Add(aButton);

            // Use myStackPanel as myVisualBrush's content.
            myVisualBrush.Visual = myStackPanel;

            // Use myVisualBrush to paint myRectangle.
            ell.Fill = myVisualBrush;

        }

        private void LinearGradientBrush(object sender, RoutedEventArgs e)
        {
            // Create a linear gradient brush with five stops 
            LinearGradientBrush fiveColorLGB = new LinearGradientBrush();
            fiveColorLGB.StartPoint = new Point(0, 0);
            fiveColorLGB.EndPoint = new Point(1, 1);

            // Create and add Gradient stops
            GradientStop blueGS = new GradientStop();
            blueGS.Color = Colors.Red;
            blueGS.Offset = 0.0;
            fiveColorLGB.GradientStops.Add(blueGS);

            GradientStop orangeGS = new GradientStop();
            orangeGS.Color = Colors.Green;
            orangeGS.Offset = 0.25;
            fiveColorLGB.GradientStops.Add(orangeGS);

            GradientStop yellowGS = new GradientStop();
            yellowGS.Color = Colors.Yellow;
            yellowGS.Offset = 0.50;
            fiveColorLGB.GradientStops.Add(yellowGS);

            GradientStop greenGS = new GradientStop();
            greenGS.Color = Colors.Orange;
            greenGS.Offset = 0.75;
            fiveColorLGB.GradientStops.Add(greenGS);

            GradientStop redGS = new GradientStop();
            redGS.Color = Colors.Blue;
            redGS.Offset = 1.0;
            fiveColorLGB.GradientStops.Add(redGS);

            // Set Fill property of ellipse
            ell.Fill = fiveColorLGB;
        }

        private void RadialGradientBrush(object sender, RoutedEventArgs e)
        {
            // Create a radial gradient brush with five stops 
            RadialGradientBrush fiveColorRGB = new RadialGradientBrush();

            fiveColorRGB.GradientOrigin = new Point(0.5, 0.5);
            fiveColorRGB.Center = new Point(0.5, 0.5);

            // Create and add Gradient stops
            GradientStop blueGS = new GradientStop();
            blueGS.Color = Colors.Red;
            blueGS.Offset = 0.0;
            fiveColorRGB.GradientStops.Add(blueGS);

            GradientStop orangeGS = new GradientStop();
            orangeGS.Color = Colors.Green;
            orangeGS.Offset = 0.25;
            fiveColorRGB.GradientStops.Add(orangeGS);

            GradientStop yellowGS = new GradientStop();
            yellowGS.Color = Colors.Yellow;
            yellowGS.Offset = 0.50;
            fiveColorRGB.GradientStops.Add(yellowGS);

            GradientStop greenGS = new GradientStop();
            greenGS.Color = Colors.Orange;
            greenGS.Offset = 0.75;
            fiveColorRGB.GradientStops.Add(greenGS);

            GradientStop redGS = new GradientStop();
            redGS.Color = Colors.Blue;
            redGS.Offset = 1.0;
            fiveColorRGB.GradientStops.Add(redGS);

            // Set Fill property of ell
            ell.Fill = fiveColorRGB;
        }

        private void ImageBrush(object sender, RoutedEventArgs e)
        {
            ImageBrush imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/img.jpg"));
            // Fill ell with an ImageBrush  
            ell.Fill = imgBrush;  
        }
    }
}
