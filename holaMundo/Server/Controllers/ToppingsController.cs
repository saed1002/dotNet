using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using holaMundo.Server.Models;
using holaMundo.Shared;
using Microsoft.EntityFrameworkCore;

namespace holaMundo.Server.Controllers
{
	[Route("toppings")]
	[ApiController]
	public class ToppingsController : ControllerBase
	{
		private readonly PizzaStoreContext Context;
		public ToppingsController(PizzaStoreContext context)
		{
			this.Context = context;
		}
		[HttpGet]
		public async Task<ActionResult<List<Topping>>> GetToppings()
		{
			return await Context.Toppings
			.OrderBy(t => t.Name).ToListAsync();
		}
	}
}
