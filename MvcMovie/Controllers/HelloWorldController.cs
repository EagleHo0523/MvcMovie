using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        /**public string Index()
        {
            return "This is my default action...";
        }**/

        //
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;

        public IActionResult Welcome(string name, int numTimes = 1) // https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View(); // Welcome.cshtml
        }
        /** public string Welcome(string name, int ID = 1)  // https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }**/
        /**public string Welcome(string name, int numTimes = 1)    // https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }**/
        /**public string Welcome()  // https://localhost:{PORT}/HelloWorld/Welcome
        {
            return "This is the Welcome action method...";
        }**/
    }
}
