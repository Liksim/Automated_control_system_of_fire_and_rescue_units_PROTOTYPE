using System.Text.RegularExpressions;
using VkBotFramework;
using VkBotFramework.Models;
using VkNet.Model;

namespace vkChatBot
{
    class Program
    {
        private static string AccessToken = "vk1.a.ZkjDmAxVfiNzN_XR_DZGuqiULsLGFHpH6yLlVorHcky4fD1EbAW20LLuHt2gpaZRMJuIHIu5zpkiLK8HbwaQYQ_Dqw76mv0m0beRgFDhsD2V-YPZI-ShNKMPoVNLgGumLW_qjo-UV441othCZzbyJJErsyGz7_JH-FE9i_E33QUzIadSPlSo6_Tv0VqM2vG48qotMNaZ-OeOy8cH7RZBJQ";
        private static string GroupUrl = "https://vk.com/club221296482";
        private static VkBot _bot;

        static void Main(string[] args)
        {
            _bot = new VkBot(AccessToken, GroupUrl);
            _bot.OnMessageReceived += BotOnMessageReceived;
            _bot.TemplateManager.Register("help", 
                "Команды:\r\n" +
                "1. peer id - возвращает peerId этого чата.\r\n" +
                "2. add user {имя} {роль} - регистрация, существующие роли: Слушатель, Источник.\r\n" +
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
            if(e.Message.Text == "peer id")
            { 
                var peerId = e.Message.PeerId;

                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = peerId.ToString(),
                    PeerId = peerId,
                    RandomId = Environment.TickCount
                });
            }
            else if(new Regex(@"add user \w+? \w+?$").IsMatch(e.Message.Text))
            {
                string[] command = e.Message.Text.Split(' ');
                BDconnection con = new BDconnection();

                int id_role = 0;
                foreach(BotRole botRole in con.SelectBotRoles())
                {
                    if(botRole.Name == command[3])
                    {
                        id_role = botRole.Id;
                        break;
                    }
                }

                string message = "";

                if (id_role != 0)
                {
                    BotUser entity = new BotUser(
                    id: 0,
                    name: command[2],
                    peerId: (long)e.Message.PeerId,
                    idRole: id_role);

                    con.AddBotUser(entity);

                    message = $"Пользователь {command[2]} в роли {command[3]} успешно добавлен!";
                }
                else
                {
                    message = $"Роли {command[3]} не существует!";
                }

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

