using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NW.Income.UIServices.Controllers
{
    public class IncomeController : Controller
    {
        // GET: Income
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StaticContent()
        {
            return View();
        }

        public ActionResult DynamicContent()
        {
            List<Questionaire> questionaires;
            using (StreamReader r = new StreamReader(@"C:\Users\loyola_soosai\Desktop\Commerz Bank\NW.Income\NW.Income.UIServices\Models\data.json"))
            {
                string json = r.ReadToEnd();
                questionaires = JsonConvert.DeserializeObject<List<Questionaire>>(json);
            }

            return View(questionaires);
        }

        public ActionResult IntegratedContent()
        {
            using (WebClient webClient = new WebClient())
            {
                var json = webClient.DownloadString("http://localhost:64997/IncomeQuestionnaire");
                var questionaires = JsonConvert.DeserializeObject<List<Questionaire>>(json);
                return View(questionaires);

            }
        }

        public ActionResult DynamicContentApplication(string applicationId)
        {
            List<Questionaire> questionaires;
            using (StreamReader r = new StreamReader(@"C:\Users\loyola_soosai\Desktop\Commerz Bank\NW.Income\NW.Income.UIServices\Models\data.json"))
            {
                string json = r.ReadToEnd();
                questionaires = JsonConvert.DeserializeObject<List<Questionaire>>(json);
            }
            ViewData["applicationId"] = applicationId;
            return View("~/Views/Income/DynamicContentApplication.cshtml", questionaires);
        }
    }
    public class Questionaire
    {

        public int Id { get; set; }
        public string Question { get; set; }
        public IList<string> Answer { get; set; }
    }
}