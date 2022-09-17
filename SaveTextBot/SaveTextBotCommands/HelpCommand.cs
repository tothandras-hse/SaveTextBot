using Telegram.Bot.Types;

namespace SaveTextBot.SaveTextBotCommands;

public class HelpCommand : ISaveTextBotCommand
{
    public string ManageCommand(string data) => "My commands:\n" + string.Join('\n', BotCommandsList.Commands.Keys);
}