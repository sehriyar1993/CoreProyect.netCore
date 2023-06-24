using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitylayerCore.Concrete
{
    public class MessageTwo
    {
        [Key]
        public int MessageId { get; set; }
        public int? Sender { get; set; }
        public int? Receiver { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public Writer SenderUser { get; set; }
        public Writer RecieverUser { get; set; }


        public int? SenderId { get; set; }
        public int? ReceiverID { get; set; }
        public AppUser RecieverAppUser { get; set; }
        public AppUser SenderAppUser { get; set; }

    }
}
