﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalWithIdentity.Models
{
    public class Customer
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Please enter Customer's Name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public virtual MembershipType MembershipType { get; set; }
        
        [Display(Name = "Membership Type")]
        public byte MembershipTypeID { get; set; }
        
        [Display(Name = "Birthdate")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }
}