using MessageProcessing.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessageProcessing.Web.DAL
{
    public class MessageProcessingDataContext  : DbContext
    {
        public MessageProcessingDataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MessageProcessing.Web.Models.Message> Messages { get; set; }

        public System.Data.Entity.DbSet<MessageProcessing.Web.Models.Alert> Alerts { get; set; }

        public System.Data.Entity.DbSet<MessageProcessing.Web.Models.Notification> Notifications { get; set; }
    }
}