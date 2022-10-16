using Domain.Entities;
using Application.Interface.IBox;

namespace Infrastructure.Repository
{
    public class BoxRepository : IBoxRepository
    {
        public Box CreateNewBox(Box box)
        {
            return box;
        }

        public List<Box> GetAllBoxes()
        {
            return new List<Box>()
            {
                new Box(){Id = 1, BoxName="Box 2x4x2", BoxDescription="this is good box", BoxDepth=2, BoxHieght=4, BoxWidth=2, isFolded=false, Price=10},
                new Box(){Id = 2, BoxName="Box 50x10x500", BoxDescription="this is big box", BoxDepth=50, BoxHieght=10, BoxWidth=500, isFolded=true, Price=255},
                new Box(){Id = 3, BoxName="Box 10x10x10", BoxDescription="this is normal box", BoxDepth=10, BoxHieght=10, BoxWidth=10, isFolded=false, Price=100},
                new Box(){Id = 4, BoxName="Box 500x500x500", BoxDescription="this is biggest box", BoxDepth=500, BoxHieght=500, BoxWidth=500, isFolded=false, Price=int.MaxValue},
                new Box(){Id = 5, BoxName="Box 25x3x25", BoxDescription="this is idk box", BoxDepth=25, BoxHieght=3, BoxWidth=25, isFolded=true, Price=20},
            };
        }
    }
}
