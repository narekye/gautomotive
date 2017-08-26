using System.Threading.Tasks;

namespace gAutomotive.DAL.Repository.Core
{
    public interface IBaseGAutomotive
    {
        IAutomotiveEntities Database { get; set; }
        Task SaveChanges();
    }
}
