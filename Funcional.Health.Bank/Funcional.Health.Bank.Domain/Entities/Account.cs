using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Funcional.Health.Bank.Domain.Entities
{
	public class Account
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }
		public decimal Balance { get; set; }
		public User User { get; set; }
		public string Password { get; set; }

	}
}
