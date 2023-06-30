using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VkNet.Enums.SafetyEnums;

namespace vkChatBot.DBconnection.Entities
{
    [Table("post_is_call_sign")]
    public class PostIsCallSign : Entity
    {
        public string Post { get; set; }

        [Column("call_sign")]
        public string CallSign { get; set; }

        public PostIsCallSign() { }
        public PostIsCallSign(
            string post,
            string callSign)
        {
            Post = post;
            CallSign = callSign;
        }

        public override string ToString()
        {
            return CallSign + " - " + Post;
        }
    }
}
