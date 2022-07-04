using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Fidibo
{
   public class Admin_Class
    {
        public string email, password;
        public int  vip_price;
        public double safe_cash;
      
        public static List<Admin_Class> admins = new List<Admin_Class>();

        public Admin_Class(string email, string password )
        {
            if (!IsValidEmail(email) && !IsValidPassword(password))
                throw new Exception("wrong input !! , please try again");

            this.email = email;
            this.password = password;
            safe_cash = 0;
            vip_price = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            string command = "insert into T_Admin values ('" + email + "','" + password + "','" + safe_cash + "','" + vip_price + "')";
            SqlCommand com = new SqlCommand(command, con);
            com.ExecuteNonQuery();
            con.Close();

            //Admins.Add(this);


        }

        public Admin_Class(string email, string password  , int vip_price )
        {
            this.email = email;
            this.password = password;
           for(int i=0; i < Book_Class.books.Count; i++)
            {
                safe_cash += Book_Class.books[i].salesCount * Book_Class.books[i].price;
            }
            this.vip_price = vip_price;
         

        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(pattern);

            return re.IsMatch(email);
        }
        public static bool IsValidPassword(string pass)
        {
            string pattern = @"(^(?=.*[a-z])(?=.*[A-Z]).{8,40}$)";

            Regex re = new Regex(pattern);

            return re.IsMatch(pass);
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

        public static bool IsValidCVV(string name)
        {
            string regexstr = @"^[0-9]{3,4}$";

            Regex re = new Regex(regexstr);

            return re.IsMatch(name);
        }

    }
}
