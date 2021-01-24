using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcional.Health.Bank.Api.Controllers
{
	public class Conta : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
