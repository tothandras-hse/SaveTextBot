namespace SaveTextBot.SaveTextBotCommands;

/// <summary>
/// A command which forces bot to print information about itself.
/// </summary>
public class InfoCommand : ISaveTextBotCommand
{
    public string ManageCommand(string _)
    {
        return "Hello! My name is SaveTextBox. I can make records - pieces of text connected to short alias-strings."
               + "Later, you can easily access saved texts by their alias.\n"
               + "To get familiar with all commands, type /help. \n"
               + "To add a record, type /addrecord x y, where x is alias and y is text you would like to save. \n"
               + "To get a record, type /record x, where x is alias of the record you would like to access. \n"
               + "To get all records you have, type /records. \n"
               + "To remove a record, type /delrecord x, where x is alias of the record you would like to remove. \n";
    }
}