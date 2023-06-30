using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkChatBot.DBconnection.Entities
{
    [Table("subscriptions")]
    public class Subscription : Entity
    {
        [Column("id_bot_user")]
        public int IdBotUser { get; set; }

        [Column("id_source_group")]
        public int IdBotSourceGroup { get; set; }

        public Subscription() { }

        public Subscription(int idBotUser, int idBotSourceGroup)
        {
            IdBotUser = idBotUser;
            IdBotSourceGroup = idBotSourceGroup;
        }
    }
}
