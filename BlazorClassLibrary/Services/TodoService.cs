using BlazorClassLibrary;

namespace BlazorClassLibrary.Services
{
    public class TodoService : ITodoService
    {
        public List<TodoItem> TodoItems { get; set; } = new(); 

        public TodoService()
        {
           TodoItems = new();
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
            return TodoItems.ToList();
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
