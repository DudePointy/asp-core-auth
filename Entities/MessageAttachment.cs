﻿using System;

namespace WebApi.Entities
{
    public class MessageAttachment
    {
        public int Id { get; set; }
        public virtual User Sender { get; set; }
        public int SenderId { get; set; }
        public virtual User Receiver { get; set; }
        public int ReceiverId { get; set; }
        public string FilePath { get; set; }
        public virtual FileType FileType { get; set; }
        public int FileTypeId { get; set; }
        public DateTime SendOn { get; set; }
    }
}