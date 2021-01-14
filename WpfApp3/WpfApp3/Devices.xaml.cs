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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Devices.xaml
    /// </summary>
    public partial class Devices : Window
    {
        public Devices()
        {
            InitializeComponent();
        }

        private void btnLightening_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand lightening = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'Lightening' AND Switch = b'0' ", db.getConnection());
            MySqlCommand lightenin = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'Lightening' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (lightening.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Lightening switchs on");
            } 
            else
            {
                if (lightenin.ExecuteNonQuery() == 1)
                MessageBox.Show("Lightening switch off");
            }
            db.closeConnection();            
        }

        private void btnLocks_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand Locks = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'Locks' AND Switch = b'0' ", db.getConnection());
            MySqlCommand Lock = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'Locks' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (Locks.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Locks are lock");
            }
            else
            {
                if (Lock.ExecuteNonQuery() == 1)
                    MessageBox.Show("Locks are open");
            }
            db.closeConnection();
        }

        private void btnCameras_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand Cameras = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'Cameras' AND Switch = b'0' ", db.getConnection());
            MySqlCommand Camera = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'Cameras' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (Cameras.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Cameras ON");
            }
            else
            {
                if (Camera.ExecuteNonQuery() == 1)
                    MessageBox.Show("Cameras OFF");
            }
            db.closeConnection();
        }

        private void btnWindows_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand Windows = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'Windows' AND Switch = b'0' ", db.getConnection());
            MySqlCommand Window = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'Windows' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (Windows.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Windows closed");
            }
            else
            {
                if (Window.ExecuteNonQuery() == 1)
                    MessageBox.Show("Windows opened");
            }
            db.closeConnection();
        }

        private void btnKettlers_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand Kettlers = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'Kettlers' AND Switch = b'0' ", db.getConnection());
            MySqlCommand Kettler = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'Kettlers' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (Kettlers.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kettlers ON");
            }
            else
            {
                if (Kettler.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kettlers OFF");
            }
            db.closeConnection();
        }

        private void btnSpeakers_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand Speakers = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'Sound' AND Switch = b'0' ", db.getConnection());
            MySqlCommand Speaker = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'Sound' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (Speakers.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Music ON");
            }
            else
            {
                if (Speaker.ExecuteNonQuery() == 1)
                    MessageBox.Show("Music OFF");
            }
            db.closeConnection();
        }

        private void btnTV_Click(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            MySqlCommand TVs = new MySqlCommand("  UPDATE dev SET Switch = b'1' WHERE dev.Type = 'TV' AND Switch = b'0' ", db.getConnection());
            MySqlCommand TV = new MySqlCommand("  UPDATE dev SET Switch = b'0' WHERE dev.Type = 'TV' AND Switch = b'1' ", db.getConnection());

            db.openConnection();

            if (TVs.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("TV ON");
            }
            else
            {
                if (TV.ExecuteNonQuery() == 1)
                    MessageBox.Show("TV OFF");
            }
            db.closeConnection();
        }




        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MyDevices myDevices = new MyDevices();
            myDevices.Show();
            this.Close();
        }
    }
}
