using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkChatBot.DBconnection.Entities
{
    [Table("bot_source_groups")]
    public class BotSourceGroup : Entity
    {
        public string Name { get; set; }

        public BotSourceGroup() { }
        public BotSourceGroup(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
