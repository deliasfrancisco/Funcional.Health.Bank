using Funcional.Health.Bank.Domain.DTOs;
using Funcional.Health.Bank.Domain.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Funcional.Health.Bank.Interface
{
	public interface IAccountService
	{
		Task<Account> Draw(OperationDto dto);
		Task<Account> Deposit(OperationDto dto);
		Task<decimal> Balance(Guid numberAccount);
	}
}
