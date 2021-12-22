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
    /// Логика взаимодействия для QualityDialog.xaml
    /// </summary>
    public partial class QualityDialog : Window
    {

        public MediaElement footage;

        public QualityDialog(MediaElement footage)
        {
            InitializeComponent();

            this.footage = footage;
        
        }

        private void SetQualityHandler(object sender, RoutedEventArgs e)
        {
            SetQuality();
        }

        private void SetQualityFromKeysHandler(object sender, KeyEventArgs e)
        {
            SetQuality();
        }

        private void SetQuality()
        {
            System.Windows.Media.Effects.BlurBitmapEffect qualityEffect = new System.Windows.Media.Effects.BlurBitmapEffect();
            string selectedQuality = ((ComboBoxItem)(quality.Items[quality.SelectedIndex])).Content.ToString();
            selectedQuality.Split(new Char[] { 'p' });
            int selectedQualityValue = selectedQuality[0];
            qualityEffect.Radius = ((int)(800 / selectedQualityValue));
            footage.BitmapEffect = qualityEffect;
        }

    }
}
