using Rental.Data.Data.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental.Data.Data.Rental
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; } // klucz główny
        
        public string UserID { get; set; } // nadawca
        [ForeignKey("UserID")]
        public ApplicationUser SenderUser { get; set; }

        [Required(ErrorMessage = "Grupa odbiorców jest wymagana")] // grupa odbiorców
        public string UserTypeName { get; set; } 
        //[ForeignKey("UserTypeID")]
        //public ApplicationUser ReceiverUserTypes { get; set; } //zmienic na ROLE~!!

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [StringLength(40, ErrorMessage = "Maksymalnie 40 znaków")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Wiadomosc jest wymagana")]
        public string MessageContent { get; set; }
        
        public bool IsActive { get; set; }
        
        [Required(ErrorMessage = "Data początkowa jest wymagana")]
        public DateTime StartDate { get; set; }
        
        [Required(ErrorMessage = "Data końcowa jest wymagana")]
        public DateTime ExpirationDate { get; set; }
        
        public DateTime AddedDate { get; set; }
        
        public DateTime? UpdatedDate { get; set; }

        //public int? UpdatedUserID { get; set; } // użytkownik modyfikujący
        //[ForeignKey("UpdatedUserID")]
        //public ApplicationUser MessageUpdatedUser { get; set; }

        public ICollection<ReadMessages> ReadMessages { get; set; }
    }
}
