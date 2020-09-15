using eShopSolution.Application.Catalog.Products.DTOS;
using eShopSolution.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public PagedViewModel<ProductViewModel> getAllCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
