using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HeloModel : PageModel
    {

        public string Message { get; set; }  
        public int Discount { get; set; }
        //HTTPGET
        public void OnGet()
        {
            Message = " ASp.Net Core is Rocking!!";

            Discount = 10;
        }
    }
}
