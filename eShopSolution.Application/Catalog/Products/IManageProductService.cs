using eShopSolution.Application.Catalog.Products.DTOS;
using eShopSolution.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productId);
        Task<List<ProductViewModel>> getALl();
        Task<List<PagedViewModel<ProductViewModel>>> getAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
