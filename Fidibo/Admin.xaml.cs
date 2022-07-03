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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        static string coverPath;
        static string PDFPath;
        public Admin()
        {
            InitializeComponent();
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
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
        }

        private void Edit_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Border.Visibility = Visibility.Collapsed;
            Add_Book_Border.Visibility = Visibility.Collapsed;
            Edit_Book_Border.Visibility = Visibility.Visible;
            Customers_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
            Discount_Setting_Border.Visibility = Visibility.Collapsed;
            Sale_Rate_Setting_Border.Visibility = Visibility.Collapsed;
            Safe_Setting_Border.Visibility = Visibility.Collapsed;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;

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
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;

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
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
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
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
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
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
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
            List_Of_Book_Border.Visibility = Visibility.Visible;
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;
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

        }

        private void Back_To_Safe_Setting_Button_Click(object sender, RoutedEventArgs e)
        {
            Safe_Setting_Border.Visibility = Visibility.Visible;
            Transfor_Money_Border.Visibility = Visibility.Collapsed;
        }

        private void Go_To_Search_By_Writer_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            List_Of_Book_Border.Visibility = Visibility.Collapsed;
            Search_By_Writer_Border.Visibility = Visibility.Visible;
        }

        private void Go_To_Search_By_Book_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            List_Of_Book_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Visible;
        }

        private void Back_To_List_Of_Book_Button_Click(object sender, RoutedEventArgs e)
        {
            Search_By_Writer_Border.Visibility = Visibility.Collapsed;
            Search_By_Book_Name_Border.Visibility = Visibility.Collapsed;
            List_Of_Book_Border.Visibility = Visibility.Visible;
        }

        private void Go_To_Search_By_Customer_Email_Button_Click(object sender, RoutedEventArgs e)
        {
            List_Of_Customer_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Email_Border.Visibility = Visibility.Visible;
        }

        private void Go_To_Search_By_Customer_Name_Button_Click(object sender, RoutedEventArgs e)
        {
            List_Of_Customer_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Visible;
        }

        private void Back_To_List_Of_Customer_Button_Click(object sender, RoutedEventArgs e)
        {
            List_Of_Customer_Border.Visibility = Visibility.Visible;
            Search_By_Customer_Email_Border.Visibility = Visibility.Collapsed;
            Search_By_Customer_Name_Border.Visibility = Visibility.Collapsed;

        }

        private void Go_To_Add_New_Book_To_VIP_Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Book_To_VIP_Border.Visibility = Visibility.Visible;
            VIP_Setting_Border.Visibility = Visibility.Collapsed;
        }

        private void Back_To_VIP_Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Book_To_VIP_Border.Visibility = Visibility.Collapsed;
            VIP_Setting_Border.Visibility = Visibility.Visible;
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
                PDF_Address_Text_Block.Text = null;
                Cover_Address_Text_Block.Text = null;
                Name_Box.Text = null;
                Writer_Box.Text = null;
                Price_Box.Text = null;
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
                    coverPath = System.IO.Path.GetFullPath($@"coverResources/" + a + ".png");

                    System.IO.File.Copy(openFileDlgCover.FileName, coverPath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PDF_Address_Text_Block.Text = null;
                Cover_Address_Text_Block.Text = null;
                Name_Box.Text = null;
                Writer_Box.Text = null;
                Price_Box.Text = null;
            }
        }

        private void Add_Book_Into_store_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PDF_Address_Text_Block.Text == null || Cover_Address_Text_Block.Text == null || Name_Box.Text == null || Writer_Box.Text == null || Price_Box.Text == null)
                    throw new Exception("Please fill all of the fields !!");

                if (Book_Class.IndexOfBook(Name_Box.Text) != -1)
                    throw new Exception("This book already exists !!");
                if (double.Parse(Price_Box.Text) < 0)
                    throw new Exception("Only nonnegative value !!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PDF_Address_Text_Block.Text = null;
                Cover_Address_Text_Block.Text = null;
                Name_Box.Text = null;
                Writer_Box.Text = null;
                Price_Box.Text = null;
                System.IO.File.Delete(PDFPath);
                System.IO.File.Delete(coverPath);
                return;
            }

            new Book_Class(Name_Box.Text, Writer_Box.Text, double.Parse(Price_Box.Text));
            MessageBox.Show("Book were added succesfully !!");
            PDF_Address_Text_Block.Text = null;
            Cover_Address_Text_Block.Text = null;
            Name_Box.Text = null;
            Writer_Box.Text = null;
            Price_Box.Text = null;
            return;

        }
    }
}