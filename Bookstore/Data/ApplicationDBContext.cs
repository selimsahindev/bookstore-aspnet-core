using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
  class ApplicationDBContext : DbContext
  {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }
  }
}