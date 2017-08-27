using System.Threading.Tasks;

namespace gAutomotive.DAL.Repository.Core
{
    public class BaseGAutomotiveDAL
    {
        public IAutomotiveEntities Database { get; private set; } = new gautomotiveEntities();
        
        public async Task SaveChanges()
        {
            await Database.SaveChanges();
        }
    }
}
