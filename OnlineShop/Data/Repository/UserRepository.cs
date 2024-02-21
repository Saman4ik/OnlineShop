namespace OnlineShop.Data.Repository;
public class UserRepository(AppDbContext dbContext) : Repository<Users>(dbContext), IUserInterface { }