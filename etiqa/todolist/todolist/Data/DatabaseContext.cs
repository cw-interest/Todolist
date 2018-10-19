using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using todolist.Model;

namespace todolist.Data
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Todolist> Todolist { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Filename=etiqa.db"); 

		}
	}
}
