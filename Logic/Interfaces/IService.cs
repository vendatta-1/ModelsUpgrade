using ModelsUpgrade.Apstractions;

namespace Logic.Interfaces
{
    public interface IService<T, TDto>
        where T : Entity, new()
    {

    }
}
