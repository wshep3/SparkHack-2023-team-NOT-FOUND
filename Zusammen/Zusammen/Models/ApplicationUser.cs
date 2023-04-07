using System;
using Microsoft.AspNetCore.Identity;

namespace Zusammen.Models
{
    public enum SchoolYear
    {
        Freshman,
        Sophemore,
        Junior,
        Senior,
        superSenior,
        gradStudent
    }

    public enum SchoolHousing
    {
        arc,
        cn,
        cw,
        cty,
        jst,
        mrh,
        ssr,
        tbh
    }
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }
        public SchoolYear schoolyear { get; set; }
        public SchoolHousing schoolhousing { get; set; }

    }
            

}

