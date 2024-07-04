using Syncfusion.UI.Xaml.Charts;
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

namespace HearingRangeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LabelCreated(object sender, LabelCreatedEventArgs e)
        {
            double position = e.AxisLabel.Position;
            if (position >= 1000 && position <= 180000)
            {
                string text = (position / 1000).ToString("N0");
                e.AxisLabel.LabelContent = $"{text}kHz";
            }
            else
            {
                e.AxisLabel.LabelContent = $"{position:N0}Hz";
            }
        }
    }
}