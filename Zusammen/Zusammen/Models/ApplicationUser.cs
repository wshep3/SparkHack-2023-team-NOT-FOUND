using System;
using Microsoft.AspNetCore.Identity;

namespace Zusammen.Models
{
	public class ApplicationUser : IdentityUser
    {
		public ApplicationUser()
		{

		}

		public enum school_year
		{
			Freshman,
			Sophemore,
			Junior,
			Senior,
			superSenior,
			gradStudent
		}

		public school_year Year { get; set; }
	}
}

