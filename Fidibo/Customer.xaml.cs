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
        Customer_Class customer;
        public Customer(Customer_Class cc)
        {
            customer = cc;
            InitializeComponent();
            New_Name_Text_Box.Text = customer.userName;
            New_Email_Text_Box.Text = customer.email;
            New_Password_Password_Box.Password = customer.password;
            New_Phone_Number_Text_Box.Text = customer.phoneNumber;
            Welcome_name_Text_Block.Text = customer.userName;
        }

        private void Wallet_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Visible;
            Library_Border.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            Bookmarks_Border.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;
            Cash_TextBlock.Text = customer.wallet + " $";
        }

        private void Library_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Visible;
            Cart_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            Bookmarks_Border.Visibility = Visibility.Collapsed;
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
            Bookmarks_Border.Visibility = Visibility.Collapsed;
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
            Bookmarks_Border.Visibility = Visibility.Collapsed;
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
            Bookmarks_Border.Visibility = Visibility.Collapsed;
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
            Bookmarks_Border.Visibility = Visibility.Visible;
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
            Bookmarks_Border.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Visible;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;

        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(true);
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
            double deposit;
            try
            {
                string[] s = DateTime.Now.ToString().Split(new char[] {'/' ,' ' },StringSplitOptions.RemoveEmptyEntries);
                deposit = double.Parse(Amount_Of_Money_Box.Text);
                if (deposit < 0)
                    throw new Exception("Only nonnegative value !!");
                if (!Customer_Class.IsValidCardNumber(Card_Number_Box.Text))
                    throw new Exception("The card number is wrong !!");
                if (int.Parse(Expiration_Year_Box.Text) <= 0 || int.Parse(Expiration_month_Box.Text) > 12 || int.Parse(Expiration_month_Box.Text) < 1)
                    throw new Exception("Wrong date !!");
                if (!Customer_Class.IsValidCVV(CVV2_Box.Text))
                    throw new Exception("Wrong CVV2");
                if (int.Parse(s[1]) + int.Parse(s[2]) * 12 > int.Parse(Expiration_Year_Box.Text) * 12 + int.Parse(Expiration_month_Box.Text))
                    throw new Exception("Your card is expired !!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Expiration_Year_Box.Text = null;
                Expiration_month_Box.Text = null;
                Amount_Of_Money_Box.Text = null;
                Card_Number_Box.Text = null;
                CVV2_Box.Text = null;
                return;
            }

            customer.wallet += deposit;
            MessageBox.Show("Transfored money into your wallet !!");
            Expiration_Year_Box.Text = null;
            Expiration_month_Box.Text = null;
            Amount_Of_Money_Box.Text = null;
            Card_Number_Box.Text = null;
            CVV2_Box.Text = null;
        }

        private void Back_To_Wallet_Click(object sender, RoutedEventArgs e)
        {
            Wallet_Border.Visibility = Visibility.Visible;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;
            Cash_TextBlock.Text = customer.wallet + " $";
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

        private void Apply_Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Customer_Class.IsValidUserName(New_Name_Text_Box.Text))
                    throw new Exception("Wrong form for name !!");
                if (!Customer_Class.IsValidPhoneNumber(New_Phone_Number_Text_Box.Text))
                    throw new Exception("Wrong form for phone number !!");
                if (!Customer_Class.IsValidEmail(New_Email_Text_Box.Text))
                    throw new Exception("Wrong form for email !!");

                if (New_Email_Text_Box.Text != customer.email)
                    if (!Customer_Class.IsValidEmail2(New_Email_Text_Box.Text))
                        throw new Exception("This email already exist !!");

                if (!Customer_Class.IsValidPassword(New_Password_Password_Box.Password))
                    throw new Exception("Wrong form for password !!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                New_Name_Text_Box.Text = customer.userName;
                New_Email_Text_Box.Text = customer.email;
                New_Password_Password_Box.Password = customer.password;
                New_Phone_Number_Text_Box.Text = customer.phoneNumber;
                return;
            }

            string oldemail = customer.email;

            customer.userName = New_Name_Text_Box.Text;
            customer.email = New_Email_Text_Box.Text;
            customer.phoneNumber = New_Phone_Number_Text_Box.Text;
            customer.password = New_Password_Password_Box.Password;

            Customer_Class.UpdateCustomerTable(oldemail, customer);

            MessageBox.Show("Your profile were edited succesfully !!");

        }
    }
}