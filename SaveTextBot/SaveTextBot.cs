namespace SaveTextBot;

using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

using SaveTextBotCommands;

/// <summary>
/// Represent the behaviour of the bot.
/// </summary>
public class SaveTextBot
{
    public ReceiverOptions ReceiverOptions { get; }

    public SaveTextBot()
    {
        ReceiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };
    }


    /// <summary>
    /// Forces the bot to reply by a message.
    /// </summary>
    private async Task SendMessage(ITelegramBotClient botClient,
                                    CancellationToken cancellationToken,
                                    long chatId,
                                    string message)
    {
        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: message,
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Represent the behaviour of the bot when receiving a message.
    /// </summary>
    public async Task OnMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Message is not {Text: { } messageText} message)
            return;
        
        // Checking if the message from the user is a command
        if (BotCommandsList.Commands.ContainsKey(message.Text.Split()[0]))
        {
            await SendMessage(botClient,
                cancellationToken,
                message.Chat.Id,
                BotCommandsList.Commands[message.Text.Split()[0]].ManageCommand(message.Text));   
        }
    }

    /// <summary>
    /// Represent the behaviour of the bot when handing an exception.
    /// </summary>
    public Task OnException(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        var errorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(errorMessage);
        return Task.CompletedTask;
    }
}