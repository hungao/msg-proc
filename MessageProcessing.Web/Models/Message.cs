using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageProcessing.Web.Models
{
    public class Message : BaseMessage
    {
        public string Priority { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
    }
}