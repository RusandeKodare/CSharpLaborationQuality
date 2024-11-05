namespace BlazorClassLibrary.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);

        public void Delete(TodoItem item);

        public IEnumerable<TodoItem> GetAll();

        public void Complete(TodoItem item);

        public void Incomplete(TodoItem item);
    }
}
