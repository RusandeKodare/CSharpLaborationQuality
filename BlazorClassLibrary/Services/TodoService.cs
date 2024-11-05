using BlazorClassLibrary;

namespace BlazorClassLibrary.Services
{
    public class TodoService : ITodoService
    {
        public IList<TodoItem> TodoItems;

        public TodoService()
        {
            TodoItems = new List<TodoItem>
            {
                new TodoItem("Learn C#"),
                new TodoItem("Learn Blazor"),
                new TodoItem("Learn ASP.NET Core")
            };
        }
        public void Add(TodoItem item)
        {
            if (!string.IsNullOrEmpty(item.Text))
            {
                TodoItems.Add(item);
            }
        }

        public void Delete(TodoItem item)
        {
            TodoItems.Remove(item);
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
