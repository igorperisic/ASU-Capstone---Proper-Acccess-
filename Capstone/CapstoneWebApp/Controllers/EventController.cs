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

        //        [HttpPost]
        //        public IActionResult ViewDetails()
        //        {
        //            Event.EventData events = new Event.EventData();
        //events.ap_model
        //            ViewBag.Name = cd.Name;
        //            ViewBag.Age = Convert.ToString(cd.Age);
        //            return View("Index");
        //        }

        // POST: api/Events/GetEvent/ekey

        [HttpGet("GetNumber")]
        public int GetNumber()
        {
            return 1;
        }

        [HttpGet("GetEvent/{ekey}")]
        public IEnumerable<Event.EventData> GetEvent(string ekey)
        {
            JSONParser.JsonParser jsonParser = new JSONParser.JsonParser();

            if (ekey == "EVT_WU_Disconnected")
            {
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
            } else
            {
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
}
