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
            _bot.Start();
            huj();
            Console.WriteLine("Я родился!");
            Console.ReadLine();
        }

        private static void BotOnMessageReceived(object? sender, MessageReceivedEventArgs e)
        {
            var peerId = e.Message.PeerId;

            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = "⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⣿⣿⣿⣷⣤⡀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢀⣾⡿⠋⠀⠿⠇⠉⠻⣿⣄⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢠⣿⠏⠀⠀⠀⠀⠀⠀⠀⠙⣿⣆⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢠⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣆⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢸⣿⡄⠀⠀⠀⢀⣤⣀⠀⠀⠀⠀⣿⡿⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠻⣿⣶⣶⣾⡿⠟⢿⣷⣶⣶⣿⡟⠁⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡏⠉⠁⠀⠀⠀⠀⠉⠉⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⡀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⢀⡇⠀⠀⣿⡇⠀⢀⠀⠀⠀⠀⠀⠀⣿⡇⠀⢸⠀⠀⠀\r\n⠀⠘⡆⠀⠀⠀⣿⡇⠀⠀⢣⠀⠀⠀⢯⡀⣿⡗⢏⠀⠀⢠⠒\r\n⠒⠒⡕⠄⡀⠀⣿⡇⠀⠀⣸⣿⠀⠀⠐⠆⣿⡇⠀⠓⡤⠈⡆\r\n⠀⡸⠀⡄⠈⠁⣿⡇⢀⣴⣿⠇⠀⠴⠀⠀⣿⡇⠉⠁⢀⢠⠃\r\n⠀⠉⠁⢀⣠⣴⣿⣷⣿⠟⠁⠀⠀⠀⠀⠀⣿⣧⣄⡀⠀⠀⠀\r\n⠀⢀⣴⡿⠛⠉⠁⠀⠀⠀⠀⠀⠀⠄⠀⢀⠈⠉⠙⢿⣷⣄⠀\r\n⢠⣿⠏⠀⠀⠄⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣆\r\n⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠐⠀⠀⢹⣿\r\n⣿⣇⠀⠀⠀⠄⠀⠀⢸⣿⡆⠀⠀⠁⠀⠀⠀⡀⠀⠂⠀⢸⣿\r\n⢹⣿⡄⠀⠀⠀⠀⠂⠀⢿⣷⠀⠀⠀⠀⠁⠀⠀⠀⠀⢀⣾⡿\r\n⠀⠻⣿⣦⣀⠁⠀⠀⠀⠈⣿⣷⣄⡀⠀⠀⠀⠀⣀⣤⣾⡟⠁\r\n⠀⠀⠈⠛⠿⣿⣷⣶⣾⡿⠿⠛⠻⢿⣿⣶⣾⣿⠿⠛⠉⠀⠀",
                PeerId = peerId,
                RandomId = Environment.TickCount
            });
        }

        public static void huj()
        {
            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = "⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⣿⣿⣿⣷⣤⡀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢀⣾⡿⠋⠀⠿⠇⠉⠻⣿⣄⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢠⣿⠏⠀⠀⠀⠀⠀⠀⠀⠙⣿⣆⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢠⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣆⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢸⣿⡄⠀⠀⠀⢀⣤⣀⠀⠀⠀⠀⣿⡿⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠻⣿⣶⣶⣾⡿⠟⢿⣷⣶⣶⣿⡟⠁⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡏⠉⠁⠀⠀⠀⠀⠉⠉⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⠀⡀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀\r\n⠀⠀⢀⡇⠀⠀⣿⡇⠀⢀⠀⠀⠀⠀⠀⠀⣿⡇⠀⢸⠀⠀⠀\r\n⠀⠘⡆⠀⠀⠀⣿⡇⠀⠀⢣⠀⠀⠀⢯⡀⣿⡗⢏⠀⠀⢠⠒\r\n⠒⠒⡕⠄⡀⠀⣿⡇⠀⠀⣸⣿⠀⠀⠐⠆⣿⡇⠀⠓⡤⠈⡆\r\n⠀⡸⠀⡄⠈⠁⣿⡇⢀⣴⣿⠇⠀⠴⠀⠀⣿⡇⠉⠁⢀⢠⠃\r\n⠀⠉⠁⢀⣠⣴⣿⣷⣿⠟⠁⠀⠀⠀⠀⠀⣿⣧⣄⡀⠀⠀⠀\r\n⠀⢀⣴⡿⠛⠉⠁⠀⠀⠀⠀⠀⠀⠄⠀⢀⠈⠉⠙⢿⣷⣄⠀\r\n⢠⣿⠏⠀⠀⠄⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣆\r\n⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠐⠀⠀⢹⣿\r\n⣿⣇⠀⠀⠀⠄⠀⠀⢸⣿⡆⠀⠀⠁⠀⠀⠀⡀⠀⠂⠀⢸⣿\r\n⢹⣿⡄⠀⠀⠀⠀⠂⠀⢿⣷⠀⠀⠀⠀⠁⠀⠀⠀⠀⢀⣾⡿\r\n⠀⠻⣿⣦⣀⠁⠀⠀⠀⠈⣿⣷⣄⡀⠀⠀⠀⠀⣀⣤⣾⡟⠁\r\n⠀⠀⠈⠛⠿⣿⣷⣶⣾⡿⠿⠛⠻⢿⣿⣶⣾⣿⠿⠛⠉⠀⠀",
                PeerId = 2000000010,
                RandomId = Environment.TickCount
            });
        }
    }
}

