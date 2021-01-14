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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MyDevices.xaml
    /// </summary>
    public partial class MyDevices : Window
    {
        public MyDevices()
        {
            InitializeComponent();
        }
        private void btnClimat_Click(object sender, RoutedEventArgs e)
        {
            Climat climat = new Climat();
            climat.Show();
            this.Close();
        }
        private void btnAnother_Click(object sender, RoutedEventArgs e)
        {
            Devices devices = new Devices();
            devices.Show();
            this.Close();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

