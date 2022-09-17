namespace SaveTextBot.SaveTextBotCommands;

/// <summary>
/// Represent an action of the bot to the concrete command.
/// </summary>
public interface ISaveTextBotCommand
{
    /// <summary>
    /// Does the action of the command with the data given by user (if needed) and returns the text message with a
    /// feedback.
    /// </summary>
    public string ManageCommand(string dataFromUser);
}