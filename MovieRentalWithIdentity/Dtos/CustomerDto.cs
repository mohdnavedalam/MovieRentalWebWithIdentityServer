﻿using MovieRentalWithIdentity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalWithIdentity.Dtos
{
    public class CustomerDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter Customer's Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeID { get; set; }
        public MembershipTypeDto membershipType { get; set; }

        //[Display(Name = "Birthdate")]
        //[Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }    
}