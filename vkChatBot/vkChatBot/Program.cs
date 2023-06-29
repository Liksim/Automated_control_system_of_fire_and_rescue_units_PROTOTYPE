using System.Text.RegularExpressions;
using VkBotFramework;
using VkBotFramework.Models;
using vkChatBot.DBconnection;
using vkChatBot.DBconnection.Entities;
using VkNet.Model;

namespace vkChatBot
{
    class Program
    {
        private static string AccessToken = "vk1.a.ZkjDmAxVfiNzN_XR_DZGuqiULsLGFHpH6yLlVorHcky4fD1EbAW20LLuHt2gpaZRMJuIHIu5zpkiLK8HbwaQYQ_Dqw76mv0m0beRgFDhsD2V-YPZI-ShNKMPoVNLgGumLW_qjo-UV441othCZzbyJJErsyGz7_JH-FE9i_E33QUzIadSPlSo6_Tv0VqM2vG48qotMNaZ-OeOy8cH7RZBJQ";
        private static string GroupUrl = "https://vk.com/club221296482";
        private static VkBot _bot;
        static Repository<BotUser> botUserRepository = new Repository<BotUser>(ContextManager.GetContext());
        static Repository<PostIsCallSign> postIsCallSignRepository = new Repository<PostIsCallSign>(ContextManager.GetContext());
        static Repository<BotSourceGroup> botSourceGroupRepository = new Repository<BotSourceGroup>(ContextManager.GetContext());
        static Repository<Subscription> subscriptionRepository = new Repository<Subscription>(ContextManager.GetContext());

        static void Main(string[] args)
        {
            _bot = new VkBot(AccessToken, GroupUrl);
            _bot.OnMessageReceived += BotOnMessageReceived;
            _bot.TemplateManager.Register("help", 
                "Команды:\r\n" +
                "1. peer id - возвращает peerId этого чата.\r\n" +
                "2. add user: {имя}; {роль} - регистрация, существующие роли: Слушатель, Источник.\r\n" +
                "3. delete user - удаляет пользователя.\r\n" +
                "4. select users - выводит всех зарегестрированных пользователей.\r\n" +
                "5. add role - создаёт новую роль.\r\n" +
                "6. delete role - удалить роль.\r\n" +
                "7. select roles - выводит все существующие роли.\r\n" +
                "Реализованы пункты: 1-2.");
            _bot.Start();
            Console.ReadLine();
        }

        private static void BotOnMessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            var inMessage = e.Message.Text;

            if(inMessage == "peer id")
            { 
                var peerId = e.Message.PeerId;

                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = peerId.ToString(),
                    PeerId = peerId,
                    RandomId = Environment.TickCount
                });
            }
            else if(inMessage.Contains("add"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("add"), 3);
                inMessage = inMessage.Trim();

                if(inMessage.Contains("user"))
                {
                    inMessage = inMessage.Remove(inMessage.IndexOf("user"), 4);
                    inMessage = inMessage.Trim();

                    var command = inMessage.Split(';');

                    botUserRepository.Create(new BotUser(
                        name: command[0].Trim(),
                        peerId: (long)e.Message.PeerId,
                        idPostIsCallSign: postIsCallSignRepository.Read().Where(x => x.CallSign == command[1].Trim()).First().Id
                        ));
                }
            }
            else if(new Regex(@"add user: (\w| )+?;(\w| )+?$").IsMatch(e.Message.Text))
            {
                string[] command = e.Message.Text.Substring(e.Message.Text.IndexOf(":") + 1).Trim().Split(';');
                foreach(string str in command)
                {
                    str.Trim();
                }

                int id_role = 0;

                string message = "";

               

                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = message,
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
            else if (e.Message.Text == "delete user")
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Не реализовано",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
            else if (e.Message.Text == "select users")
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Не реализовано",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
            else if (e.Message.Text == "add role")
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Не реализовано",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
            else if (e.Message.Text == "delete role")
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Не реализовано",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
            else if (e.Message.Text == "select roles")
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Не реализовано",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
            else
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Такой команды не существует.\r\nНапишите help, чтобы узнать, что может бот.",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
        }
    }
}

