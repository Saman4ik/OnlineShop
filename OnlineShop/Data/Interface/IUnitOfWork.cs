namespace OnlineShop.Data.Interface;
public interface IUnitOfWork
{
    ICategoryInterface Category { get; }
    IImageInterface Image { get; }
    IProductInterface Product { get; }
    IOrderItmesInterface OrderItmes { get; }
    IOrdersInterface Orders { get; }
    ISubCategoryInterface SubCategory { get; }
    IUserInterface User { get; }
}
