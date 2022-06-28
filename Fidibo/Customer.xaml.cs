using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fidibo
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Wallet_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Visible;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            BookMark_Button.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;
        }

        private void Library_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Visible;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            BookMark_Button.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void Cart_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Visible;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            BookMark_Button.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Visible;
            BookMark_Button.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void VIP_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Visible;
            Search_Border.Visibility = Visibility.Collapsed;
            BookMark_Button.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void BookMark_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            BookMark_Button.Visibility = Visibility.Visible;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void Edit_Profile_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            BookMark_Button.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Visible;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();

        }

        private void Go_To_Raise_Balance_Click(object sender, RoutedEventArgs e)
        {
            Wallet_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Visible;
        }

        private void Pay_Wallet_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_To_Wallet_Click(object sender, RoutedEventArgs e)
        {
            Wallet_Border.Visibility = Visibility.Visible;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;
        }

        private void Go_To_Search_By_Writer_Name_Click(object sender, RoutedEventArgs e)
        {
            SearchBy_Writer_Border.Visibility = Visibility.Visible;
            SearchBy_Book_Border.Visibility = Visibility.Collapsed;
        }

        private void Go_To_Search_By_Book_Name_Click(object sender, RoutedEventArgs e)
        {
            SearchBy_Writer_Border.Visibility = Visibility.Collapsed;
            SearchBy_Book_Border.Visibility = Visibility.Visible;
        }
    }
}
