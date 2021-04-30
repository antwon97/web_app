using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace web_app.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}