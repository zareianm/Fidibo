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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fidibo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Admin_Button_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login.Visibility = Visibility.Visible;
            login_border.Visibility = Visibility.Collapsed;
            Customer_Login.Visibility = Visibility.Collapsed;
            Customer_sign_up.Visibility = Visibility.Collapsed;
        }

        private void customer_button_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login.Visibility = Visibility.Collapsed;
            login_border.Visibility = Visibility.Collapsed;
            Customer_Login.Visibility = Visibility.Visible;
            Customer_sign_up.Visibility = Visibility.Collapsed;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {

            Admin_Login.Visibility = Visibility.Collapsed;
            login_border.Visibility = Visibility.Visible;
            Customer_Login.Visibility = Visibility.Collapsed;
            Customer_sign_up.Visibility = Visibility.Collapsed;
        }

        private void Admin_Login_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Customer_Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if(customer_password_box.Password == "ab" && customer_email_box.Text == "ab")
            {
                Customer c = new Customer();
                c.Show();
                this.Close();            }
        }

        private void go_to_sign_up_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login.Visibility = Visibility.Collapsed;
            login_border.Visibility = Visibility.Collapsed;
            Customer_Login.Visibility = Visibility.Collapsed;
            Customer_sign_up.Visibility = Visibility.Visible;
        }

        private void Sign_Up_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_To_Login_Button_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login.Visibility = Visibility.Collapsed;
            login_border.Visibility = Visibility.Collapsed;
            Customer_Login.Visibility = Visibility.Visible;
            Customer_sign_up.Visibility = Visibility.Collapsed;
        }
    }
}
