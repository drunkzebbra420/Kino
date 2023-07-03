using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace KINOPOISK
{
    public partial class Player : Window
    {
        public string image = "";
        public string name = "";
        public string duration = "";
        public string year = "";
        public string description = "";
        public string genre = "";
        public string age = "";
        public string videoPath = "";

        public DateTime endSub;
        public int role = 0;

        private DispatcherTimer timerVideoPlayback;
        private void TimerVideoPlayback_Tick(object sender, object e)
        {
            slider2.Value ++;
            TimeSpan time = new TimeSpan((int)VideoControl.Position.Hours, (int)VideoControl.Position.Minutes, (int)VideoControl.Position.Seconds);
            timeText.Text = time.ToString();
        }
        public Player()
        {
            InitializeComponent();
            VideoControl.Volume = 100;
            volumeSlider.Value = 1;
        }
        private void PlayClick(object sender, EventArgs e)
        {
            if (pauseText.Text == "▐▐")
            {
                VideoControl.Pause();
                timerVideoPlayback.Stop();
                pauseText.Text = "►";
                pauseText.FontSize = 20;
            }
            else if (pauseText.Text == "►")
            {
                VideoControl.Play();
                timerVideoPlayback.Start();
                pauseText.Text = "▐▐";
                pauseText.FontSize = 12;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VideoControl.Source = new Uri($@"C:\Users\Emil\source\repos\KINOPOISK\KINOPOISK\posters\{videoPath}");
            VideoControl.Play();
        }
        private void fullScreenButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowStyle != WindowStyle.None)
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.ThreeDBorderWindow;
            }
        }
        private void VideoControl_MediaOpened(object sender, RoutedEventArgs e)
        {
            int pv = Convert.ToInt32(VideoControl.NaturalDuration.TimeSpan.TotalSeconds);
            slider2.Maximum = pv;
            timerVideoPlayback = new DispatcherTimer();
            timerVideoPlayback.Interval = TimeSpan.FromSeconds(1);
            timerVideoPlayback.Tick += TimerVideoPlayback_Tick;
            timerVideoPlayback.Start();
        }
        private void slider2_LostMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 0, Convert.ToInt32(Math.Round(slider2.Value)));
            VideoControl.Position = time;
        }
        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Description wnd = new Description();
            if (this.WindowStyle == WindowStyle.None)
            {
                wnd.WindowState = WindowState.Maximized;
                wnd.WindowStyle = WindowStyle.None;
            }
            else
            {
                wnd.WindowState = WindowState.Maximized;
                wnd.WindowStyle = WindowStyle.ThreeDBorderWindow;
            }
            wnd.poster.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
            wnd.nameText.Text = name;
            wnd.durationText.Text = duration; ;
            wnd.yearText.Text = year;
            wnd.descriptionText.Text = description;
            wnd.genreText.Text = genre;
            wnd.ageText.Text = age;
            wnd.role = role;
            wnd.videoPath = videoPath;
            wnd.endSub = endSub;
            wnd.Show();
            this.Close();
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoControl.Volume = volumeSlider.Value;
        }
    }

}
