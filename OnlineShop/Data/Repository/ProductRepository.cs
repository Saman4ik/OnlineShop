namespace OnlineShop.Data.Repository;
public class ProductRepository(AppDbContext dbContext): Repository<Products>(dbContext), IProductInterface { }