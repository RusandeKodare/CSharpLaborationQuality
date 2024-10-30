namespace CSharpLaborationQuality.Components.Services
{
    public interface ITodoService
    {

        public void Add(TodoItem text);

        public void Delete(TodoItem text);  

        public IEnumerable<TodoItem> GetAll();



    }
}
