using System.Data.Entity;
using System.Threading.Tasks;

namespace gAutomotive.DAL
{
    public interface IAutomotiveEntities
    {
        DbSet<Customer> Customers { get; set; }
        Task SaveChanges();
    }
}
