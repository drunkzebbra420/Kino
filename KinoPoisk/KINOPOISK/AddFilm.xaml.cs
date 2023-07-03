using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;
using System.IO;

namespace KINOPOISK
{
    public partial class AddFilm : Window
    {
        public AddFilm()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public MySqlConnection con;
        string connection = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";

        public int role = 0;
        public DateTime endSub;
        public int usID;
        private void pathPosterBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg";
            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";
            if (result == true)
            {
                filename = dlg.FileName;
                ImageSourceConverter imgsc = new ImageSourceConverter();
                ImageSource imageSource = (ImageSource)imgsc.ConvertFromString(filename);
                imagePoster.Source = imageSource;
                string[] fpath = filename.Split(new char[] { '\\' });
                posterPathFilm.Text = fpath[fpath.Length - 1];
                FileInfo fileInf = new FileInfo(filename);
                fileInf.CopyTo($@"C:\Users\Emil\source\repos\KINOPOISK\KINOPOISK\posters\{fpath[fpath.Length - 1]}", true);
            }
        }

        private void videoPathBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".mp4";
            dlg.Filter = "mp4 Files (*.mp4)|*.mp4";
            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";
            if (result == true)
            {
                filename = dlg.FileName;
                string[] fpath = filename.Split(new char[] { '\\' });
                videoPathFilm.Text = fpath[fpath.Length - 1];
                FileInfo fileInf = new FileInfo(filename);
                fileInf.CopyTo($@"C:\Users\Emil\source\repos\KINOPOISK\KINOPOISK\posters\{fpath[fpath.Length - 1]}", true);

                Uri uri = new Uri($@"C:\Users\Emil\source\repos\KINOPOISK\KINOPOISK\posters\{fpath[fpath.Length - 1]}");
                Video.Source = uri;
                Video.Play();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Genre_Film from genre;", con);
            con.Open();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string poi = $"{dt.Rows[i][0]}";
                genreFilm.Items.Add(poi);
            }

            DataTable dt1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter("select Age_Rating_Film from age_reiting;", con);
            adapter1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string poi = $"{dt1.Rows[i][0]}";
                ageRaitingFilm.Items.Add(poi);
            }
        }

        private void Video_MediaOpened(object sender, RoutedEventArgs e)
        {
            Video.Volume = 0;
            durationFilm.Text = Video.NaturalDuration.ToString();
        }

        private void releaseDateFilm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
            if(releaseDateFilm.Text.Length == 4 || releaseDateFilm.Text.Length == 7)
            {
                releaseDateFilm.Text += "-";
                releaseDateFilm.CaretIndex = releaseDateFilm.Text.Length;
            }
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.role = role;
            wnd.endSub = endSub;
            wnd.usID = usID;
            wnd.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (nameFilm.Text != "" && durationFilm.Text != "" && releaseDateFilm.Text != "" && descriptionFilm.Text != "" && posterPathFilm.Text != "" && videoPathFilm.Text != "" && genreFilm.SelectedValue != null && ageRaitingFilm.SelectedValue != null)
            {
                con = new MySqlConnection(connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter($"insert film (ID_Film, Name_Film, Duration_Film, Release_Date_Film, Description_Film, Image_Path_Film, Videio_Path_Film, Genre_Film, Age_Reiting) value(ID_film,'{nameFilm.Text}','{durationFilm.Text}','{releaseDateFilm.Text}','{descriptionFilm.Text}','{posterPathFilm.Text}', '{videoPathFilm.Text}', {genreFilm.SelectedIndex + 1}, '{ageRaitingFilm.SelectedIndex + 1}')", con);
                con.Open();
                adapter.Fill(dt);
                MainWindow wnd = new MainWindow();
                wnd.role = role;
                wnd.endSub = endSub;
                wnd.usID = usID;
                wnd.Show();
                this.Close();
            }
            else
            {
                CustomMsg wnd1 = new CustomMsg();
                wnd1.custMSG.Text = "Заполните все поля!";
                wnd1.Show();
            }
        }
    }
}
