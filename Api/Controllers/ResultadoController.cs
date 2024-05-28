using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class ResultadoController : ControllerBase
    {
        private readonly IResultadoService _juegoService;


        public ResultadoController(IResultadoService juegoService)
        {
            _juegoService = juegoService;
        }



    }
}