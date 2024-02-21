namespace OnlineShop.Data.Interface;
public interface IRepository<Entitiy> 
{
    List<Entitiy> GetAll();
    Entitiy GetById(int id);
    void Add(Entitiy entitiy);
    void Update(Entitiy entitiy);
    void Delete(int id);
}