using Rental.Data.Data.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rental.Data.Data.Rental
{
    public class News
    {
        [Key]
        public int NewsID { get; set; }
        
        [Display(Name ="Temat")]
        [MaxLength(20, ErrorMessage = "Tytuł powinien zawierać max 20 znaków")]
        public string Topic { get; set; }
        
        [Display(Name ="Treść")]
        public string NewsContent { get; set; }
        
        [Display(Name ="Autor")]
        public string UserID { get; set; } // nadawca
        [ForeignKey("UserID")]
        public ApplicationUser SenderUser { get; set; }

        public DateTime Create { get; set; }


        

    }
}
