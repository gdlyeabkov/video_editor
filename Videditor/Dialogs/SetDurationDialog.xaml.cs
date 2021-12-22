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
using System.Windows.Shapes;

namespace Videditor.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для SetDurationDialog.xaml
    /// </summary>
    public partial class SetDurationDialog : Window
    {

        public MediaElement footage;

        public SetDurationDialog(MediaElement footage)
        {
            InitializeComponent();

            this.footage = footage;
            duration.Text = footage.SpeedRatio.ToString();
        }

        private void SetDurationHandler(object sender, RoutedEventArgs e)
        {
            SetDuration();
        }

        private void SetDurationFromKeysHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SetDuration();
            }
        }

        private void SetDuration()
        {
            double durationRatio = 1.0;
            if (duration.Text.Contains("."))
            {
                string[] durationParts = duration.Text.Split(new Char[] { '.' });
                string rightFormat = String.Join(",", durationParts);
                durationRatio = Double.Parse(rightFormat);
            }
            else if (duration.Text.Contains(","))
            {
                durationRatio = Double.Parse(duration.Text);
            }
            footage.SpeedRatio = durationRatio;
            this.Close();
        }
    }
}
