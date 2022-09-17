using System;

using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

using SaveTextBot.SaveDataService;

namespace SaveTextBot
{
    static class Program
    {
        private static ITelegramBotClient botClient;
        
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient($"{Token.TokenString}");

            try
            {
                var me =  botClient.GetMeAsync().Result;
                Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
                
                
                
                Thread.Sleep(int.MaxValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}