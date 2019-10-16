using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace PossoAjudarBot.Trigger
{
    class Program
    {
        private static readonly TelegramBotClient _bot =
            new TelegramBotClient("876805264:AAHqx1oYl73c6Io0cb_XSUbraRj5ET0gc38");

        static void Main()
        {
            _bot.OnMessage += Messages;
            _bot.OnMessageEdited += Messages;

            _bot.StartReceiving();
            Console.ReadLine();
            _bot.StartReceiving();

        }

        private static void Messages(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == MessageType.Text)
            {
                switch (e.Message.Text)
                {
                    case "/Oi":
                        _bot.SendTextMessageAsync(e.Message.Chat.Id, $"Oi, {e.Message.Chat.Username}");
                        break;
                    case "Tudo bem?":
                        _bot.SendTextMessageAsync(e.Message.Chat.Id, "Tudo ótimo!");
                        break;
                    case "Me ajuda":
                        _bot.SendTextMessageAsync(e.Message.Chat.Id, "Com eu posso ajudar você?");
                        break;
                    case "Quem é você?":
                        _bot.SendTextMessageAsync(e.Message.Chat.Id, "Sou um robô que conversa no chat");
                        break;
                    default:
                        _bot.SendTextMessageAsync(e.Message.Chat.Id, @"Use:
                            Oi
                            Tudo bem?
                            Me ajuda
                            Quem é você?
                        ");
                        break;
                }
            }
        }
    }
}