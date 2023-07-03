﻿using System;
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

namespace KINOPOISK
{
    public partial class Description : Window
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
        public Description()
        {
            InitializeComponent();
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            if (this.WindowStyle == WindowStyle.None)
            {
                wnd.WindowState = WindowState.Maximized;
                wnd.WindowStyle = WindowStyle.None;
                wnd.ResizeMode = ResizeMode.NoResize;
            }
            else
            {
                wnd.WindowState = WindowState.Maximized;
                wnd.WindowStyle = WindowStyle.ThreeDBorderWindow;
                wnd.ResizeMode = ResizeMode.CanResize;
            }
            wnd.role = role;
            wnd.Show();
            this.Close();
        }

        private void watch_filmBtn_Click(object sender, RoutedEventArgs e)
        {
            Player wnd = new Player();

            wnd.image = image;
            wnd.name = name;
            wnd.duration = duration;
            wnd.year = year;
            wnd.description = description; ;
            wnd.genre = genre;
            wnd.age = age;
            wnd.role = role;
            wnd.videoPath = videoPath;
            wnd.Show();
            this.Close();
        }
    }
}
