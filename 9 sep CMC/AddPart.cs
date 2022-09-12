using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_sep_CMC
{
    public class AddPart
    {
        //Class for adding parts in the server//
        public static void add ()
            {
            Console.WriteLine("Welcome to Bhavna CMC car part section");

            parts me = new parts();//class call object creation
                                   //taking inputs
            Console.WriteLine("Enter Part name : ");
            me.name = Console.ReadLine();
            Console.WriteLine("Enter Price : ");
            me.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            me.quantity = int.Parse(Console.ReadLine());

            SqlConnection con = new SqlConnection("server=localhost;database=CMC;integrated security=true");//SQL Connection
            SqlCommand cmd = new SqlCommand("insert into parts values('" + me.name + "'," + me.price + "," + me.quantity + ")", con);//sql insertion command
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("one part added sucessfully");
        }
        
    }
}
