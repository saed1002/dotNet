﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using holaMundo.Server.Models; 
using holaMundo.Shared;
using Microsoft.EntityFrameworkCore;

namespace holaMundo.Server.Controllers
{
    [Route("specials")]
    [ApiController] 
    public class SpecialsController: ControllerBase{
        private readonly PizzaStoreContext Context; 
        public SpecialsController(PizzaStoreContext context) { this.Context = context; }
        [HttpGet] 
        public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials() { 
            return await Context.Specials.
                OrderByDescending(s => s.BasePrice).ToListAsync(); 
        }
    }
}
