using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace web_app.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Index()
        {
            /*
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            */

            return Redirect("/Hello/Goodbye");
        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // Handle requests to /Hello/Tim (url segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}