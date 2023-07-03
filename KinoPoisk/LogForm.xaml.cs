using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// <summary>
    /// Логика взаимодействия для LogForm.xaml
    /// </summary>
    public partial class LogForm : Window
    {
        public MySqlConnection con;
        string connection = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public LogForm()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void LoginBut_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "" && PassBox.Password == "")
            {
                MessageBox.Show("Заполните поля", "Ошибка");

            }
            else if (PassBox.Password == "")
            {
                MessageBox.Show("Заполните пароль", "Ошибка");
            }
            else if (LoginBox.Text == "")
            {
                MessageBox.Show("Заполните логин", "Ошибка");
            }
            else
            {
                Autorisation();
            }
        }


        public void Autorisation()
        {
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter($"select ID_user, Surname_user, Name_user, Patronymic_user, Login_user, Password_user, Role_user, sub_status_user from user where Login_user = '{LoginBox.Text}' and Password_user = '{PassBox.Password}'", con);
            con.Open();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int role = Convert.ToInt32(dt.Rows[0][6]);
                MainWindow obj = new MainWindow();
                obj.role = role;
                obj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка");
                PassBox.Password = "";
            }
        }

        private void REGBut_Click(object sender, RoutedEventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }
    }
}
