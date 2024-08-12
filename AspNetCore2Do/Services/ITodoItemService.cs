using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore2Do.Models;

namespace AspNetCore2Do.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(ApplicationUser user);

        Task<bool> AddItemAsync(TodoItem newItem);

        Task<bool> MarkDoneAsync(Guid id);
    }
}