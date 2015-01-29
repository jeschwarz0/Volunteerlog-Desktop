/// <summary>
/// The library cannot communicate with the database, no transactions may be completed
/// </summary>
[System.Serializable]
public class DatabaseNotOpenException : System.Exception
{
  public DatabaseNotOpenException() { }
  public DatabaseNotOpenException( string message ) : base( message ) { }
  public DatabaseNotOpenException( string message, System.Exception inner ) : base( message, inner ) { }
  protected DatabaseNotOpenException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}
/// <summary>
/// The given text is too large for the database to handle(mediumtext)
/// </summary>
[System.Serializable]
public class TextTooLargeException : System.Exception
{
    public TextTooLargeException() { }
    public TextTooLargeException(string message) : base(message) { }
    public TextTooLargeException(string message, System.Exception inner) : base(message, inner) { }
    protected TextTooLargeException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
}
/// <summary>
/// You tried to log out but you don't have a checkin
/// </summary>
[System.Serializable]
public class NoCheckinException : System.Exception
{
    public NoCheckinException() { }
    public NoCheckinException(string message) : base(message) { }
    public NoCheckinException(string message, System.Exception inner) : base(message, inner) { }
    protected NoCheckinException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
}
