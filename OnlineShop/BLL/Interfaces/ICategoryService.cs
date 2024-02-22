﻿using OnlineShop.BLL.DTOs.CategoryDTOs;

namespace OnlineShop.BLL.Interfaces;
public interface ICategoryService
{
    List<CategoryDto> GetAll();
    CategoryDto GetById(int id);
    void Create(AddCategoryDto categoryDto);
    void Update(AddCategoryDto categoryDto);
    void Delete(int id);
}