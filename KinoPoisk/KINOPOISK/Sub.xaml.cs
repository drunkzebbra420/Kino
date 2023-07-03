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
    /// <summary>
    /// Логика взаимодействия для Sub.xaml
    /// </summary>
    public partial class Sub : Window
    {
        public Sub()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public MySqlConnection con;
        string connection = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public int usID;
        public int role;

        private void subConfirm_Click(object sender, RoutedEventArgs e)
        {
            DateTime startSub = DateTime.Now;
            DateTime endSub = startSub.AddMonths(1);
            con = new MySqlConnection(connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter($"update user set start_SUB_user = '{startSub.Year}-{startSub.Month}-{startSub.Day}', End_SUB_user = '{endSub.Year}-{endSub.Month}-{endSub.Day}' where ID_user = '{usID}';", con);
            con.Open();
            adapter.Fill(dt);
            MainWindow wnd1 = new MainWindow();
            wnd1.endSub = endSub;
            wnd1.role = role;
            wnd1.usID = usID;
            wnd1.Show();
            CustomMsg wnd = new CustomMsg();
            wnd.custMSG.Text = "Подписка успешно оформлена/продлена!";
            wnd.Show();
            this.Close();
        }
    }
}
