using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Fidibo
{
    public class Customer_Class
    {
        public string email { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public string userName { get; set; }
        public string buyedBooks { get; set; }
        public string markedBooks { get; set; }
        public string cart { get; set; }

        public DateTime? vipBegintTime { get; set; }
        public double wallet { get; set; }

        public static List<Customer_Class> customers = new List<Customer_Class>();

        public Customer_Class(string email, string password, string phoneNumber, string userName)
        {
            if (!(IsValidEmail(email) && IsValidPassword(password) && IsValidPhoneNumber(phoneNumber) && IsValidUserName(userName)))
                throw new Exception("Wrong input !! , please try again.");

            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.userName = userName;

            markedBooks = "";
            buyedBooks = "";
            cart = "";
            vipBegintTime = null;
            wallet = 0;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            string command = "insert into T_Customers values ('" + email + "','" + userName + "','" + phoneNumber + "','" + password + "','" + wallet + "','" + cart + "','" + markedBooks + "','" + buyedBooks + "','" + vipBegintTime + "')";
            SqlCommand com = new SqlCommand(command, con);
            com.ExecuteNonQuery();
            con.Close();

            customers.Add(this);
        }

        public Customer_Class(string email, string password, string phoneNumber, string userName, string buyedBooks, string markedBooks, string cart, DateTime? vipBegintTime, double wallet)
        {
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.userName = userName;
            this.markedBooks = markedBooks;
            this.buyedBooks = buyedBooks;
            this.cart = cart;
            this.vipBegintTime = vipBegintTime;
            this.wallet = wallet;

            customers.Add(this);

        }
        public static int IndexOfCustomer(string email)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].email == email)
                    return i;
            }

            return -1;
        }
        public static bool IsValidPhoneNumber(string phonenumber)
        {
            string regexstr = @"^[0]{1}[9]{1}[0-9]{9}$";

            Regex re = new Regex(regexstr);

            return re.IsMatch(phonenumber);
        }
        public static bool IsValidUserName(string name)
        {
            string regexstr = @"^[a-zA-z]{3,32}$";

            Regex re = new Regex(regexstr);

            return re.IsMatch(name);
        }
        public static bool IsValidEmail(string email)
        {
            string regexstr = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(regexstr);

            return re.IsMatch(email);
        }
        public static bool IsValidPassword(string pass)
        {
            string s = @"(^(?=.*[a-z])(?=.*[A-Z]).{8,40}$)";

            Regex re = new Regex(s);

            return re.IsMatch(pass);
        }
        public static bool IsValidCVV(string name)
        {
            string regexstr = @"^[0-9]{3,4}$";

            Regex re = new Regex(regexstr);

            return re.IsMatch(name);
        }

        public static bool IsValidEmail2(string email)
        {
            foreach (var item in customers)
            {
                if (item.email == email)
                    return false;

            }
            return true;
        }
        public static bool IsValidCardNumber(string num)
        {
            List<int> list = new List<int>();

            if (num.Length != 16)
                return false;

            for (int i = 0; i < num.Length; i++)
            {
                int.Parse(num[i].ToString());
            }

            for (int i = 0; i < num.Length; i += 2)
            {
                list.Add(2 * int.Parse(num[i].ToString()));
            }

            List<int> newlist = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                int a = 0;

                while (list[i] != 0)
                {
                    a += list[i] % 10;
                    list[i] /= 10;
                }

                newlist.Add(a);
            }

            int sum = 0;

            for (int i = 1; i < num.Length; i += 2)
            {
                sum += int.Parse(num[i].ToString());
            }

            foreach (var item in newlist)
            {
                sum += item;
            }

            return sum % 10 == 0;
        }

        public static void UpdateCustomerTable(string oldEmail, Customer_Class cc)
        {
            string command = "update T_Customers set Email = '" + cc.email + "' , Username = '" + cc.userName + "' , PhoneNumber = '" + cc.phoneNumber + "' , Password = '" + cc.password + "' , Wallet = '" + cc.wallet + "' , Cart = '" + cc.cart + "' , Marked_Book = '" + cc.markedBooks + "' , Buyed_Book = '" + cc.buyedBooks + "' where Email = '" + oldEmail + "'";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            con.Close();

        }

        public int CalculateLeftTime()
        {
            throw new NotImplementedException();
        }
    }
}