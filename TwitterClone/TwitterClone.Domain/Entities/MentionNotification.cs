using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification:Notification
    {
        public Guid MentionByUser { get; private set; } 

        public MentionNotification(Guid mentionByUser) : base(Guid.NewGuid(), "mention", $"User {mentionByUser} mentioned you in a tweet", false)
        {
            this.MentionByUser = mentionByUser;
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }

        public override string GetMessage()
        {
            return $"User with ID {this.MentionByUser} mentioned you in a tweet.";
        }

    }
}
 