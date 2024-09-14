using OtoSatisServis.Entities;
using OtoSatisServis.Data.Abstract;


namespace OtoSatisServis.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
