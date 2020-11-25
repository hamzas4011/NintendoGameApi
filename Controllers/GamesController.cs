using NintendoGameApi.Models;
using NintendoGameApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NintendoGameApi.Controllers{

    [ApiController]
    [Route("[controller]")]

    public class GamesController : ControllerBase {
        
        private readonly GamesService _gamessService;

        public GamesController(GamesService gamesService){
            _gamessService = gamesService;
        }
        [HttpGet]
        public ActionResult<List<Game>> Get(){
            return _gamessService.Get();
        }
    }
}