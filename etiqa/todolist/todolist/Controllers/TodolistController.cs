using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todolist.Model;
using todolist.Services;

namespace todolist.Controllers
{
	[Route("api/")]
	[ApiController]
	public class TodolistController : ControllerBase
	{
		private readonly ITodolistServices _services;

		public TodolistController(ITodolistServices services)
		{
			_services = services;
		}

		[HttpPost]
		[Route("AddTodolist")]
		public ActionResult<bool> AddTodoitem(Todolist item)
		{
			var success = _services.AddTodoitem(item);
			return success == 1;

		}

		[HttpPost]
		[Route("UpdateTodolist")]
		public ActionResult<bool> Completed(Todolist item)
		{
			var success = _services.Completed(item);
			return success == 1;
		}

		[HttpGet]
		[Route("GetTodolist")]
		public ActionResult<Todolist[]> GetTodoitem()
		{
			var todoitems = _services.GetTodoitem();

			if (todoitems.Length == 0)
			{
				return NotFound();
			}

			return todoitems;
		}	
		
		[HttpDelete]
		[Route("RemoveTodolist")]
		public ActionResult<bool> RemoveTodolistItem(Todolist item)
		{
			var success = _services.RemoveTodoitem(item);
			return success == 1;
		}

	}
}