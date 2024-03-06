namespace OnlineShop.BLL.Common;

public class PageModel<T>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
    public int TotalItemsCount { get; set; }
    public List<T> Items { get; set; } = new();
    public PageModel(List<T> items, int pageNumber, int pageSize = 10)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(TotalItemsCount / (double)pageSize);
        TotalItemsCount = items.Count;
        Items = items.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
    }
}