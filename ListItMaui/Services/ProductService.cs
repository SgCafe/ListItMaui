using ListIt_Maui.Models;
using SQLite;

namespace ListItMaui.Services;

public class ProductService : IProductService
{
    private SQLiteAsyncConnection _dbConnection;
    
    public async Task InitializeAsync()
    {
        await SetUpDb();
    }

    private async Task SetUpDb()
    {
        if (_dbConnection == null)
        {
            string dbPath = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Product.db3");

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<Product>();
        }
    }

    public async Task<List<Product>> GetAllProducts()
    {
        return await _dbConnection.Table<Product>().ToListAsync();
    }

    public async Task<Product> GetById(int id)
    {
        return await _dbConnection.Table<Product>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> CreateProduct(Product product)
    {
        return await _dbConnection.InsertAsync(product);
    }

    public async Task<int> UpdateProduct(Product product)
    {
        return await _dbConnection.UpdateAsync(product);
    }

    public async Task<int> DeleteProduct(Product product)
    {
        return await _dbConnection.DeleteAsync(product);
    }
}