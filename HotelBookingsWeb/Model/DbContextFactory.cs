using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HotelBookingsWeb.Model
{
    public class AirBnbContextDbContextFactory : IDesignTimeDbContextFactory<AirBnbContext>
    {
        public AirBnbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AirBnbContext>();

            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = AirBnB_Db; Integrated Security = true";

            optionsBuilder.UseSqlServer(connectionString);

            return new AirBnbContext(optionsBuilder.Options);
        }
    }
}