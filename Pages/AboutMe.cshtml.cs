using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages

{
	public class AboutMeModel : PageModel
	{
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Description { get; set; }
		public void OnGet()
		{
			Description = "Hello! I'm Arthur, a software engineer student based in Toulouse, France who enjoys building things that live on the internet. I focus on developing web apps that provide intuitive, user interfaces with efficient and modern backends.";
			Email = "arthur.lenne21@gmail.com";
			Phone = "+33 7 67 52 94 88";
		}
	}
}
