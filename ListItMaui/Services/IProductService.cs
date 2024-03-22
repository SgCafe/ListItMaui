using ListIt_Maui.Models;

namespace ListItMaui.Services;

public interface IProductService
{
    Task InitializeAsync();
    Task<List<Product>> GetAllProducts();
    Task<Product> GetById(int id);
    Task<int> CreateProduct(Product product);
    Task<int> UpdateProduct(Product product);
    Task<int> DeleteProduct(Product product);

}