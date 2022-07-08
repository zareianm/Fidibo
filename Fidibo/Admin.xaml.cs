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
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;

namespace Fidibo
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        static string coverPath;
        static string PDFPath;

        Admin_Class admin;

        public ObservableCollection<Customer_Class> customerData { get; set; }
        public ObservableCollection<Book_Class> showData { get; set; }

        Customer_Class c;
        Book_Class b;
        public Admin(Admin_Class admin)
        {
            this.admin = admin;

            customerData = new ObservableCollection<Customer_Class>();
            showData = new ObservableCollection<Book_Class>();
            InitializeComponent();
            DataContext = this;
        }

        private void Add_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Visible;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;
        }

        private void Edit_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Visible;
            Search_By_Book_Name_Border_Edit.Visibility = Visibility.Visible;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;

        }
        private void Search_By_Book_Name_BUtton_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text) != -1)
            {
                Search_By_Book_Name_Border_Edit.Visibility = Visibility.Collapsed;
                Edit__Information_Of_Book_Border.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("The book was not found");
                return;
            }
        }
        private void Apply_Changes_Of_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].name;

            if (New_Writer_Box.Text != "")
            {
                Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].writer = New_Writer_Box.Text;
            }
            try
            {
                if (New_Price_Box.Text != "")
                {
                    Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].price = int.Parse(New_Price_Box.Text);
                }
            }
            catch
            {
                MessageBox.Show("Please enter an integer for  price ");
                New_Price_Box.Text = "";

            }
            try
            {
                if (New_Year_Box.Text != "")
                {
                    Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].year = int.Parse(New_Year_Box.Text);
                }
            }
            catch
            {
                MessageBox.Show("Please enter an integer for year ");
                New_Price_Box.Text = "";
            }
            if (New_Summary_Text_Box.Text != "")
            {
                Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].summary = New_Summary_Text_Box.Text;
            }
            string command = "update T_Books set Writer = '" + Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].writer + "' , Price = '" + Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].price + "' , Summary = '" + Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].summary + "' , Year = '" + Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_Edit.Text)].year + "' where Name = '" + temp + "'";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ali\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            con.Close();
            New_Summary_Text_Box.Text = "";
            New_Year_Box.Text = "";
            New_Price_Box.Text = "";
            New_Writer_Box.Text = "";
            MessageBox.Show("Changes applied successfully ");
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Edit__Information_Of_Book_Border.Visibility = Visibility.Collapsed;
            Welcome_Border.Visibility = Visibility.Visible;
        }
        private void Show_Books_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Visible;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;

        }
        private void Customers_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Visible;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;

        }

        private void VIP_Setting_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Visible;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            VIP_Setting1_Border.Visibility = Visibility.Visible;
            Search_By_Book_Name_Border_VIP.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;
            New_Price_For_VIP_Box.Text = admin.vip_price.ToString();

        }
        private void Go_To_Add_New_Book_To_VIP_Button_Click(object sender, RoutedEventArgs e)
        {
            VIP_Setting_Border.Visibility = Visibility.Visible;
            VIP_Setting1_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border_VIP.Visibility = Visibility.Visible;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
        }

        private void Search_By_Book_Name_BUtton_VIP_Click(object sender, RoutedEventArgs e)
        {
            VIP_Setting_Border.Visibility = Visibility.Visible;
            VIP_Setting1_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border_VIP.Visibility = Visibility.Visible;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;

            if (Search_By_Book_Name_Box_VIP.Text == "")
            {
                MessageBox.Show("Please enter a name !!");
            }
            else if (Book_Class.IndexOfBook(Search_By_Book_Name_Box_VIP.Text) == -1)
            {
                MessageBox.Show("the book was not found !");
            }
            else
            {               
                Search_By_Book_Name_Border_VIP.Visibility = Visibility.Collapsed;
                Add_Book_To_VIP_Border.Visibility = Visibility.Visible;
            }
        }
        private void Add_Book_To_VIP_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_VIP.Text)].isVIP == false)
            {
                Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_VIP.Text)].isVIP = true;



                MessageBox.Show("successfully.!");

                string command2 = "update T_Admin set VIP_Price = '" + double.Parse(New_Price_For_VIP_Box.Text) + "'  where Email = '" + "Admin@gmail.com" + "'";

                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ali\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
                con2.Open();
                SqlCommand com2 = new SqlCommand(command2, con2);
                com2.BeginExecuteNonQuery();
                con2.Close();

                string command = "update T_Books set IsVIP = '" + Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_VIP.Text)].isVIP + "'  where Name = '" + Book_Class.books[Book_Class.IndexOfBook(Search_By_Book_Name_Box_VIP.Text)].name + "'";

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ali\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                com.ExecuteNonQuery();
                con.Close();

                VIP_Setting_Border.Visibility = Visibility.Visible;
                VIP_Setting1_Border.Visibility = Visibility.Visible;
                Search_By_Book_Name_Border_VIP.Visibility = Visibility.Collapsed;
                Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;

            }

            else
                MessageBox.Show("This book is already VIP !!");

        }

        private void Discout_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Visible;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;

        }

        private void Search_And_Set_Discount_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text) == -1 || Name_Of_Book_Box_Discount.Text=="")
            {
                MessageBox.Show("The book was not found");
                Name_Of_Book_Box_Discount.Text = "";
                Discount_amount_Box_Discount.Text = "";

            }
           
            try
            {
             if(double.Parse(Discount_amount_Box_Discount.Text)>100 || double.Parse( Discount_amount_Box_Discount.Text)<0 )
                {
                    MessageBox.Show("Discount must be between 0 and 100");
                    Discount_amount_Box_Discount.Text = "";
                }
             else
                {
                    Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].price = Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].price * (100) / (100 - Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].discount);
                    Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].discount = double.Parse(Discount_amount_Box_Discount.Text);
                    Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].price = Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].price * (100 - Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].discount) / 100;
                    string command = "update T_Books set Discount = '" + double.Parse(Discount_amount_Box_Discount.Text) + "' ,Price= '" + Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Box_Discount.Text)].price + "'   where Name = '" + Name_Of_Book_Box_Discount.Text + "'";

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ali\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand com = new SqlCommand(command, con);
                    com.BeginExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Discount applied");
                    Discount_amount_Box_Discount.Text = "";
                    Name_Of_Book_Box_Discount.Text = "";
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Discount_amount_Box_Discount.Text = "";
            }

        }
        private void Sale_Rate_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Visible;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            SearchBy_Book_Border.Visibility = Visibility.Visible;
            Show_Rate_And_Sale_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;

        }

        private void Search_By_Book_Name_Click(object sender, RoutedEventArgs e)
        {

            if (Book_Class.IndexOfBook(Name_Of_Book_Text_Box.Text) == -1)
            {
                MessageBox.Show("the book was not found !");
                return;
            }
            else
            {
                Rate_Text_Block.Text = Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Text_Box.Text)].rate.ToString();
                Sale_Text_Block.Text = (Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Text_Box.Text)].salesCount * Book_Class.books[Book_Class.IndexOfBook(Name_Of_Book_Text_Box.Text)].price).ToString();

                SearchBy_Book_Border.Visibility = Visibility.Collapsed;
                Show_Rate_And_Sale_Border.Visibility = Visibility.Visible;
                return;
            }

        }

        private void Safe_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Collapsed;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Visible;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Check_Password_Border.Visibility = Visibility.Visible;
            Safe_Cash_Border.Visibility = Visibility.Collapsed;
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Show_Customer_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Collapsed;

        }

        private void Check_Password_Button_Click(object sender, RoutedEventArgs e)
        {
            Check_Password_Border.Visibility = Visibility.Visible;
            Safe_Cash_Border.Visibility = Visibility.Collapsed;


            if (Check_password_box.Password == "1234")
            {
                Safe_TextBlock.Text = admin.safe_cash + " $";
                Check_Password_Border.Visibility = Visibility.Collapsed;
                Safe_Cash_Border.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Password is incorrect");
                return;
            }
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void Go_To_Transfer_Money_Button_Click(object sender, RoutedEventArgs e)
        {
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Visible;
        }

        private void Transfer_Money_Button_Click(object sender, RoutedEventArgs e)
        {
            double deposit;
            try
            {
                string[] s = DateTime.Now.ToString().Split(new char[] { '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                deposit = double.Parse(Amount_Of_Money_Box.Text);
                if (deposit < 0)
                    throw new Exception("Only nonnegative value !!");
                if (!Admin_Class.IsValidCardNumber(Card_Number_Box.Text))
                    throw new Exception("The card number is wrong !!");
                if (int.Parse(Expiration_Year_Box.Text) <= 0 || int.Parse(Expiration_month_Box.Text) > 12 || int.Parse(Expiration_month_Box.Text) < 1)
                    throw new Exception("Wrong date !!");
                if (!Admin_Class.IsValidCVV(CVV2_Box.Text))
                    throw new Exception("Wrong CVV2");
                if (int.Parse(s[1]) + int.Parse(s[2]) * 12 > int.Parse(Expiration_Year_Box.Text) * 12 + int.Parse(Expiration_month_Box.Text))
                    throw new Exception("Your card is expired !!");
                if (admin.safe_cash < int.Parse(Amount_Of_Money_Box.Text))
                    throw new Exception("the amount of money is greater than your balance");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Expiration_Year_Box.Text = "";
                Expiration_month_Box.Text = "";
                Amount_Of_Money_Box.Text = "";
                Card_Number_Box.Text = "";
                CVV2_Box.Text = "";
                return;
            }

            admin.safe_cash -= int.Parse(Amount_Of_Money_Box.Text);

            string command = "update T_Admin set Safe_Cash = '" + admin.safe_cash + "'";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Transfored money from your safe box !!");
            Expiration_Year_Box.Text = "";
            Expiration_month_Box.Text = "";
            Amount_Of_Money_Box.Text = "";
            Card_Number_Box.Text = "";
            CVV2_Box.Text = "";
            return;
        }

        private void Back_To_Safe_Setting_Button_Click(object sender, RoutedEventArgs e)
        {
            Safe_Setting_Border.Visibility = Visibility.Visible;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
        }

        private void Go_To_Search_By_Writer_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            Show_Books_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Visible;
            SearchBy_Book_Border.Visibility = Visibility.Collapsed;
        }

        private void Go_To_Search_By_Book_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            Show_Books_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Visible;
        }

        private void Back_To_List_Of_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            Show_Books_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            SearchBy_Book_Border.Visibility = Visibility.Visible;
        }

        private void Go_To_Search_By_Customer_Email_Button_Click(object sender, RoutedEventArgs e)
        {
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Email_Border.Visibility = Visibility.Visible;
        }

        private void Go_To_Search_By_Customer_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Visible;
        }

        private void Back_To_List_Of_Customer_Button_Click(object sender, RoutedEventArgs e)
        {
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;

        }

        private void BrowsePDFButton_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlgPDF = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlgPDF.ShowDialog();

            try
            {
                if (result == true)
                {
                    PDF_Address_Text_Block.Text = openFileDlgPDF.FileName;

                    string a = Name_Box.Text;
                    PDFPath = System.IO.Path.GetFullPath($@"PDFResources/" + a + ".pdf");

                    System.IO.File.Copy(openFileDlgPDF.FileName, PDFPath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PDF_Address_Text_Block.Text = "";
                Cover_Address_Text_Block.Text = "";
                Name_Box.Text = "";
                Writer_Box.Text = "";
                Price_Box.Text = "";
            }
        }

        private void BrowseSample_Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlgPDF = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlgPDF.ShowDialog();

            try
            {
                if (result == true)
                {
                    Sample_Address_Text_Block.Text = openFileDlgPDF.FileName;

                    string a = Name_Box.Text;
                    PDFPath = System.IO.Path.GetFullPath($@"SampleResources/" + a + ".jpg");

                    System.IO.File.Copy(openFileDlgPDF.FileName, PDFPath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PDF_Address_Text_Block.Text = "";
                Cover_Address_Text_Block.Text = "";
                Name_Box.Text = "";
                Writer_Box.Text = "";
                Price_Box.Text = "";
            }
        }
        private void BrowseCover_Button_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog openFileDlgCover = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openFileDlgCover.ShowDialog();

            try
            {


                if (result == true)
                {
                    Cover_Address_Text_Block.Text = openFileDlgCover.FileName;

                    string a = Name_Box.Text;
                    coverPath = System.IO.Path.GetFullPath($@"coverResources/" + a + ".jpg");

                    System.IO.File.Copy(openFileDlgCover.FileName, coverPath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PDF_Address_Text_Block.Text = "";
                Cover_Address_Text_Block.Text = "";
                Name_Box.Text = "";
                Writer_Box.Text = "";
                Price_Box.Text = "";
            }
        }

        private void Add_Book_Into_store_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PDF_Address_Text_Block.Text == "" || Cover_Address_Text_Block.Text == "" || Name_Box.Text == "" || Writer_Box.Text == "" || Price_Box.Text == "" || Year_Box.Text == "")
                    throw new Exception("Please fill all of the fields !!");

                if (Book_Class.IndexOfBook(Name_Box.Text) != -1)
                    throw new Exception("This book already exists !!");
                if (double.Parse(Price_Box.Text) < 0)
                    throw new Exception("Only nonnegative value for price !!");
                if (int.Parse(Year_Box.Text) < 0)
                    throw new Exception("Only nonnegative value for year !!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PDF_Address_Text_Block.Text = "";
                Cover_Address_Text_Block.Text = "";
                Name_Box.Text = "";
                Writer_Box.Text = "";
                Price_Box.Text = "";
                Year_Box.Text = "";
                System.IO.File.Delete(PDFPath);
                System.IO.File.Delete(coverPath);
                return;
            }

            new Book_Class(Name_Box.Text, Writer_Box.Text, double.Parse(Price_Box.Text), Summary_Text_Box.Text, int.Parse(Year_Box.Text));
            MessageBox.Show("Book were added succesfully !!");
            PDF_Address_Text_Block.Text = "";
            Cover_Address_Text_Block.Text = "";
            Name_Box.Text = "";
            Writer_Box.Text = "";
            Price_Box.Text = "";
            Year_Box.Text = "";
            return;

        }

        private void Search_By_Email_Buton_Click(object sender, RoutedEventArgs e)
        {
            customerData.Clear();

            foreach (var item in Customer_Class.customers)
            {
                if (item.email == Email_Search_Text_Box.Text)
                    customerData.Add(item);
            }
            Searched_Customer_By_Email_ItemContorol.Visibility = Visibility.Visible;

        }

        private void Search_By_Name_Buton_Click(object sender, RoutedEventArgs e)
        {
            customerData.Clear();

            foreach (var item in Customer_Class.customers)
            {
                if (item.userName == Name_Search_Text_Box.Text)
                    customerData.Add(item);
            }
            Searched_Customer_By_Name_ItemContorol.Visibility = Visibility.Visible;
        }

        private void Open_Customer_Button_Click(object sender, RoutedEventArgs e)
        {
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;

            Show_Customer_Border.Visibility = Visibility.Visible;
            Customers_Border.Visibility = Visibility.Collapsed;

            Button button = sender as Button;
            c = button.DataContext as Customer_Class;

            Customer_Name_Text_Block.Text = c.userName;
            Customer_Buyedbook_Text_Block.Text = "Buyed book : "+c.buyedBooks;
            Customer_Cartbook_Text_Block.Text = "Book in cart : " + c.cart;
            Customer_Bookmark_Text_Block.Text ="Bookmark : "+ c.markedBooks;
            Customer_VIPLeft_Time_Text_Block.Text = "VIP left time : " + c.CalculateLeftTime()+" days";

            Show_Customer_Border.Visibility = Visibility.Visible;

        }

        private void Search_By_Writer_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            showData.Clear();

            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Visible;

            foreach (var item in Book_Class.books)
            {
                if (item.writer == Search_By_Writer_Box.Text)
                    showData.Add(item);
            }

            Searched_Book_By_Writer_ItemContorol.Visibility = Visibility.Visible;
        }

        private void Search_By_Book_Name2_Click(object sender, RoutedEventArgs e)
        {
            showData.Clear();

            Searched_Book_By_Name_ItemContorol.Visibility = Visibility.Visible;

            foreach (var item in Book_Class.books)
            {
                if (item.name == Search_By_Book_Name_Box.Text)
                    showData.Add(item);
            }

            Searched_Book_By_Name_ItemContorol.Visibility = Visibility.Visible;
        }

        private void Search_By_Book_Name_Click_1(object sender, RoutedEventArgs e)
        {
            showData.Clear();

            Searched_Book_By_Name_ItemContorol.Visibility = Visibility.Visible;

            foreach (var item in Book_Class.books)
            {
                if (item.name == Search_By_Book_Name_Box.Text)
                    showData.Add(item);
            }

            Searched_Book_By_Name_ItemContorol.Visibility = Visibility.Visible;
        }

        private void Open_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            Show_Books_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            Open_Book_Border.Visibility = Visibility.Visible;


            Button button = sender as Button;
            b = button.DataContext as Book_Class;

            Book_Text_block.Text = b.name;
            Writer_Text_block.Text = "Writed by " +b.writer;
            summary_Text_Block.Text = b.summary;
            Year_Text_Block.Text = "Published year : " + b.year.ToString();

            if (b.isVIP)
                Is_VIP_Block_Text.Visibility = Visibility.Visible;
            else
                Is_VIP_Block_Text.Visibility = Visibility.Collapsed;

            if (b.discount.ToString() != "")
            {
                Discount_Block_Text.Text = "Discount: " + b.discount + "%";
                Discount_Block_Text.Visibility = Visibility.Visible;
            }

            else
                Discount_Block_Text.Visibility = Visibility.Collapsed;

            string s = System.IO.Path.GetFullPath(@"coverResources/" + b.name + ".jpg");
            System.Uri i = new Uri(s);
            wb.Source = i;
            wb.Visibility = Visibility.Visible;
        }

        private void Open_PDF_Button_Click(object sender, RoutedEventArgs e)
        {
            string s = System.IO.Path.GetFullPath(@"PDFResources/" + b.name + ".pdf");
            System.Uri i = new Uri(s);
            PDF_Webbrowser.Source = i;
            PDF_Webbrowser.Visibility = Visibility.Visible;
            Close_PDF_Button.Visibility = Visibility.Visible;
        }

        private void Close_PDF_Button_Click(object sender, RoutedEventArgs e)
        {
            PDF_Webbrowser.Visibility = Visibility.Collapsed;
            Close_PDF_Button.Visibility = Visibility.Collapsed;
        }

        private void Set_VIP_Price_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = double.Parse(New_Price_For_VIP_Box.Text);

                if (d < 0)
                    throw new Exception("Only nonnegative values !!");

                admin.vip_price = d;


                string command = "update T_Admin set VIP_Price = '" + admin.vip_price + "'";

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("The VIP Price was Updated ");
        }


    }
}