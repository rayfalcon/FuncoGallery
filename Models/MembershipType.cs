using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuncoGallery.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Type { get; set; }

        public short Fee { get; set; }
        public byte DiscountRate { get; set; }

    }
}