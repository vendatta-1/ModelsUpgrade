using ModelsUpgrade.Apstractions;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class Repository2<T> : IRepository<T>
        where T : Entity, new()
    {
    }
}
