using OnlineShop.BLL.Common;
using OnlineShop.BLL.DTOs.CategoryDTOs;

namespace OnlineShop.BLL.Services;
public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public void Create(AddCategoryDto categoryDto)
    {
        if (categoryDto == null)
        {
            throw new CaustomException("CategoryDto was null");
        }
        if (string.IsNullOrEmpty(categoryDto.Name))
        {
            throw new CaustomException("Category name is null");
        }
        if (categoryDto.Name.Length < 3 || categoryDto.Name.Length > 30)
        {
            throw new CaustomException("Category name must be between 3 and 30 characters");
        }
        Category category = new()
        {
            Name = categoryDto.Name,
        };
        _unitOfWork.Category.Add(category);
    }

    public void Delete(int id)
    {
        var category = _unitOfWork.Category.GetById(id);
        if (category == null)
        {
            throw new CaustomException("Category not fount");
        }
        _unitOfWork.Category.Delete(category.Id);
    }

    public List<CategoryDto> GetAll()
    {
        var categories = _unitOfWork.Category.GetAll();
        var list = categories.Select(c => new CategoryDto()
        {
            Id = c.Id,
            Name = c.Name
        }).ToList();
        return list;
    }


    public CategoryDto GetById(int id)
    {
        var category = _unitOfWork.Category.GetById(id);
        if (category == null)
        {
            throw new CaustomException("Category not fount");
        }

        var dto = new CategoryDto()
        {
            Id = category.Id,
            Name = category.Name
        };
        return dto;
    }

    public void Update(CategoryDto categoryDto)
    {
        var category = _unitOfWork.Category.GetById(categoryDto.Id);
        if (category == null)
        {
            throw new CaustomException("Category not fount");
        }
        if (string.IsNullOrEmpty(categoryDto.Name))
        {
            throw new CaustomException("Category name is null");
        }
        if (categoryDto.Name.Length < 3 || categoryDto.Name.Length > 30)
        {
            throw new CaustomException("Category name must be between 3 and 30 characters");
        }
        var dto = new Category()
        {
            Id = categoryDto.Id,
            Name = categoryDto.Name
        };
        _unitOfWork.Category.Update(dto);
    }
}
