using Domain.Entities;
using Application.Interface.IBox;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class BoxRepository : IBoxRepository
    {
        private DbContextOptions<DBContext> _dbContextOptions;
        public BoxRepository()
        {
            _dbContextOptions = new DbContextOptionsBuilder<DBContext>()
                .UseSqlServer("").Options;
        }
        public Box CreateNewBox(Box box)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Boxs.Add(box);
            context.SaveChanges();
            return box;
        }

        public void DeleteBox(Box box)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Boxs.Remove(box);
            context.SaveChanges();
        }

        public List<Box> GetAllBoxes()
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            return context.Boxs.ToList();
        }

        public Box UpdateBox(Box box)
        {
            using var context = new DBContext(_dbContextOptions, Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
            context.Boxs.Update(box);
            context.SaveChanges();
            return box;
        }
    }
}
