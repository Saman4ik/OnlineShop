namespace OnlineShop.Data.Repository;
public class CategoryRepository(AppDbContext dbContext) : Repository<Category>(dbContext), ICategoryInterface { }