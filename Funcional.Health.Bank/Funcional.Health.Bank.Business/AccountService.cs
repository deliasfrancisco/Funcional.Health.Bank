using Funcional.Health.Bank.DataAccess.EF;
using Funcional.Health.Bank.Domain.DTOs;
using Funcional.Health.Bank.Domain.Entities;
using Funcional.Health.Bank.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Funcional.Health.Bank.Business
{
	public class AccountService : IAccountService
	{
		private readonly FuncionalHealthContext _context;
		private readonly IStringLocalizer<AccountService> L;

		public AccountService(FuncionalHealthContext context, IStringLocalizer<AccountService> localizer)
		{
			this._context = context;
			this.L = localizer ?? throw new ArgumentNullException(nameof(localizer));
		}

		public async Task<decimal> Balance(Guid numberAccount)
		{
			var account = new Account();
			try
			{
				account = await _context.Accounts.FirstOrDefaultAsync(c => c.Id == numberAccount) ?? throw new Exception(L["Erro"]) ;
				return account.Balance;
			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro inesperado", ex);
			}
		}

		public async Task<Account> Deposit(OperationDto dto)
		{
			Account account = new Account();
			try
			{
				account = await _context.Accounts.FirstOrDefaultAsync(c => c.Id == dto.NumberAccount) ?? throw new Exception(L["Erro"]);
				account.Balance += dto.Value;
				await _context.SaveChangesAsync();
				return account;

			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro inesperado", ex);
			}
		}

		public async Task<Account> Draw(OperationDto dto)
		{
			Account account = new Account();
			try
			{
				account = await _context.Accounts.FirstOrDefaultAsync(c => c.Id == dto.NumberAccount) ?? throw new Exception(L["Erro"]);

				if(account.Balance >= dto.Value && account.Balance > 0)
					account.Balance -= dto.Value;

				await _context.SaveChangesAsync();
				return account;

			}
			catch (Exception ex)
			{
				throw new Exception("Ocorreu um erro inesperado", ex);
			}
		}
	}
}
