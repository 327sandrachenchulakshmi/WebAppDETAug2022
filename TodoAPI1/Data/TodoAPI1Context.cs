using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoAPI1.Data
{
    public class TodoAPI1Context : DbContext
    {
        public TodoAPI1Context (DbContextOptions<TodoAPI1Context> options)
            : base(options)
        {
        }

        public DbSet<TodoApi.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
