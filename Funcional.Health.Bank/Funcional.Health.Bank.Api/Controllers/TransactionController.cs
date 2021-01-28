using Funcional.Health.Bank.Domain.Entities;
using Funcional.Health.Bank.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcional.Health.Bank.Api.Controllers
{
    [ApiController]
	[Route("api/controller")]
	public class TransactionController : ControllerBase
	{
		//private readonly IAccountService _accountService;
		public TransactionController(IAccountService accountService)
		{
			//_accountService = accountService ?? throw new ArgumentNullException(nameof(accountService));
		}

		/// <summary>
		/// Sacar informando o número da conta e um valor válido.
		/// </summary>
		/// <param name="numberAccount">Número da conta</param>
		/// <param name="value">Valor válido</param>
		/// <returns></returns>
		/// <response code="200">Sucesso na operação</response>
		/// <response code="400">Não deu certo</response> 
		public async Task<ActionResult<double>> Draw(string numberAccount, string value)
		{
			//return await _accountService.Draw(numberAccount, value);
			return null;
		}
	}
}
