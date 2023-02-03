namespace ForIdentity.Base.Abstract
{
    public interface ICarService<Car>
    {
        void Add(Car item);
        void Update(Car item);
        void Delete(Car item);
        List<Car> GetAll();

        Car GetById(int id);
    }
}
