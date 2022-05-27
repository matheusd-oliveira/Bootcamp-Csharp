
using System.Runtime.Serialization;

public class MyClassException : Exception
{
    public MyClassException()
    {
    }

    public MyClassException(string? message) : base(message)
    {
    }

    public MyClassException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public int MyProperty { get; set; }

}