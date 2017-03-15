using Project.Domain.Models;

namespace Project.Domain.Interfaces
{
    public interface IDoorRepository : IRepository<Door>
    {
        Customer GetByStatus(string email);
    }
}