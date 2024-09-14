using OtoSatisServis.Data.Concrete;
using OtoSatisServis.Data;
using OtoSatisServis.Entities;
using OtoSatisServis.Service.Abstract;

namespace OtoSatisServis.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {
        }
    }
}
