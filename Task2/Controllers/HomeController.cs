using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Task2.Models;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            using (FileStream fs = new FileStream(AppContext.BaseDirectory + "/text.xml", FileMode.Open))
            {
                TextReader reader = new StreamReader(fs);

                XmlSerializer serializer = new XmlSerializer(typeof(XmlList));
                var xmlList = (XmlList)serializer.Deserialize(reader);

                ViewBag.Divisions = new SelectList(xmlList.Divisions, "Id", "Name");
                ViewBag.Positions = new SelectList(xmlList.Positions, "Id", "Name");
            }

            return View(new PersonalData());
        }

        [HttpPost]
        public IActionResult Index(PersonalData personalData)
        {
            var prsList = new List<PersonalData>();
            prsList.Add(personalData);
            prsList.Add(personalData);
            var dasdas = new PersonalDataList()
            {
                PersonalDatas = prsList
            };
        var json = JsonSerializer.Serialize<PersonalDataList>(dasdas);
            System.IO.File.WriteAllText(AppContext.BaseDirectory + "/PersonalDataList.json", json);

            return View();
        }



        [HttpGet]
        public IActionResult New()
        {
            return View("_New");
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
