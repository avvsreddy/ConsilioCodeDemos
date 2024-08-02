namespace ExceptionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accept two ints, find sum, then display, and repeat
            // only non zero positive even numbers only



            /*
             * 
             * Multi line comments
             * 
             */

            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    int fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int sno = int.Parse(Console.ReadLine());
                    //int sum = fno + sno;
                    SimpleCalculator calc = new SimpleCalculator();
                    int sum = calc.Sum(fno, sno);
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter only numbers");
                }

                catch(SimpleCalculatorException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please enter small numbers");
                }
                catch (Exception ex) // catch all
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
                finally 
                {
                    // resource cleaning
                    Console.WriteLine("In finally block");
                }
            }
        }
    }

    // backend business code

    /// <summary>
    /// Calculates simple mathematical calculations for valid input
    /// </summary>
    class SimpleCalculator
    {
        /// <summary>
        /// Finds a sum of two positive evens numbers
        /// </summary>
        /// <param name="a">positive even int number</param>
        /// <param name="b">positive even int number</param>
        /// <returns>sum of two ints</returns>
        /// <exception cref="SimpleCalculatorException"></exception>
        public int Sum(int a, int b)
        {
            // only non zero positive even numbers only
            // validate non zero or negative case
            if(a <= 0 || b <= 0)
            {
                throw new SimpleCalculatorException("Negavie or Zero input is invalid");
            }
            // validate even numbers
            if (a % 2 != 0 || b % 2 != 0)
            {
                throw new SimpleCalculatorException("Provide Positive Even Numbers");
            }

            // save
            CalculatorRepository repo = new CalculatorRepository();
            repo.Save($"{a} + {b} = {a + b}");
            return a + b;
        }
    }

    // custom exceptions
    class NegativeOrZeroInputException : ApplicationException
    {

    }

    class SimpleCalculatorException : ApplicationException
    {
        public SimpleCalculatorException()
        {
            
        }

        public SimpleCalculatorException(string msg):base(msg) 
        {
            //this.Message = msg;
            //base.
        }
    }

    // DAL

    class CalculatorRepository
    {
        public void Save(string msg)
        {
            try
            {
                File.WriteAllText("D:\\calculator\\result.txt", msg);
            }
            catch (Exception ex) 
            {
                // log - storing the exp details
                // nLog, serilog, 
                // convert it
                CalculatorRepositoryException calculatorRepositoryException = new CalculatorRepositoryException("Unable to save result",ex);
                throw calculatorRepositoryException;
            }
        }
    }

    // 
    class CalculatorRepositoryException : ApplicationException
    {
        public CalculatorRepositoryException()
        {

        }
        public CalculatorRepositoryException(string msg):base(msg) 
        {

        }

        public CalculatorRepositoryException(string msg, Exception innerExp):base(msg, innerExp) 
        {

        }
    }
}
