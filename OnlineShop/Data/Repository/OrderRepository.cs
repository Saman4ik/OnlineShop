namespace OnlineShop.Data.Repository;
public class OrderRepository(AppDbContext dbContext) :Repository<Orders>(dbContext), IOrdersInterface { }