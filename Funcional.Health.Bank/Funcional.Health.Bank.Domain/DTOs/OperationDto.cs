using System;
using System.Collections.Generic;
using System.Text;

namespace Funcional.Health.Bank.Domain.DTOs
{
	public class OperationDto
	{
		public Guid NumberAccount { get; set; }
		public decimal Value { get; set; }
	}
}
