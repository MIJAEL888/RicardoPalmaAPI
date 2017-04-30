using CentroOdontologicoBussines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using CentroOdontologicoAPI.Models;
using CentroOdontologicoModel;

namespace CentroOdontologicoAPI.Controllers
{
    public class CitaController : ApiController
    {
        private readonly CitaBl _citaBl = new CitaBl();

        [Route("Api/Cita/{idUsuario}")]
        public IHttpActionResult Get(int idUsuario)
        {
            return Json(_citaBl.List(idUsuario));
        }

        [Route("Api/Cita")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]InCita cita)
        {
            try
            {
                _citaBl.Save(Mapper.Map<Cita>(cita));
                return Json("ok");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [Route("Api/Cita/{idCita}")]
        [HttpPost]
        public IHttpActionResult Anular(int idCita)
        {
            try
            {
                _citaBl.Anular(idCita);
                return Json("ok");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Api/Cita")]
        [HttpPut]
        public IHttpActionResult Put([FromBody]Cita cita)
        {
            try
            {
                _citaBl.Update(cita);
                return Json("ok");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
