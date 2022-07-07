using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fidibo
{
    public class Book_Class
    {
        public string name { get; set; }
        public string writer { get; set; }
        public double price { get; set; }
        public int salesCount { get; set; }
        public double rate { get; set; }
        public double discount { get; set; }
        public bool isVIP { get; set; }
        public string summary { get; set; }
        public int year { get; set; }
        public static List<Book_Class> books = new List<Book_Class>();

        public Book_Class(string name, string writer, double price, string summary  , int year)
        {
            this.name = name;
            this.writer = writer;
            this.price = price;
            this.summary = summary;
            salesCount = 0;
            rate = 0;
            discount = 0;
            isVIP = false;
            this.year = year;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            string command = "insert into T_Books values ('" + name + "','" + writer + "','" + price + "','" + salesCount + "','" + rate + "','" + discount + "','" + isVIP + "','" + summary + "','" + year + "' )";
            SqlCommand com = new SqlCommand(command, con);
            com.ExecuteNonQuery();
            con.Close();

            books.Add(this);
        }

        public Book_Class(string Name, string Writer, double Price, int Salescount, double Rate, double Discount, bool IsVIP, string Summary , int Year)
        {
            name = Name;
            writer = Writer;
            price = Price;
            salesCount = Salescount;
            rate = Rate;
            discount = Discount;
            isVIP = IsVIP;
            summary = Summary;
            year = Year;
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

        public static void UpdateBookTable(string oldName, Book_Class bc)
        {
            string command = "update T_Books set Name = '" + bc.name + "' , Writer = '" + bc.writer + "' , Price = '" + bc.price + "' , SalesCount = '" + bc.salesCount + "' , Rate = '" + bc.rate + "' , Discount = '" + bc.discount + "' , IsVIP = '" + bc.isVIP + "' , Summary = '" + bc.summary + "' , Year = '" + bc.year + "' where Name = '" + oldName + "'";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\aphw\Fidibo\Fidibo\Resources\data.mdf;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            con.Close();

        }
    }
}