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

namespace U4Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random Random = new Random();
        int[] diceRolls = new int[13];
        
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 0; i < diceRolls.Length; i++)
            {
                diceRolls[i] = 0;
            }      
            // simulate 1000 dice rolls
            for(int i = 0; i < 1000; i++)
            {
                diceRolls[Random.Next(1,7) + Random.Next(1,7)]++;

              //  MessageBox.Show(diceRolls[i].ToString());
            }
            // output the values
            for (int i = 2; i < diceRolls.Length; i++)
            {
                // diceRolls[i] = 0;
                Console.WriteLine(i.ToString() + ":" + diceRolls[i]);
                Rectangle rectangle = new Rectangle();
                rectangle.Fill = Brushes.Red;
                rectangle.Width = 640 / 15;
                rectangle.Height = diceRolls[i] / 1000.0 * 640.0;
                Canvas.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, (640.0 / 15.0) * i);
                Canvas.SetTop(rectangle, 640 - rectangle.Height);
                // Labeling each bar
                Label label = new Label();
                label.Content = i.ToString();
                Canvas.Children.Add(label);
                Canvas.SetLeft(label, (640.0 / 15.0) * i + 10);
                Canvas.SetTop(label, 640 - rectangle.Height - 24);
            }
         
        }
    }
}
