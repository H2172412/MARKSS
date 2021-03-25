using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SIC43NT_Webserver.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Markss Infotech Limited offers innovative, cost-effective automatic identification solutions for business and industry. Customized Solutions from MARKSS represent the most innovative bar coding products on the market today. We offers complete solutions-hardware, software & service-to help our customers to meet the challenges of dynamic & competitive business environment.";
        }
    }
}
