/* using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore2Do.Models;

namespace AspNetCore2Do.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            
            return Task.FromResult(new[] { item1, item2 });
        }
    }
} */