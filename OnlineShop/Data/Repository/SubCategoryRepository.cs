namespace OnlineShop.Data.Repository;
public class SubCategoryRepository(AppDbContext dbContext) : Repository<SubCategorys>(dbContext), ISubCategoryInterface { }