namespace BlazorClassLibrary.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);

        public void Delete(TodoItem item);

        public IEnumerable<TodoItem> GetAllIncompleteItems();

        public void Complete(TodoItem item);

        public void Incomplete(TodoItem item);
    }
}
