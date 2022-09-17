using SaveTextBot;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;


var botClient = new TelegramBotClient($"{Token.TokenString}");
var botBehaviour = new SaveTextBot.SaveTextBot();

using var cts = new CancellationTokenSource();

botClient.StartReceiving(
    updateHandler: botBehaviour.OnMessage,
    pollingErrorHandler: botBehaviour.OnException,
    receiverOptions: botBehaviour.ReceiverOptions,
    cancellationToken: cts.Token
);

var me = await botClient.GetMeAsync();

Console.WriteLine($"Start listening for @{me.Username}");
Console.ReadLine();

// Send cancellation request to stop bot
cts.Cancel();
