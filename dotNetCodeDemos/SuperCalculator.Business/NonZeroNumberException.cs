
namespace SuperCalculator.Business
{
    [Serializable]
    public class NonZeroNumberException : ApplicationException
    {
        //public NonZeroNumberException()
        //{
        //}

        //public NonZeroNumberException(string? message) : base(message)
        //{
        //}

        public NonZeroNumberException(string? message=null, Exception? innerException = null) : base(message, innerException)
        {
        }
    }
}