using Microsoft.EntityFrameworkCore;

namespace Restaurants.Models
{
  public class ToDoListContext : DbContext
  {
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}