using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Data.Repository;
public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    public ICategoryInterface Category => new CategoryRepository(dbContext);

    public IImageInterface Image => new ImageRepository(dbContext);

    public IProductInterface Product => new ProductRepository(dbContext);

    public IOrderItmesInterface OrderItmes => new OrderItmesRepository(dbContext);

    public IOrdersInterface Orders => new OrderRepository(dbContext);

    public ISubCategoryInterface SubCategory => new SubCategoryRepository(dbContext);

    public IUserInterface User => new UserRepository(dbContext);
}