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

    public UserRecord GetRecord();
}