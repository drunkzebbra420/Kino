using Microsoft.Win32;
using System;
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


        public int role = 0;
        public Player()
        {
            InitializeComponent();
            VideoControl.Volume = 100;
        }
        private void PlayClick(object sender, EventArgs e)
        {
            VideoControl.Play();
        }

        private void PauseClick(object sender, EventArgs e)
        {
            VideoControl.Pause();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VideoControl.Source = new Uri($"video\\{videoPath}");
            VideoControl.Play();
        }
        private void fullScreenButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowStyle != WindowStyle.None)
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                this.ResizeMode = ResizeMode.NoResize;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.ThreeDBorderWindow;
                this.ResizeMode = ResizeMode.CanResize;
            }
        }
        private void VideoControl_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider2.Maximum = VideoControl.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void slider2_LostMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 0, Convert.ToInt32(Math.Round(slider2.Value)));
            VideoControl.Position = time;
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Description wnd = new Description();

            wnd.poster.Source = new BitmapImage(new Uri(image, UriKind.Relative));
            wnd.nameText.Text = name;
            wnd.durationText.Text = duration; ;
            wnd.yearText.Text = year;
            wnd.descriptionText.Text = description;
            wnd.genreText.Text = genre;
            wnd.ageText.Text = age;
            wnd.role = role;
            wnd.videoPath = videoPath;
            wnd.Show();
            this.Close();
        }
    }

}
