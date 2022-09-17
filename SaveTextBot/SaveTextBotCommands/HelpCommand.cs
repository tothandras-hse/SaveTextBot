using Telegram.Bot.Types;

namespace SaveTextBot.SaveTextBotCommands;

/// <summary>
/// A command which forces the bot to print all it's commands.
/// </summary>
public class HelpCommand : ISaveTextBotCommand
{
    public string ManageCommand(string _) => "My commands:\n" + string.Join('\n', BotCommandsList.Commands.Keys);
}