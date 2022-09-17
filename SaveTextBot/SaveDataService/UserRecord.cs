namespace SaveTextBot.SaveDataService;

/// <summary>
/// Represents any data saved by the user.
/// </summary>
public class UserRecord
{
    /// <summary>
    /// The short number of symbols the whole record is associated with.
    /// </summary>
    public string Alias { get;}
    
    /// <summary>
    /// The text the user wants to save.
    /// </summary>
    public string TextTextValue { get; }
    
    
    public UserRecord(string alias, string textValue)
    {
        Alias = alias ?? throw new ArgumentException("\'alias\' was null.");
        TextTextValue = textValue ?? throw new ArgumentException("\'value\' was null.");
    }
}