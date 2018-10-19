using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist.Model;

namespace todolist.Services
{
	public interface ITodolistServices
	{
		int AddTodoitem(Todolist todolist);
		Todolist[] GetTodoitem();
		int Completed(Todolist todolist);
		int RemoveTodoitem(Todolist todolist);
	}
}
