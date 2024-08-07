
namespace SuperCalculator.Business
{
    [Serializable]
    public class NonEvenNumberException : ApplicationException
    {
        //public NonEvenNumberException()
        //{
        //}

        //public NonEvenNumberException(string? message) : base(message)
        //{
        //}

        public NonEvenNumberException(string? message = null, Exception? innerException = null) : base(message, innerException)
        {
        }
    }
}