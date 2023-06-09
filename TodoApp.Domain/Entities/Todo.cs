namespace TodoApp.Domain.Entities
{
    public class Todo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ScheduledFor { get; set; }
        public Category Category { get; set; }
        public string CategoryId { get; set; }
    }
}