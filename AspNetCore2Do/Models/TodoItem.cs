using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore2Do.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        [Required]
        public string? Title { get; set; }
        
        public DateTimeOffset? DueAt { get; set; }

        public string UserId { get; set; }
    }
}