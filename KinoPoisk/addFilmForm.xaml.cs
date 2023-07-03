using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using System.IO;
using Org.BouncyCastle.Crypto;

namespace KinoPoisk
{
    /// <summary>
    /// Логика взаимодействия для addFilmForm.xaml
    /// </summary>
    public partial class addFilmForm : Window
    {
        public MySqlConnection con;
        string connect = "server=localhost;port=3306;user=root;database=kinopoisk;password=1488;";
        public addFilmForm()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            hanr("select Genre_Film from genre");
            age("select Age_Rating_Film from age_reiting");
        }
        public int i = 0;
        String query;
        //int d = 0;

        public void hanr(String qwery)
        {
            con = new MySqlConnection(connect);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(qwery, con);
            con.Open();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string poi = $"{dt.Rows[i][0]}";
                hanrBox.Items.Add(poi);
            }
        }

        public void age(String qwery)
        {
            con = new MySqlConnection(connect);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(qwery, con);
            con.Open();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string poi = $"{dt.Rows[i][0]}";
                ageBox.Items.Add(poi);
            }
        }


        //private void Image_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Image.Source = new BitmapImage(new Uri(putImag.Text, UriKind.Relative));
        //}

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {

            if (titleName.Text != "" && dlitelnost.Text != null && date.Text != "" && opis.Text != "" && hanrBox.SelectedItem != null && ageBox.SelectedItem != null)
            {
                con = new MySqlConnection(connect);
                DataTable dt = new DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter($"select distinct materialtypeid from material join materialtype on material.materialtypeid = materialtype.id where materialtype.title='{typeMaterial.SelectedItem}' ", con);
                DataTable dm = new DataTable();

                //{
                // DataTable dt2 = new DataTable();
                // DataTable dt3 = new DataTable();
                // MessageBox.Show(suppl[i]);
                // MySqlDataAdapter adapter2 = new MySqlDataAdapter($"SELECT ID from supplier where Title='{suppl[i]}' ", con);
                // adapter2.Fill(dt2);
                // MessageBox.Show(dt2.Rows[0][0].ToString() + " " + i.ToString());
                // string id_supplier = dt2.Rows[0][0].ToString();
                // MySqlDataAdapter adapter3 = new MySqlDataAdapter($"INSERT INTO materialsupplier (MaterialID, SupplierID) values ('{Convert.ToInt32(id_material_new) + 1}','{Convert.ToInt32(id_supplier)}')", con);
                // adapter3.Fill(dt3);
                //}

                con.Open();
                //adapter.Fill(dt);
                //query = $"Insert into material (ID,Title,CountInPack, Unit,CountInStock,MinCount,Cost,image,materialtypeid) values ({Convert.ToInt32(id_material_new)+1},'{titleName.Text}',{Convert.ToDouble(countInPack.Text)},'{unit.Text}',{Convert.ToDouble(countInStock.Text)},{Convert.ToDouble(minCount.Text)},{Convert.ToDouble(Cost.Text)},'{putImag.Text}',{dt.Rows[0][0]})";
                MessageBox.Show(query);
                MySqlDataAdapter adapterm = new MySqlDataAdapter(query, con);
                adapterm.Fill(dm);
                //MessageBox.Show(dt.Rows[0][0].ToString());
                con.Close();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

        }


        private void imageStav_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                
            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                    // Open document
                string filename = dlg.FileName;
                //string[] mas = filename.Split('\\');
                // putImag.Text = "/" + mas[mas.Length - 2] + "/" + mas[mas.Length - 1];
                putImag.Text = filename;
                ImageSourceConverter imgsc = new ImageSourceConverter(); 
                ImageSource imageSource = (ImageSource)imgsc.ConvertFromString(filename);
                imagPokaz.Source = imageSource;

            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {

           

        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

