using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore2Do.Services;
using AspNetCore2Do.Models;

namespace AspNetCore2Do.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync(); // Get to-do items from database

            var model = new TodoViewModel() // Put items into a model
            {
                Items = items
            };

            return View(model); // Pass the view to a model and render
        }
    }
}