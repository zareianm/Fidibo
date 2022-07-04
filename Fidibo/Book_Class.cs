using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fidibo
{
   public  class Book_Class
    {
        string name, writer;
       public double price;
       public int salesCount;
       public double rate, discount;
        bool isVIP;

        public static List<Book_Class> books = new List<Book_Class>();

        public Book_Class(string name, string writer, double price)
        {
            this.name = name;
            this.writer = writer;
            this.price = price;

            salesCount = 0;
            rate = 0;
            discount = 0;
            isVIP = false;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            string command = "insert into T_Books values ('" + name + "','" + writer + "','" + price + "','" + salesCount + "','" + rate + "','" + discount + "','" + isVIP + "')";
            SqlCommand com = new SqlCommand(command, con);
            com.ExecuteNonQuery();
            con.Close();

            books.Add(this);
        }

        public static int IndexOfBook(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].name == name)
                    return i;
            }

            return -1;
        }
    }
}