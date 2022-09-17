namespace SaveTextBot.SaveDataService;

/// <summary>
/// Describes the behaviour of any class representing a way of storing data.
/// </summary>
public interface IDataSaver
{
    /// <summary>
    /// All preparation actions for saving data (if needed) are done here.
    /// </summary>
    public void Initialize();

    /// <summary>
    /// Saves the given data to storage.
    /// </summary>
    public void SaveData();

    /// <summary>
    /// Get the record associated with alias string out of records of the given chat.
    /// </summary>
    public UserRecord GetUserRecord(long chatId, string alias);

    /// <summary>
    /// Get all the records of the chat.
    /// </summary>
    public UserRecord[] GetUserRecords(long chatId);

    /// <summary>
    /// Add a new record to records of the chat.
    /// </summary>
    public void AddUserRecord(long chatId, UserRecord record);

    /// <summary>
    /// Remove the record with the given alias from the records of the given chat.
    /// </summary>
    public void RemoveUserRecord(long chatId, string alias);
}