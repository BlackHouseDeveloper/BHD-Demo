namespace BHD_Demo.Exceptions.Store;


public class ServiceAuthenticationException : Exception
{
    public ServiceAuthenticationException(string content) 
    {
        Content = content;
    }

    public string Content { get; }
}