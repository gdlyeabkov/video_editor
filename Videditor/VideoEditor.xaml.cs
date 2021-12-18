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

namespace Videditor
{
    /// <summary>
    /// Логика взаимодействия для VideoEditor.xaml
    /// </summary>
    public partial class VideoEditor : Window
    {

        public bool footageIsStart = true;
        public bool footageIsPause = false;

        public VideoEditor()
        {
            InitializeComponent();

            footage.Play();
            // footage.Pause();

        }

        private void StartOrStopFootageHandler(object sender, RoutedEventArgs e)
        {
            footageIsPause = false;
            footageIsStart = !footageIsStart;
            if (footageIsStart) {
                footage.Play();
            }
            else if (!footageIsStart)
            {
                footage.Position = TimeSpan.FromSeconds(0);
                footage.Stop();
            }
        }

        private void ContinueOrPauseFootageHandler(object sender, RoutedEventArgs e)
        {
            if (footageIsStart) {
                footageIsPause = !footageIsPause;
                if (!footageIsPause)
                {
                    footage.Play();
                }
                else if (footageIsPause)
                {
                    footage.Pause();
                }
            }
        }

        private void SeekFootageHandler(object sender, RoutedEventArgs e)
        {
            footage.Position = TimeSpan.FromSeconds(footage.Position.TotalSeconds + 5);
        }

        private void ReverseSeekFootageHandler(object sender, RoutedEventArgs e)
        {
            footage.Position = TimeSpan.FromSeconds(footage.Position.TotalSeconds - 5);
        }

        private void SeekCursorTimeline(object sender, MouseButtonEventArgs e)
        {
            double currentCursorPosition = e.GetPosition(timeline).X;
            timelineCursor.X1 = currentCursorPosition;
            timelineCursor.X2 = currentCursorPosition;
            int timelinePercent = ((int)(timeline.Width)) / 100;
            int footagePercent = footage.NaturalDuration.TimeSpan.Seconds / 99;
            int needFootagePosition = footagePercent * ((int)(currentCursorPosition / timelinePercent));
            footage.Position = TimeSpan.FromSeconds(((int)(currentCursorPosition)));
        }
    }
}
