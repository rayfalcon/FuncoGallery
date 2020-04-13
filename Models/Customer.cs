﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncoGallery.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public byte MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
        

    }
}