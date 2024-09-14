using OtoSatisServis.Data;
using OtoSatisServis.Data.Concrete;
using OtoSatisServis.Service.Abstract;

namespace OtoSatisServis.Service.Concrete
{
    public class CarService : CarRepository , ICarService
    {
        public CarService(DatabaseContext context) : base(context)
        {
        }
    }
}
