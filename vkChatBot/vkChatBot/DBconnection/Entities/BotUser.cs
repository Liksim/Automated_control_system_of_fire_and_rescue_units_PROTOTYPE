using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkChatBot.DBconnection.Entities
{
    [Table("bot_users")]
    public class BotUser : Entity
    {
        public string Name { get; set; }

        [Column("peer_id")]
        public long PeerId { get; set; }

        [Column("id_post_is_call_sign")]
        public int IdPostIsCallSign { get; set; }

        [Column("id_source_group")]
        public int IdBotSourceGroup { get; set; }

        public BotUser() { }

        public BotUser(
            string name,
            long peerId,
            int idPostIsCallSign,
            int idBotSourceGroup)
        {
            Name = name;
            PeerId = peerId;
            IdPostIsCallSign = idPostIsCallSign;
            IdBotSourceGroup = idBotSourceGroup;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
