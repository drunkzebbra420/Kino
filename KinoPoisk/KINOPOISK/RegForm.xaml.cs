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

namespace KINOPOISK
{
    /// <summary>
    /// Логика взаимодействия для RegForm.xaml
    /// </summary>
    public partial class RegForm : Window
    {
        public MySqlConnection con;
        string connection = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public RegForm()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void REGISTBut_Click(object sender, RoutedEventArgs e)
        {
            if (SurnameBox.Text != "" && NameBox.Text != "" && LoginBoxReg.Text != "" && PassBoxReg.Password != "")
            {
                registrac();
                LogForm wnd = new LogForm();
                wnd.Show();
                this.Close();
            }
            else
            {
                CustomMsg wnd = new CustomMsg();
                wnd.custMSG.Text = "Заполните поля";
                wnd.Show();
            }

        }


        public void registrac()
        {
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter($"insert user (ID_user, Surname_user, Name_user, Patronymic_user, Login_user, Password_user, Role_user, sub_status_user, End_SUB_user) value(ID_user,'{SurnameBox.Text}','{NameBox.Text}','{PatronymicBox.Text}','{LoginBoxReg.Text}','{PassBoxReg.Password}',2, 2, '2000-01-01')", con);
            con.Open();
            adapter.Fill(dt);
        }

        private void BacktoMain_Click(object sender, RoutedEventArgs e)
        {
            LogForm op = new LogForm();
            op.Show();
            this.Close();
        }
    }
}
