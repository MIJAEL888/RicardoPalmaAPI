﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CentroOdontologicoBussines;

namespace CentroOdontologicoAPI.Controllers
{
    public class TipoAtencionController : ApiController
    {
        private readonly TipoAtencionBl _tipoAtencionBl = new TipoAtencionBl();

        [Route("Api/TipoAtencion")]
        public IHttpActionResult Get()
        {
            return Json(_tipoAtencionBl.List());
        }
    }
}
