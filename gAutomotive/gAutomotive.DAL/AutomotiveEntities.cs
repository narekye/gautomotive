using System.Threading.Tasks;

namespace gAutomotive.DAL
{
    public partial class gautomotiveEntities : IAutomotiveEntities
    {
        public new Task SaveChanges()
        {
            return SaveChangesAsync();
        }
    }
}
