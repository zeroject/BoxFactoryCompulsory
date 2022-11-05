using Application.Interface.IDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class DataBaseRepository : IDataBaseRepository
    {
        private DbContextOptions<DBContext> _opts;

        public DataBaseRepository()
        {
            _opts = new DbContextOptionsBuilder<DBContext>()
                .UseSqlServer("").Options;
        }

        public void RecreateDB()
        {
            using (var context = new DBContext(_opts, ServiceLifetime.Scoped))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
