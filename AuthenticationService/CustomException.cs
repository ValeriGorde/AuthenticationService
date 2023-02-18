namespace AuthenticationService
{
    public class CustomException: Exception
    {
        public CustomException(string message) 
        {
            var exception = new Exception(message);
        }
    }
}
