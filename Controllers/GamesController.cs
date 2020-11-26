using NintendoGameApi.Models;
using NintendoGameApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NintendoGameApi.Controllers{

    [ApiController]
    [Route("[controller]")]

    public class GamesController : ControllerBase {
        
        private readonly GamesService _gamesService;

        public GamesController(GamesService gamesService){
            _gamesService = gamesService;
        }
        [HttpGet]
        public ActionResult<List<Game>> Get(){
            return _gamesService.Get();
        }
    }
}