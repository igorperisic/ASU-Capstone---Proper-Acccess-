using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneWebApp.Models;
using JSONParser;

namespace CapstoneWebApp.Controllers
{
    [Route("api/Events/")]
    public class EventController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("GetEvent/{ekey}")]
        public IEnumerable<Event.EventData> GetEvent(string ekey)
        {
            JSONParser.JsonParser jsonParser = new JSONParser.JsonParser();

            return jsonParser.EventKeyParser(ekey).Select(index => new Event.EventData
            {
                _id = index._id,
                ap = index.ap,
                ap_displayName = index.ap_displayName,
                ap_model = index.ap_model,
                ap_name = index.ap_name,
                bytes = index.bytes,
                datetime = index.datetime,
                duration = index.duration,
                hostname = index.hostname,
                is_negative = index.is_negative,
                key = index.key,
                msg = index.msg,
                site_id = index.site_id,
                ssid = index.ssid,
                subsystem = index.subsystem,
                time = index.time,
                user = index.user
            }).ToArray();

        }
    }
}
