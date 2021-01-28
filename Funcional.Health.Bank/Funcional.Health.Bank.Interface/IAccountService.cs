using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Funcional.Health.Bank.Interface
{
	public interface IAccountService
	{
		Task<double> Draw(string numberAccount, string value);
	}
}
