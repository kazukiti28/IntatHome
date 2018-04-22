﻿using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace intathome.Controllers
{
    public class endTimeController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            var obj = lightController.connectSQL("select * from lightsetting", 0);
            var json = DynamicJson.Parse(obj);
            var endTime = json.end;
            return endTime;
        }
    }
}
