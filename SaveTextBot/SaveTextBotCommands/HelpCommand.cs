namespace SaveTextBot.SaveTextBotCommands;

public class HelpCommand : ISaveTextBotCommand
{
    public string ManageCommand(string data) => "My commands:\n" +
                                                   " /help";
}