using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;

        }

        private void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void txtDev_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void txtType_PreviewTextInputd(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z]");
            e.Handled = !(regex.IsMatch(e.Text));
        }
        private void txtKind_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z]");
            e.Handled = !(regex.IsMatch(e.Text));
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDev.Text))
            {
                MessageBox.Show("Name box is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtKind.Text))
            {
                MessageBox.Show("Kind box is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtType.Text))
            {
                MessageBox.Show("Type box is empty");
                return;
            }
            if (txtDev.Text.Length > 20)
            {
                MessageBox.Show("Name is too long");
                return;
            }
            if (txtKind.Text.Length > 20)
            {
                MessageBox.Show("Kind is too long");
                return;
            }
            if (txtType.Text.Length > 20)
            {
                MessageBox.Show("Type is too long");
                return;
            }
           


            if (isDevExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO dev (Type, Kind, DevName) VALUES (@type, @kind, @name)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtDev.Text;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = txtType.Text;
            command.Parameters.Add("@kind", MySqlDbType.VarChar).Value = txtKind.Text;
            if ((txtType.Text == "TV") || (txtType.Text == "Sound") || (txtType.Text == "Lightening") || (txtType.Text == "Locks") || (txtType.Text == "Cameras") || (txtType.Text == "Windows") || (txtType.Text == "Kettlers"))   
            {
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Device connected");
                else
                    MessageBox.Show("Device is not connected");

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Error");
            }


        }
            public Boolean isDevExists()
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM dev WHERE DevName = @uL ", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = txtDev.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Device is already connected");
                    return true;
                }
                else
                    return false;
            }
        }
        
    }

