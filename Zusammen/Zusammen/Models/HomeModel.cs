using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace Zusammen.Models
{
	public class HomeModel
	{

		public List<int> items { get; set; }
		public List<ApplicationUser> appUsers { get; set; }
	}
}

