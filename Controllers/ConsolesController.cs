using NintendoGameApi.Models;
using NintendoGameApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NintendoGameApi.Controllers{

    [ApiController]
    [Route("[controller]")]

    public class ConsolesController : ControllerBase {
        
        private readonly ConsolesService _consolesService;

        public ConsolesController(ConsolesService consolesService){
            _consolesService = consolesService;
        }
        [HttpGet]
        public ActionResult<List<Console>> Get(){
            return _consolesService.Get();
        }
    }
}