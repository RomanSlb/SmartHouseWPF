using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
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
    /// Логика взаимодействия для RegistrationScreen.xaml
    /// </summary>
    public partial class RegistrationScreen : Window
    {
        public RegistrationScreen()
        {
            InitializeComponent();
            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;

        }

        private void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Name box is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtsurname.Text))
            {
                MessageBox.Show("Last name box is empty");
                return;
            }  
            if (txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Name is too long");
                return;
            }
            if (txtsurname.Text.Length > 20)
            {
                MessageBox.Show("Last Name is too long");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (UserName, Password, Name, Surname) VALUES (@login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = txtsurname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account created");
            else
                MessageBox.Show("Account was not created");

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE UserName = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = txtUsername.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Username is in using, choose another username");
                return true;
            }
            else
                return false;
        }

        private void txtUsername_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z]");
            e.Handled = !(regex.IsMatch(e.Text));
        }

        private void txtsurname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z]");
            e.Handled = !(regex.IsMatch(e.Text));
        }
    

    private void btnLogin_Click(object sender, RoutedEventArgs e)
        {   

            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();

        }
    }

}

