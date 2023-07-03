using Google.Protobuf;
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
        static List<string> keyWords = new List<string>()
        {
            "add", "select", "update", "delete", "peer id", "subscribe", "help",
            "user", "call sign", "subscription", "source group",
            "users", "call signes", "subscriptions", "source groups"
        };

        static void Main(string[] args)
        {
            _bot = new VkBot(AccessToken, GroupUrl);
            _bot.OnMessageReceived += BotOnMessageReceived;
            _bot.TemplateManager.Register("help", 
                "Команды:\r\n" +
                "1. peer id - возвращает peerId этого чата.\r\n" +
                "2. add user {имя}; {позывной}; {название группы}\r\n" +
                "3. add call sign {позывной}; {должность}\r\n" +
                "4. add source group {название группы}\r\n" +
                "5. add subscription {название группы}\r\n" +
                "6. select users\r\n" +
                "7. select call signes\r\n" +
                "8. select source groups\r\n" +
                "9. select subscriptions\r\n" +
                "10. update user {ID}; {имя}; {позывной}; {название группы}\r\n" +
                "11. update call sign {ID}; {позывной}; {должность}\r\n" +
                "12. update source group {ID}; {название группы}\r\n" +
                "13. delete user {ID}\r\n" +
                "14. delete call sign {ID}\r\n" +
                "15. delete source group {ID}\r\n" +
                "16. delete subscription\r\n");
            _bot.Start();
            Console.ReadLine();
        }

        private static void BotOnMessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            var inMessage = e.Message.Text;

            int countKeyWords = 0;

            foreach (string keyWord in keyWords)
            {
                if (inMessage.Contains(keyWord))
                {
                    countKeyWords++;
                }
            }

            if (countKeyWords < 2 && !(countKeyWords == 1 && (inMessage.Contains("peer id") || inMessage.Contains("subscribe") || inMessage.Contains("help"))))
            {
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = "Нет такой команды!",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });

                return;
            }

            if (inMessage == "peer id")
            {
                var peerId = e.Message.PeerId;

                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = peerId.ToString(),
                    PeerId = peerId,
                    RandomId = Environment.TickCount
                });
            }
            else if (inMessage.Contains("add"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("add"), 3);
                inMessage = inMessage.Trim();

                Add(inMessage, e);
            }
            else if (inMessage.Contains("select"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("select"), 6);
                inMessage = inMessage.Trim();

                Select(inMessage, e);
            }
            else if (inMessage.Contains("update"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("update"), 6);
                inMessage = inMessage.Trim();

                Update(inMessage, e);
            }
            else if (inMessage.Contains("delete"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("delete"), 6);
                inMessage = inMessage.Trim();

                Delete(inMessage, e);
            }
        }

        private static void Add(string inMessage, MessageReceivedEventArgs e)
        {
            if (inMessage.Contains("user"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("user"), 4);
                inMessage = inMessage.Trim();    
                AddUser(inMessage, e);
            }
            else if(inMessage.Contains("call sign"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("call sign"), 9);
                inMessage = inMessage.Trim();           
                AddCallSign(inMessage, e);
            }
            else if (inMessage.Contains("source group"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("source group"), 12);
                inMessage = inMessage.Trim();                
                AddSourceGroup(inMessage, e);
            }
            else if (inMessage.Contains("subscription"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("subscription"), 12);
                inMessage = inMessage.Trim();
                AddSubscription(inMessage, e);
            }
        }

        private static void Select(string inMessage, MessageReceivedEventArgs e)
        {
            string view = "";

            if (inMessage.Contains("users"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("users"), 5);
                inMessage = inMessage.Trim();
                SelectUsers(inMessage, e, out view);               
            }
            else if (inMessage.Contains("call signes"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("call signes"), 11);
                inMessage = inMessage.Trim();
                SelectCallSignes(inMessage, e, out view);
            }
            else if (inMessage.Contains("source groups"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("source groups"), 13);
                inMessage = inMessage.Trim();
                SelectSourceGroups(inMessage, e, out view);                
            }
            else if (inMessage.Contains("subscriptions"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("subscriptions"), 13);
                inMessage = inMessage.Trim();
                SelectSubscriptions(inMessage, e, out view);                
            }

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = view,
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void Update(string inMessage, MessageReceivedEventArgs e)
        {
            if (inMessage.Contains("user"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("user"), 4);
                inMessage = inMessage.Trim();
                UpdateUser(inMessage, e);                
            }
            else if (inMessage.Contains("call sign"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("call sign"), 9);
                inMessage = inMessage.Trim();
                UpdateCallSign(inMessage, e);                
            }
            else if (inMessage.Contains("source group"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("source group"), 12);
                inMessage = inMessage.Trim();
                UpdateSourceGroup(inMessage, e);                
            }
            else if (inMessage.Contains("subscription"))
            {                
                _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
                {
                    Message = $"Нет такой команды!",
                    PeerId = e.Message.PeerId,
                    RandomId = Environment.TickCount
                });
            }
        }

        private static void Delete(string inMessage, MessageReceivedEventArgs e)
        {
            string view = "";

            if (inMessage.Contains("user"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("user"), 4);
                inMessage = inMessage.Trim();
                botUserRepository.Delete(int.Parse(inMessage));
            }
            else if (inMessage.Contains("call sign"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("call sign"), 9);
                inMessage = inMessage.Trim();
                postIsCallSignRepository.Delete(int.Parse(inMessage));
            }
            else if (inMessage.Contains("source group"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("source group"), 12);
                inMessage = inMessage.Trim();
                botSourceGroupRepository.Delete(int.Parse(inMessage));
            }
            else if (inMessage.Contains("subscription"))
            {
                inMessage = inMessage.Remove(inMessage.IndexOf("subscription"), 12);
                inMessage = inMessage.Trim();
                subscriptionRepository.Delete(int.Parse(inMessage));
            }

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = "Запись успешно удалена!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void AddUser(string inMessage, MessageReceivedEventArgs e)
        {
            var command = inMessage.Split(';');

            botUserRepository.Create(new BotUser(
                name: command[0].Trim(),
                peerId: (long)e.Message.PeerId,
                idPostIsCallSign: postIsCallSignRepository.Read().Where(x => x.CallSign == command[1].Trim()).First().Id,
                idBotSourceGroup: botSourceGroupRepository.Read().Where(x => x.Name == command[2].Trim()).First().Id
                ));

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Пользователь {command[0].Trim()} успешно зарегестрирован!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void AddCallSign(string inMessage, MessageReceivedEventArgs e)
        {
            var command = inMessage.Split(';');

            postIsCallSignRepository.Create(new PostIsCallSign(
                post: command[1].Trim(),
                callSign: command[0].Trim()
                ));

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Позывной {command[0].Trim()} для должности {command[1].Trim()} успешно добавлен!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void AddSourceGroup(string inMessage, MessageReceivedEventArgs e)
        {
            botSourceGroupRepository.Create(new BotSourceGroup(
                    name: inMessage
                    ));

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Группа источников {inMessage} успешно добавлена!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void AddSubscription(string inMessage, MessageReceivedEventArgs e)
        {
            subscriptionRepository.Create(new Subscription(
                    idBotSourceGroup: botSourceGroupRepository.Read().Where(x => x.Name == inMessage).First().Id,
                    idBotUser: botUserRepository.Read().Where(x => x.PeerId == e.Message.PeerId).First().Id
                    ));

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Вы успешно подписались на {inMessage}",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void SelectUsers(string inMessage, MessageReceivedEventArgs e, out string view)
        {
            var botUsers = botUserRepository.Read().OrderBy(x => x.Id).ToList();
            view = "";
            foreach (var user in botUsers)
            {
                view +=
                    user.Id.ToString() + ". " + user.ToString() + ", " +
                    postIsCallSignRepository.Read().Where(x => x.Id == user.IdPostIsCallSign).First().ToString() + ", " +
                    botSourceGroupRepository.Read().Where(x => x.Id == user.IdBotSourceGroup).First().ToString() + "\r\n";
            }
        }

        private static void SelectCallSignes(string inMessage, MessageReceivedEventArgs e, out string view)
        {
            var postIsCallSignes = postIsCallSignRepository.Read().OrderBy(x => x.Id).ToList();
            view = "";
            foreach (var postIsCallSign in postIsCallSignes)
            {
                view +=
                    postIsCallSign.Id.ToString() + ". " + postIsCallSign.ToString() + "\r\n";
            }
        }

        private static void SelectSourceGroups(string inMessage, MessageReceivedEventArgs e, out string view)
        {
            var botSourceGroups = botSourceGroupRepository.Read().OrderBy(x => x.Id).ToList();
            view = "";
            foreach (var botSourceGroup in botSourceGroups)
            {
                view +=
                    botSourceGroup.Id.ToString() + ". " + botSourceGroup.ToString() + "\r\n";
            }
        }

        private static void SelectSubscriptions(string inMessage, MessageReceivedEventArgs e, out string view)
        {
            var subscriptions = subscriptionRepository
                .Read().Where(x => x.IdBotUser == botUserRepository.Read().Where(x => x.PeerId == e.Message.PeerId).First().Id).OrderBy(x => x.Id).ToList();
            view = "";
            foreach (var subscription in subscriptions)
            {
                view +=
                    subscription.Id.ToString() + ". " +
                    botSourceGroupRepository.Read(subscription.IdBotSourceGroup).Name + "\r\n";
            }
        }

        private static void UpdateUser(string inMessage, MessageReceivedEventArgs e)
        {
            var command = inMessage.Split(';');

            long p = botUserRepository.Read().Where(x => x.Id == int.Parse(command[0])).First().PeerId;
            int c = postIsCallSignRepository.Read().Where(x => x.CallSign == command[2].Trim()).First().Id;
            var ss = botSourceGroupRepository.Read();
            int s = botSourceGroupRepository.Read().Where(x => x.Name == command[3].Trim()).First().Id;


            var entity = new BotUser(
                name: command[1].Trim(),
                peerId: botUserRepository.Read().Where(x => x.Id == int.Parse(command[0])).First().PeerId,
                idPostIsCallSign: postIsCallSignRepository.Read().Where(x => x.CallSign == command[2].Trim()).First().Id,
                idBotSourceGroup: botSourceGroupRepository.Read().Where(x => x.Name == command[3].Trim()).First().Id
                );

            entity.Id = int.Parse(command[0]);

            botUserRepository.Update(entity);

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Пользователь с ID {command[0].Trim()} успешно изменён!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void UpdateCallSign(string inMessage, MessageReceivedEventArgs e)
        {
            var command = inMessage.Split(';');

            var entity = new PostIsCallSign(
                post: command[2].Trim(),
                callSign: command[1].Trim()
                );

            entity.Id = int.Parse(command[0]);

            postIsCallSignRepository.Update(entity);

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Позывной с ID {command[0].Trim()} успешно изменён!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }

        private static void UpdateSourceGroup(string inMessage, MessageReceivedEventArgs e)
        {
            var command = inMessage.Split(';');

            var entity = new BotSourceGroup(
                name: command[1].Trim()
                );

            entity.Id = int.Parse(command[0]);

            botSourceGroupRepository.Update(entity);

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = $"Группа источников с ID {command[0].Trim()} успешно изменёна!",
                PeerId = e.Message.PeerId,
                RandomId = Environment.TickCount
            });
        }
    }
}

