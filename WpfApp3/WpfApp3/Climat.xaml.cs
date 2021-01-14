using System;
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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Climat.xaml
    /// </summary>
    public partial class Climat : Window
    {
        public Climat()
        {
            DataContext = this;
            InitializeComponent();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MyDevices myDevices = new MyDevices();
            myDevices.Show();
            this.Close();
        }
        private void txtTemperature_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private int _boundNumber;
        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                if (_boundNumber != value)
                {
                    _boundNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand temp = new MySqlCommand("  UPDATE temperature SET Degrees = @uD ", db.getConnection());
            temp.Parameters.Add("@uD", MySqlDbType.Int16).Value = txtTemperature.Text;

            db.openConnection();

            if (temp.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You changed home temperature");
            }
            else
            {
                    MessageBox.Show("Error");
            }
            db.closeConnection();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtTemperature.Text = slider.Value.ToString();
        }


    }
}
