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
            CustomMsg wnd = new CustomMsg();
            if (LoginBox.Text == "" && PassBox.Password == "")
            {
                wnd.custMSG.Text = "Заполните поля!";
                wnd.Show();

            }
            else if (PassBox.Password == "")
            {
                wnd.custMSG.Text = "Заполните пароль!";
                wnd.Show();
            }
            else if (LoginBox.Text == "")
            {
                wnd.custMSG.Text = "Заполните логин!";
                wnd.Show();
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
            MySqlDataAdapter adapter = new MySqlDataAdapter($"select ID_user, Surname_user, Name_user, Patronymic_user, Login_user, Password_user, Role_user, sub_status_user, End_SUB_user from user where Login_user = '{LoginBox.Text}' and Password_user = '{PassBox.Password}'", con);
            con.Open();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int usID = Convert.ToInt32(dt.Rows[0][0]);
                int role = Convert.ToInt32(dt.Rows[0][6]);
                DateTime endSub = Convert.ToDateTime(dt.Rows[0][8]);
                MainWindow obj = new MainWindow();
                obj.usID = usID;
                obj.endSub = endSub;
                obj.role = role;
                obj.Show();
                this.Close();
            }
            else
            {
                CustomMsg wnd = new CustomMsg();
                wnd.custMSG.Text = "Неверный логин или пароль!";
                wnd.Show();
                PassBox.Password = "";
            }
        }

        private void REGBut_Click(object sender, RoutedEventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Close();
        }
    }
}
