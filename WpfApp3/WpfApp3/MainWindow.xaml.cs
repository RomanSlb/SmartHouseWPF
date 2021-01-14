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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdddev_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Close();
        }

        private void btnDevices_Click(object sender, RoutedEventArgs e)
        {
            MyDevices myDevices = new MyDevices();
            myDevices.Show();
            this.Close();
        }
    }
}
