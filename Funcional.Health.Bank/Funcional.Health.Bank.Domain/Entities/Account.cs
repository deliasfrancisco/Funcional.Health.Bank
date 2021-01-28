using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcional.Health.Bank.Domain.Entities
{
	public class Account
	{
		public Guid Id { get; set; }
		public double Balance { get; set; }

	}
}
