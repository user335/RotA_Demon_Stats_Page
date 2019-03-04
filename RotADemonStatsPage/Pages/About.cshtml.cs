using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RotADemonStatsPage.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Renditions of the Awakening is a first-person RTS game being developed in Unity by user335.";
        }
    }
}
