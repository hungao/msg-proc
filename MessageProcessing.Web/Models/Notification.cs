using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageProcessing.Web.Models
{
    public enum NotificationType
    {
        Member, Auth, Claim
    }
    public class Notification : BaseMessage
    {
        public NotificationType Type { get; set; }
    }
}