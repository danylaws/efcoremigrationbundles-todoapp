namespace TodoApp.Domain.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}