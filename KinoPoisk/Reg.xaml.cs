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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public MySqlConnection con;
        string connect = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public Reg()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void REGISTBut_Click(object sender, RoutedEventArgs e)
        {
            if(SurnameBox.Text!= "" && NameBox.Text!="" && LoginBoxReg.Text!=""&& PassBoxReg.Password!="")
            {
                registrac();
                MainWindow op = new MainWindow();
                op.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }

        }


        public void registrac()
        {
            con = new MySqlConnection(connect);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter($"insert user (ID_user, Surname_user, Name_user, Patronymic_user, Login_user, Password_user, Role_user) value(ID_user,'{SurnameBox.Text}','{NameBox.Text}','{PatronymicBox.Text}','{LoginBoxReg.Text}','{PassBoxReg.Password}',2)", con);
            con.Open();
            adapter.Fill(dt);
            
        }

        private void BacktoMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow op = new MainWindow();
            op.Show();
            this.Close();
        }
    }
    }
