using Funcional.Health.Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcional.Health.Bank.DataAccess.EF
{
	public class FuncionalHealthContext : DbContext
	{
		public FuncionalHealthContext(DbContextOptions<FuncionalHealthContext> options) : base(options){}

		public DbSet<Account> Accounts { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RP27F5V\\SQLEXPRESS;Database=FuncionalHealthTechDatabase;User Id=teste;Password=123456789;");
		}
	}
}
