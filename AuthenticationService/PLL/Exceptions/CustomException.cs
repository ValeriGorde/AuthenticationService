namespace AuthenticationService.PLL.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message)
        {
            var exception = new Exception(message);
        }
    }
}
