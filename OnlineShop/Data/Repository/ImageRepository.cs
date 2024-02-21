namespace OnlineShop.Data.Repository;
    public class ImageRepository(AppDbContext dbContext) : Repository<Images>(dbContext), IImageInterface { }