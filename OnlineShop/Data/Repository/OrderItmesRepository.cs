namespace OnlineShop.Data.Repository;
public class OrderItmesRepository(AppDbContext dbContext) : Repository<OrderItmes>(dbContext), IOrderItmesInterface { }