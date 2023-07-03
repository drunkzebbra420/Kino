using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace KinoPoisk
{
    /// <summary>
    /// Логика взаимодействия для prosmotr.xaml
    /// </summary>
    public partial class prosmotr : Window
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

        }
        List<Film> obj = new List<Film>();
        public MySqlConnection con;
        string connection = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public prosmotr()
        {
            InitializeComponent();
            postersResult("select Name_Film, Duration_Film, Release_Date_Film, Description_Film, Image_Path_Film,genre.Genre_Film,age_reiting.Age_Rating_Film from film join genre on film.Genre_Film = genre.ID_Genre join age_reiting on film.Age_Reiting = age_reiting.id_age_reiting");

        }

        public void postersResult(string query)
        {
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            con.Open();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string path = $"ima\\{dt.Rows[i][4]}";
                obj.Add(new Film()
                {
                    name = dt.Rows[i][0].ToString(),
                    duration = dt.Rows[i][1].ToString(),
                    year = dt.Rows[i][2].ToString(),
                    description = dt.Rows[i][3].ToString(),
                    poster = path,
                    genre = dt.Rows[i][5].ToString(),
                    age = dt.Rows[i][6].ToString(),
                });
            }
            filmList.ItemsSource = obj;
        }

        private void moreBtn_Click(object sender, RoutedEventArgs e)
        {

        }


        private void delFilm(object sender, RoutedEventArgs e)
        {
        
        }


            private void addFilm_Click(object sender, RoutedEventArgs e)
        {
            addFilmForm add = new addFilmForm();
            add.Show();
            this.Hide();
        }
    }
}




