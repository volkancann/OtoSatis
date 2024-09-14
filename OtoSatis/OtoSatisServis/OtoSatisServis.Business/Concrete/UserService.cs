using OtoSatisServis.Data;
using OtoSatisServis.Data.Concrete;
using OtoSatisServis.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoSatisServis.Service.Concrete
{
    public class UserService : UserRepository , IUserService
    {
        public UserService(DatabaseContext context) : base(context)
        {
        }
    }
}
