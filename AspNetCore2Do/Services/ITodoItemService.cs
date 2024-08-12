using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore2Do.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCore2Do.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user);

        Task<bool> AddItemAsync(TodoItem newItem, IdentityUser user);

        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
    }
}