using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore2Do.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        [Required]
        public string? Title { get; set; } // Added "?" to eliminate warnings related to non-nullible properties in the classes.
        
        public DateTimeOffset? DueAt { get; set; }
    }
}