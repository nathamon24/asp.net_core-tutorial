namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } //unique key 
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

    }
}