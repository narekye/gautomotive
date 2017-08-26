using System.Threading.Tasks;

namespace gAutomotive.DAL
{
    public partial class AutomotiveEntities : IAutomotiveEntities
    {
        public new Task SaveChanges()
        {
            return SaveChangesAsync();
        }
    }
}
