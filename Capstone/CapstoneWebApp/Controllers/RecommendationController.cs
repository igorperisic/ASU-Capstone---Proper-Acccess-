using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneWebApp.Models;
using JSONParser;

namespace CapstoneWebApp.Controllers
{
    [Route("api/Recommendation/")]
    public class RecommendationController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        //array with hostname, ip, satisfaction_now, satisfaction_real, signal
        [HttpGet("GetRecommendation/{hostname}")]
        public IEnumerable<Recommendation.Datum> GetEvent(string hostname)
        {
            JSONParser.JsonParser jsonParser = new JSONParser.JsonParser();

            if (hostname != "")
            {
                return jsonParser.RecommendationParser(hostname).Select(index => new Recommendation.Datum
                {

                    hostname = index.hostname,
                    satisfaction_now = index.satisfaction_now,
                    satisfaction_real = index.satisfaction_real,
                    ip = index.ip,
                    signal = index.signal

                }).ToArray();
            }
            else
            {
                return jsonParser.RecommendationParser(hostname).Select(index => new Recommendation.Datum
                {

                    hostname = index.hostname,
                    satisfaction_now = index.satisfaction_now,
                    satisfaction_real = index.satisfaction_real,
                    ip = index.ip,
                    signal = index.signal

                }).ToArray();
            }
        }
    }
}
