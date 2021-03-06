using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Speech.Synthesis;

namespace Videditor
{
    /// <summary>
    /// Логика взаимодействия для VideoEditor.xaml
    /// </summary>
    public partial class VideoEditor : Window
    {

        public bool footageIsStart = false;
        public bool footageIsPause = true;
        public int markerStart = 0;
        public int markerEnd = 0;
        public SpeechSynthesizer debugger;

        public VideoEditor()
        {
            InitializeComponent();

            footage.Play();
            footage.Pause();
            markerEnd = 1500;
            debugger = new SpeechSynthesizer();

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

        private void RenderVideoHandler(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Новое видео";
            sfd.DefaultExt = ".mp4";
            sfd.Filter = "MP4 (.mp4)|*.mp4";
            bool? res = sfd.ShowDialog();
            if (res != false)
            {

                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write("rendered video");
                    }
                }
            }
        }

        private void SetMarkersHandler(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(endTimelineMarker, timeline.ActualWidth - endTimelineMarker.Width);
            Canvas.SetLeft(outsideEndArea, timeline.ActualWidth - endTimelineMarker.Width / 2);
            
            outsideEndArea.Width = 1000;

            // footage.Clock = new MediaTimeline(footage.Source).CreateClock();
        }

        private void SetStartMarkerHandler(object sender, MouseEventArgs e)
        {
            Rectangle marker = ((Rectangle)(sender));
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Canvas.SetLeft(marker, e.GetPosition(timeline).X - marker.Width / 2);
                markerStart = ((int)(Canvas.GetLeft(marker)));
                outsideStartArea.Width = e.GetPosition(timeline).X;

                // footage.Clock.Timeline.BeginTime = TimeSpan.FromSeconds(markerStart);

            }
        }

        private void SetEndMarkerHandler(object sender, MouseEventArgs e)
        {
            Rectangle marker = ((Rectangle)(sender));
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Canvas.SetLeft(marker, e.GetPosition(timeline).X - marker.Width / 2);
                markerEnd = ((int)(Canvas.GetLeft(marker)));
                Canvas.SetLeft(outsideEndArea, e.GetPosition(timeline).X);
                outsideEndArea.Width = timeline.ActualWidth - e.GetPosition(timeline).X;

                // footage.Clock.Timeline.Duration = TimeSpan.FromSeconds(markerEnd);

            }
        }

        private void SetDurationVideoHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.SetDurationDialog dialog = new Dialogs.SetDurationDialog(footage);
            dialog.Show();
        }

        private void SetVideoEffectHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.QualityDialog dialog = new Dialogs.QualityDialog(footage);
            dialog.Show();
        }

        private void ImportVideoHandler(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Новое видео";
            ofd.DefaultExt = ".mp4";
            ofd.Filter = "MP4 documents (.mp4)|*.mp4";
            bool? res = ofd.ShowDialog();
            if (res != false)
            {
                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string file_name = ofd.FileName;
                    string file_text = File.ReadAllText(file_name);

                    footage.Source = new Uri(file_name);

                }
            }
        }

        private void HoverVideoEffectHandler(object sender, MouseEventArgs e)
        {
            System.Windows.Media.Effects.DropShadowBitmapEffect qualityEffect = new System.Windows.Media.Effects.DropShadowBitmapEffect
            {
                ShadowDepth = 4,
                Direction = 330,
                Color = Colors.Black,
                Opacity = 0.5
            };
            footage.BitmapEffect = qualityEffect;
            debugger.Speak("Применяю затенение");
        }

        private void HoutVideoEffectHandler(object sender, MouseEventArgs e)
        {
            footage.BitmapEffect = null;
            debugger.Speak("Снимаю затенение");
        }
    }
}
