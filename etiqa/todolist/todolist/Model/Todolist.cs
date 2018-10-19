using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todolist.Model
{
	public class Todolist
	{
		public Guid Id { get; set; }

		public string Item { get; set; }
		  
		public bool Completed { get; set; }
	}
}
