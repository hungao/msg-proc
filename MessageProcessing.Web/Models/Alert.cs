using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageProcessing.Web.Models
{
    public enum AlertType
    {
        Error, Warning, Info
    }
    public class Alert : BaseMessage
    {
        public AlertType Type { get; set; }
    }
}