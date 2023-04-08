using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Zusammen.Models
{
    public enum SchoolYear
    {
        Freshman,
        Sophemore,
        Junior,
        Senior,
        [Display(Name = "Super Senior")]
        superSenior,
        [Display(Name = "Graduate Student")]
        gradStudent
    }

    public enum SchoolHousing
    {
        [Display(Name = "Academic and Residential Complex")]
        arc,
        [Display(Name = "Commons North")]
        cn,
        [Display(Name = "Commons West")]
        cw,
        [Display(Name = "Courtyard")]
        cty,
        [Display(Name = "James Stukel Towers")]
        jst,
        [Display(Name = "Marie Robinson Hall")]
        mrh,
        [Display(Name = "Single Student Residence")]
        ssr,
        [Display(Name = "Thomas Bekham Hall")]
        tbh,
        [Display(Name = "Commuter")]
        commuter
    }
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }
        public SchoolYear schoolyear { get; set; }
        public SchoolHousing schoolhousing { get; set; }

    }
            

}

