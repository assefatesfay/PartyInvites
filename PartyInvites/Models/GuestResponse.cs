using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please Enter Your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage="Please Enter Your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage="Please Choose One Option")]
        public bool? WillAttend { get; set; }
    }
}