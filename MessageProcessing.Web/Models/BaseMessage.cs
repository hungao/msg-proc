﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageProcessing.Web.Models
{
    public class BaseMessage
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}