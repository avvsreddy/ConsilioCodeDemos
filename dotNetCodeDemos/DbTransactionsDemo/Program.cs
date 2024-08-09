using System.Data.SqlClient;

namespace DbTransactionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static bool FundTransfer(int fromAccNo, int toAccNo, int amount)
        {
            // open db connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContactsDB;Integrated Security=True";

            // prepare withdraw sql update and exe
            string withdraw = $"update accounts set balance = balance - {amount} where accno={fromAccNo}";

            SqlCommand cmd1 = new SqlCommand(withdraw, conn);

            // prepare deposit sql update and exe
            string deposit = $"update accounts set balance = balance + {amount} where accno={toAccNo}";

            SqlCommand cmd2 = new SqlCommand(deposit, conn);

            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            finally 
            { 
                conn.Close();
            }

        }
    }
}
