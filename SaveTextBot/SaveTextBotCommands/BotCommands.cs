namespace SaveTextBot.SaveTextBotCommands;

using System.Collections.Generic;

/// <summary>
/// Contains all commands for the bot.
/// </summary>
public static class BotCommandsList
{
    public static Dictionary<string, ISaveTextBotCommand> Commands = new ()
    {
        { "/help",  new HelpCommand() },
        { "/info", new InfoCommand() }
    };
}