using Microsoft.Data.SqlClient;
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
            string command = "select * from T_Customers";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
  
                    new Customer_Class(data.Rows[i][0].ToString(), data.Rows[i][3].ToString(), data.Rows[i][2].ToString(), data.Rows[i][1].ToString(), data.Rows[i][7].ToString(), data.Rows[i][6].ToString(), data.Rows[i][5].ToString(), DateTime.Now, double.Parse(data.Rows[i][4].ToString()));

            }
            con.Close();
            InitializeComponent();
        }

        public MainWindow(bool b)
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


            if (admin_password_box.Password == "1234" && admin_email_box.Text == "Admin@gmail.com")
            {
                string command = "select * from T_Admin where Email = '" + admin_email_box.Text + "'";
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                DataTable data = new DataTable();
                adapter.Fill(data);

                Admin_Class admin = new Admin_Class(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(),int.Parse( data.Rows[0][3].ToString())  ); 

                Admin a = new Admin(admin);
                a.Show();
                this.Close();
            }
        }

        private void Customer_Login_Button_Click(object sender, RoutedEventArgs e)
        {
            string command = "select * from T_Customers where Email = '" + customer_email_box.Text + "'";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("There is no customer by that email !!");
                return;
            }

            if (data.Rows[0][3].ToString() != customer_password_box.Password)
            {
                MessageBox.Show("Wrong password !!");
                return;
            }

            Customer_Class cc = Customer_Class.customers[Customer_Class.IndexOfCustomer(customer_email_box.Text)];

            Customer c = new Customer(cc);
            con.Close();
            c.Show();
            this.Close();
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
            Customer_Class cc;

            try
            {
                cc = new Customer_Class(Email_Sign_Up_Box.Text, Password_Sign_Up_Box.Password, Phone_Box.Text, Name_Box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Customer c = new Customer(cc);
            c.Show();
            this.Close();
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