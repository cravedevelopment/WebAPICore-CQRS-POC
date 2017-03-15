using Project.Domain.Interfaces;
using Project.Domain.Models;
using Project.Infra.Data.Context;

namespace Project.Infra.Data.Repository
{
    public class DoorRepository :  Repository<Door>, IDoorRepository
    {
        public DoorRepository(ProjectContext context) : base(context)
        {
        }

        public Customer GetByStatus(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}