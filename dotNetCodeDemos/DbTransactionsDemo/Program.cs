using System.Data.SqlClient;

namespace DbTransactionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transfering fund...");
            bool isDone = FundTransfer(111, 222, 1000);
            if (isDone)
            {
                //Console.WriteLine("Transactions is successfull");
            }
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
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            cmd1.Transaction = trans;
            cmd2.Transaction = trans;
            try
            {
                
                cmd1.ExecuteNonQuery();// withdraw
                Console.WriteLine($"From {fromAccNo} amount {amount} is debited ");
                throw new Exception("Server Error");
                cmd2.ExecuteNonQuery();// deposit
                Console.WriteLine($"To {toAccNo} amount {amount} is credited ");
                trans.Commit();
                Console.WriteLine("Transaction is successfull");
                return true;
            }
            catch(Exception ex)
            {
                trans.Rollback();
                Console.WriteLine("Transaction is rolled back");
                return false;
            }
            finally 
            { 
                conn.Close();
            }
            
        }
    }
}
