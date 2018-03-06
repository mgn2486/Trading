using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Train_To_Trade.Models
{
    public class WhatsAppModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First name is required *")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last name is required *")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Email address is required *")]
        public string emailaddress { get; set; }

        [Required(ErrorMessage = "Whats app cell number is required *")]
        public string whatsAppCell { get; set; }
        
    }
}