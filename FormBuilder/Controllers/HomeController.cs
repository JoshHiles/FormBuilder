using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using FormBuilder.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace FormBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult See()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;

            return View(new FormViewModel { Json = System.IO.File.ReadAllText(webRootPath + "/Form.json") });
        }

        [HttpPost]
        public IActionResult SaveFormData([FromBody]List<Field> json)
        {
            if (json == null)
            {
                return BadRequest();
            }

            string webRootPath = _hostingEnvironment.WebRootPath;
            using (StreamWriter file = System.IO.File.CreateText(webRootPath + "/Form.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, json);
            }

            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
