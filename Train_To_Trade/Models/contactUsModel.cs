using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Train_To_Trade.Models
{
    public class contactUsModel
    {

        [Required(ErrorMessage = "Full name is required *")]
        public string fullName { get; set; }

        [Required(ErrorMessage = "Email address is required *")]
        public string emailaddress { get; set; }
        
        public string contactNumber { get; set; }

        [Required(ErrorMessage = "Please type a valid message *")]
        public string Message { get; set; }
    }
}