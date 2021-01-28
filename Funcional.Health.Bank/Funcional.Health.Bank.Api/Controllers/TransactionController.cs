using Funcional.Health.Bank.Domain.DTOs;
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
	[Route("api/transaction")]
	public class TransactionController : ControllerBase
	{
		private readonly IAccountService _accountService;
		public TransactionController(IAccountService accountService)
		{
			_accountService = accountService ?? throw new ArgumentNullException(nameof(accountService));
		}

		/// <summary>
		/// Sacar informando o número da conta e um valor válido.
		/// </summary>
		/// <param name="numberAccount">Número da conta</param>
		/// <param name="value">Valor</param>
		/// <returns></returns>
		/// <response code="200">Sucesso na operação</response>
		/// <response code="400">Não deu certo</response>
		[HttpPost("Draw")]
		public async Task<IActionResult> Draw([FromBody] OperationDto dto)
		{
			return Ok(await _accountService.Draw(dto));
		}

		/// <summary>
		/// Depositar informando o número da conta e um valor válido.
		/// </summary>
		/// <param name="numberAccount">Número da conta</param>
		/// <param name="value">Valor</param>
		/// <returns></returns>
		/// <response code="200">Sucesso na operação</response>
		/// <response code="400">Não deu certo</response>
		[HttpPost("Deposit")]
		public async Task<IActionResult> Deposit([FromBody] OperationDto dto)
		{
			return Ok(await _accountService.Deposit(dto));
		}

		/// <summary>
		/// Informando o saldo número da conta.
		/// </summary>
		/// <param name="numberAccount">Número da conta</param>
		/// <returns></returns>
		/// <response code="200">Sucesso na operação</response>
		/// <response code="400">Não deu certo</response>
		[HttpGet("Balance")]
		public async Task<IActionResult> Balance(Guid NumberAccount)
		{
			return Ok(await _accountService.Balance(NumberAccount));
		}
	}
}
