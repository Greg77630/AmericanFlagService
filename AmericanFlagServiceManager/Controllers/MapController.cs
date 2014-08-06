using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AmericanFlagServiceManager.Repositories;

namespace AmericanFlagServiceManager.Controllers
{
    public class MapController : ApiController
    {

        // GET: api/Map/5
        public IHttpActionResult Get(int id)
        {
            MapRepository mr = new MapRepository();
            var map = mr.GetByContactId(id);

            return Json(map);
        }
    }
}
