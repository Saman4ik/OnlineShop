namespace OnlineShop.Data.Repository
{
    public class Repository<Entitiy>(AppDbContext dbContext) : IRepository<Entitiy> where Entitiy : BaseEntitiy
    {
        private readonly AppDbContext _dbContext = dbContext;
        private readonly DbSet<Entitiy> _dbset = dbContext.Set<Entitiy>();
        public void Add(Entitiy entitiy)
        {
            _dbset.Add(entitiy);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entitiy = _dbset.FirstOrDefault(x => x.Id == id);
            _dbset.Remove(entitiy);
            _dbContext.SaveChanges();

        }

        public List<Entitiy> GetAll()
        {
            var list = _dbset.ToList();
            return list;
        }

        public Entitiy GetById(int id)
        {
            var entitiy = _dbset.FirstOrDefault(e => e.Id == id);
            return entitiy;
        }

        public void Update(Entitiy entitiy)
        {
            _dbset.Update(entitiy);
            _dbContext.SaveChanges();
        }
    }
}
