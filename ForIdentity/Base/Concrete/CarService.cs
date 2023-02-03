using ForIdentity.Base.Abstract;
using ForIdentity.DbContext;
using ForIdentity.Entity;

namespace ForIdentity.Base.Concrete
{
    public class CarService : ICarService<Car>
    {
        private readonly ApplicationDbContext _context;
        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Car item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(Car item)
        {
            _context.Remove(item);
        }

        public List<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return _context.Cars.Find(id);
        }

        public void Update(Car item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

       
    }
}
