using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental.Data.Data.Rental
{
    public class ReadMessages
    {
        [Key]
        public int ReadMessagesID { get; set; }

        public int MessageID { get; set; }
        [ForeignKey("MessageID")]
        public Message Message { get; set; }

        public string UserID { get; set; }
    }
}
