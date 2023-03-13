// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplater.Pages
{
	public class IndexModel : PageModel
	{
		public string Fullname;
		public string LinkedInUsername;
        public int YearsOfExperience;
		public List<string> languages;

        public void OnGet()
		{
			Fullname = "Arthur Lenne";
            LinkedInUsername = "arthur-lenne-216296125";
            YearsOfExperience = 3;
            languages = new List<string> { "C#", "Java", "Python", "HTML", "CSS", "SQL" };
        }
	}
}
