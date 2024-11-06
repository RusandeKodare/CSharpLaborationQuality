using BlazorClassLibrary;

namespace BlazorClassLibrary.Services
{
    public class TodoService : ITodoService
    {
        public List<TodoItem> IncompleteTodoItems { get; set; } = new();
        public List<TodoItem> CompletedTodoItems { get; set; } = new();

        public TodoService()
        {
           IncompleteTodoItems = new();
            CompletedTodoItems = new();
        }
        public void Add(TodoItem item)
        {
            if (!string.IsNullOrEmpty(item.Text))
            {
                IncompleteTodoItems.Add(item);
            }
        }
        public void Delete(TodoItem item)
        {
            IncompleteTodoItems.Remove(item);
        }

        public IEnumerable<TodoItem> GetAllIncompleteItems()
        {
            return IncompleteTodoItems.ToList();
        }
        public IEnumerable<TodoItem> GetAllCompletedItems()
        {
            return CompletedTodoItems.ToList();
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
