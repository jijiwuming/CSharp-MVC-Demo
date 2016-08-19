using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter Your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether Your will attend")]
        public bool? WillAttend { get; set; }
    }
}