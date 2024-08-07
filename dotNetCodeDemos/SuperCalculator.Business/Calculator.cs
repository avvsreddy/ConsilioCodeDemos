namespace SuperCalculator.Business
{
    public class Calculator
    {
        // find sum of two positive non zero even numbers, on invalid input throw exp

        public int Sum(int fno, int sno)
        {

            if (fno <= 0 && sno <= 0) // non zero positive
            {
                throw new NonZeroNumberException("Provide non zero numbers only");
            }

            if (fno % 2 != 0 && sno % 2 != 0) 
            {
                throw new NonEvenNumberException("Provide even numbers only");
            }

            return fno + sno;
        }

        //public int Difference(int fno, int sno)
        //{
        //    return fno + sno;
        //}
    }
}
