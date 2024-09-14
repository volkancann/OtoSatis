using Microsoft.EntityFrameworkCore;
using OtoSatisServis.Data.Abstract;
using OtoSatisServis.Entities;
using System.Linq.Expressions;

namespace OtoSatisServis.Data.Concrete
{
    public class UserRepository : Repository<Kullanici> , IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<List<Kullanici>> GetCustomList()
        {
            return await _dbSet.AsNoTracking().Include(x => x.Rol).ToListAsync();
        }

        public async Task<List<Kullanici>> GetCustomList(Expression<Func<Kullanici, bool>> expression)
        {
            return await _dbSet.Where(expression).AsNoTracking().Include(x => x.Rol).ToListAsync();
        }
    }
}
