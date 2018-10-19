using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist.Data;
using todolist.Model;

namespace todolist.Services
{
	public class TodolistServices : ITodolistServices
	{
		private readonly Todolist _todoitem;		
		private readonly DatabaseContext _context = new DatabaseContext();

		public TodolistServices()
		{
			
		}

		public TodolistServices(DatabaseContext context, Todolist todoitem)
		{
			_context = context;
			_todoitem = todoitem;
		}

		public int AddTodoitem(Todolist item)
		{
			Todolist items = new Todolist();
			items.Id = Guid.NewGuid();
			items.Completed = false;
			items.Item = item.Item;
			_context.Todolist.Add(item);
			var result = _context.SaveChanges();
			return result;
		}

		public Todolist[] GetTodoitem()
		{
			var items = _context.Todolist
						.Where(x => x.Completed == false)
						.ToArray();
			return items;
		}

		public int Completed(Todolist item)
		{
			var items = _context.Todolist
						.Where(x => x.Id == item.Id)
						.SingleOrDefault();

			if (items == null)
			{
				return 0;
			}
			items.Completed = true;
			var result = _context.SaveChanges();
			return result;
		}

		public int RemoveTodoitem(Todolist todolist)
		{
			var item = _context.Todolist
						.Find(todolist.Id);

			if(item != null)
			{
				_context.Todolist.Remove(item);
				var result = _context.SaveChanges();
				return result;
			}
			return 0;
		}
	}
}
