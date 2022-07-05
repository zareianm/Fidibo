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
        Book_Class b;

        public Customer_Class customer;
        public List<Book_Class> libraryList { get; set; }
        public List<Book_Class> showData { get; set; }
        public List<Book_Class> books { get; set; }
        public Customer(Customer_Class cc)
        {
            customer = cc;
            string[] s = customer.buyedBooks.Split(' ');

            libraryList = new List<Book_Class>();
            showData = new List<Book_Class>();
            foreach (var item in s)
            {
                int a = Book_Class.IndexOfBook(item);
                if (a != -1)
                    libraryList.Add(Book_Class.books[a]);
            }
            books = new List<Book_Class>();
            foreach (var item in Book_Class.books)
            {
                books.Add(item);
            }
            InitializeComponent();
            New_Name_Text_Box.Text = customer.userName;
            New_Email_Text_Box.Text = customer.email;
            New_Password_Password_Box.Password = customer.password;
            New_Phone_Number_Text_Box.Text = customer.phoneNumber;
            Welcome_name_Text_Block.Text = customer.userName;

            DataContext = this;
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
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;

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
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;

        }

        private void Cart_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            Bookmarks_Border.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Visible;
            showData.Clear();

            foreach (var item in books)
            {
                if (customer.cart.Contains(item.name))
                    showData.Add(item);
            }
            Cart_Border.Visibility = Visibility.Visible;

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
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;

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
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;

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
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;

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
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;

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
                string[] s = DateTime.Now.ToString().Split(new char[] { '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
            catch (Exception ex)
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
            catch (Exception ex)
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

        private void Search_By_Writer_Name_Click(object sender, RoutedEventArgs e)
        {
            showData.Clear();

            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Visible;

            foreach (var item in books)
            {
                if (item.writer == Writer_Search_Text_Box.Text)
                    showData.Add(item);
            }

            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Visible;
        }
        private void Search_By_Book_Name_Click(object sender, RoutedEventArgs e)
        {
            showData.Clear();

            Searched_Book_By_Name_ItemContorol.Visibility = Visibility.Visible;

            foreach (var item in books)
            {
                if (item.name == Name_Search_Text_Box.Text)
                    showData.Add(item);
            }

            Searched_Book_By_Name_ItemContorol.Visibility = Visibility.Visible;
        }
        private void Open_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            SearchBy_Writer_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            Show_Book_Border.Visibility = Visibility.Visible;
            Library_Border.Visibility = Visibility.Collapsed;

            Button button = sender as Button;
            b = button.DataContext as Book_Class;

            Book_Text_block.Text = b.name;
            Writer_Text_block.Text = b.writer;
            summary_Text_Block.Text = b.summary;

            if (customer.buyedBooks.Contains(b.name))
                Add_To_Cart_Or_Read_Button.Content = "Read";
            else
                Add_To_Cart_Or_Read_Button.Content = "Buy " + b.price + "$";

            if (customer.markedBooks.Contains(b.name))
            {
                Uri resourceUri = new Uri("Resources/fullbookmark.PNG", UriKind.Relative);
                BookMark_Image.Source = new BitmapImage(resourceUri);
            }

            else
            {
                Uri resourceUri = new Uri("Resources/emptybookmark.PNG", UriKind.Relative);
                BookMark_Image.Source = new BitmapImage(resourceUri);
            }

            string s = System.IO.Path.GetFullPath(@"coverResources/" + b.name + ".jpg");
            ////s += "file:/"+"/"+"/";
            System.Uri i = new Uri(s);
            wb.Source = i;
            wb.Visibility = Visibility.Visible;
        }
        private void Mark_Book_Button_Click(object sender, RoutedEventArgs e)
        {

            if (customer.markedBooks != null)
            {
                if (customer.markedBooks.Contains(b.name))
                {
                    Uri resourceUri = new Uri("Resources/emptybookmark.PNG", UriKind.Relative);
                    BookMark_Image.Source = new BitmapImage(resourceUri);

                    string temp = customer.markedBooks.Remove(customer.markedBooks.IndexOf(b.name), b.name.Length + 1);
                    customer.markedBooks = temp;
                }

                else
                {
                    Uri resourceUri = new Uri("Resources/fullbookmark.PNG", UriKind.Relative);
                    BookMark_Image.Source = new BitmapImage(resourceUri);
                    customer.markedBooks += b.name + " ";
                }
            }
            else
            {
                Uri resourceUri = new Uri("Resources/fullbookmark.PNG", UriKind.Relative);
                BookMark_Image.Source = new BitmapImage(resourceUri);
                customer.markedBooks = b.name + " ";
            }

            Customer_Class.UpdateCustomerTable(customer.email, customer);
        }
        private void Add_To_Cart_Or_Read_Button_Click(object sender, RoutedEventArgs e)
        {

            if (Add_To_Cart_Or_Read_Button.Content != null && Add_To_Cart_Or_Read_Button.Content == "Read")
            {

                string s = System.IO.Path.GetFullPath(@"PDFResources/" + b.name + ".pdf");
                ////s += "file:/"+"/"+"/";
                System.Uri i = new Uri(s);
                PDF_Webbrowser.Source = i;
                PDF_Webbrowser.Visibility = Visibility.Visible;
                Close_PDF_Button.Visibility = Visibility.Visible;
            }
            else
            {
                if (!customer.buyedBooks.Contains(b.name))
                {
                    if (!customer.cart.Contains(b.name))
                    {
                        if (customer.cart != null)
                            customer.cart += b.name;
                        else
                            customer.cart = b.name;

                        Customer_Class.UpdateCustomerTable(customer.email, customer);

                        MessageBox.Show("Book were added into your cart !!");
                    }
                    else
                        MessageBox.Show("This book is already in your cart !!");
                }

                else
                    MessageBox.Show("You already have buyed this book");

            }
        }
        private void Close_PDF_Button_Click(object sender, RoutedEventArgs e)
        {
            PDF_Webbrowser.Visibility = Visibility.Collapsed;
            Close_PDF_Button.Visibility = Visibility.Collapsed;
        }

        private void Go_To_Delete_Item_From_Cart_Button_Click(object sender, RoutedEventArgs e)
        {
            Delete_Book_Cart_Border.Visibility = Visibility.Visible;
            Cart_Border.Visibility = Visibility.Collapsed;

        }

        private void Pay_For_Book_In_Cart_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_To_Cart_From_Deleting_Button_Click(object sender, RoutedEventArgs e)
        {
            Delete_Book_Cart_Border.Visibility = Visibility.Collapsed;

            Welcome_Border.Visibility = Visibility.Collapsed;
            Wallet_Border.Visibility = Visibility.Collapsed;
            Library_Border.Visibility = Visibility.Collapsed;
            Buy_VIP_Border.Visibility = Visibility.Collapsed;
            Search_Border.Visibility = Visibility.Collapsed;
            Bookmarks_Border.Visibility = Visibility.Collapsed;
            Edit_Profile_Border.Visibility = Visibility.Collapsed;
            Raise_Balance_Border.Visibility = Visibility.Collapsed;
            Show_Book_Border.Visibility = Visibility.Collapsed;
            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Collapsed;
            Cart_Border.Visibility = Visibility.Visible;

            showData.Clear();

            foreach (var item in books)
            {
                if (customer.cart.Contains(item.name))
                    showData.Add(item);
            }
            Cart_Border.Visibility = Visibility.Visible;
        }

        private void Delete_Check_Box_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            b = checkbox.DataContext as Book_Class;

            string temp = customer.cart.Remove(customer.cart.IndexOf(b.name), b.name.Length + 1);
            customer.cart = temp;
        }

        private void Delete_Check_Box_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            b = checkbox.DataContext as Book_Class;

            customer.cart += b.name + " ";
        }
    }
}