﻿using BlazorClassLibrary;

namespace CSharpLaborationQuality.Components.Services
{
    public class TodoService : ITodoService
    {

        private readonly IList<TodoItem> _todoItems;

        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem("Learn C#"),
                new TodoItem("Learn Blazor"),
                new TodoItem("Learn ASP.NET Core")
            };
        }
        
        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }

        public void Complete(TodoItem item)

        {
            item.Completed = true;
        }

        public void Incomplete(TodoItem item)
        {
            item.Completed = false;
        }
    }
}
