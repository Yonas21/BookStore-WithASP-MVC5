using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Bookstore.Controllers
{
    public class ContactController : Controller
    {
        // 
        // GET: /Contact/Login/

        public IActionResult Login()
        {
            return View();
        }

        // 
        // GET: /Contact/Signup/ 

        public ActionResult Signup()
        {
            return View();
        }

        // public string showLength(string name, int numberOfTimes = 1){
        //     return HtmlEncoder.Default.Encode($"Hello {name}, Number of Times is {numberOfTimes}");
        // }
    }
}