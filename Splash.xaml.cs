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
using System.Windows.Threading;

namespace DimensionCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Splash : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Splash()
        {
            InitializeComponent();

            timer.Start();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            timer.Tick += progressBarLoad;
        }

        void progressBarLoad(object sender, EventArgs e)
        {
            
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                progressBar_Copy.Value += 1;

            }
            else
            {
                timer.Stop();
                Standard standardWindow = new Standard();
                standardWindow.Show();
                this.Close();
            }
        }
    }
}
