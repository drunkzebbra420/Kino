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

namespace KINOPOISK
{
    public class Film
    {
        public string poster { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public string age { get; set; }
        public string description { get; set; }
        public string duration { get; set; }
        public string videoPath { get; set; }


    }
    public partial class MainWindow : Window
    {
        public List<Film> obj;
        public MySqlConnection con;
        string connection = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public int role = 0;
        public DateTime endSub;
        public int usID;
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            postersResult("select Name_Film, Duration_Film, Release_Date_Film, Description_Film, Image_Path_Film,genre.Genre_Film,age_reiting.Age_Rating_Film, Videio_Path_Film from film join genre on film.Genre_Film = genre.ID_Genre join age_reiting on film.Age_Reiting = age_reiting.id_age_reiting");
        }
        public void postersResult(string query)
        {
            obj = new List<Film>();
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            con.Open();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string path = $@"C:\Users\Emil\source\repos\KINOPOISK\KINOPOISK\posters\{ dt.Rows[i][4]}";
                obj.Add(new Film()
                {
                    name = dt.Rows[i][0].ToString(),
                    duration = dt.Rows[i][1].ToString(),
                    year = dt.Rows[i][2].ToString(),
                    description = dt.Rows[i][3].ToString(),
                    poster = path,
                    genre = dt.Rows[i][5].ToString(),
                    age = dt.Rows[i][6].ToString(),
                    videoPath = dt.Rows[i][7].ToString()
                });
            }
            con.Close();
            filmList.ItemsSource = obj;
        }

        private void moreBtn_Click(object sender, RoutedEventArgs e)
        {
            Description wnd = new Description();
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
            //string[] newpath = ((Film)filmList.SelectedItem).poster.Split(new char[] { '\\' });
            wnd.poster.Source = new BitmapImage(new Uri(((Film)filmList.SelectedItem).poster, UriKind.Absolute));
            wnd.nameText.Text = ((Film)filmList.SelectedItem).name;
            wnd.durationText.Text = ((Film)filmList.SelectedItem).duration;
            string year = ((Film)filmList.SelectedItem).year;
            year = year.Remove(0, 6);
            year = year.Remove(4, 8);
            year += " г.";
            wnd.yearText.Text = year;
            wnd.descriptionText.Text = ((Film)filmList.SelectedItem).description;
            wnd.genreText.Text = ((Film)filmList.SelectedItem).genre;
            wnd.ageText.Text = ((Film)filmList.SelectedItem).age;

            wnd.image = ((Film)filmList.SelectedItem).poster;
            wnd.name = ((Film)filmList.SelectedItem).name;
            wnd.duration = ((Film)filmList.SelectedItem).duration;
            wnd.year = year;
            wnd.description = ((Film)filmList.SelectedItem).description;
            wnd.genre = ((Film)filmList.SelectedItem).genre;
            wnd.age = ((Film)filmList.SelectedItem).age;
            wnd.role = role;
            wnd.endSub = endSub;
            wnd.usID = usID;
            wnd.videoPath = ((Film)filmList.SelectedItem).videoPath;


            wnd.Show();
            this.Close();

        }

        private void addNewFilm_Click(object sender, RoutedEventArgs e)
        {
            AddFilm wnd = new AddFilm();
            wnd.role = role;
            wnd.endSub = endSub;
            wnd.usID = usID;
            wnd.Show();
            this.Close();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            QueryBuilder();
        }

        private void filt_genre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            QueryBuilder();
        }
        public void QueryBuilder()
        {
            string query = $"select Name_Film, Duration_Film, Release_Date_Film, Description_Film, Image_Path_Film,genre.Genre_Film,age_reiting.Age_Rating_Film, Videio_Path_Film from film join genre on film.Genre_Film = genre.ID_Genre join age_reiting on film.Age_Reiting = age_reiting.id_age_reiting";
            if (search.Text != "")
            {
                query += $" where Name_Film like '%{search.Text}%'";
                if (filt_genre.SelectedValue != null)
                {
                    if (filt_genre.SelectedIndex > 0)
                    {
                        query += $" and genre.Genre_Film like '%{filt_genre.SelectedItem}%'";
                    }
                }
            }
            else
            {
                if (filt_genre.SelectedValue != null)
                {
                    if (filt_genre.SelectedIndex > 0)
                    {
                        query += $" where genre.Genre_Film like '%{filt_genre.SelectedItem}%'";
                    }
                }
            }
            postersResult(query);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            filt_genre.Items.Add("Все жанры");
            ComboGenre($"select Genre_Film from genre");
            if (role == 1)
            {
                addNewFilm.Visibility = Visibility.Visible;
            }
            else if (role == 2)
            {
                addNewFilm.Visibility = Visibility.Collapsed;
            }
        }

        public void ComboGenre(string query)
        {
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            con.Open();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string poi = $"{dt.Rows[i][0]}";
                filt_genre.Items.Add(poi);
            }
        }

        private void fullScreenBtn_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowStyle != WindowStyle.None)
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
    }
}
