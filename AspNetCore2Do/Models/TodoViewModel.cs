namespace AspNetCore2Do.Models
{
    public class TodoViewModel
    {
        public TodoViewModel() // Added lines 5 - 8 to eliminate warnings related to non-nullible properties in the classes.
        {
            Items = Array.Empty<TodoItem>();
        }

        public TodoItem[] Items { get; set; }

        public TodoItem? NewItem { get; set; }
    }
}