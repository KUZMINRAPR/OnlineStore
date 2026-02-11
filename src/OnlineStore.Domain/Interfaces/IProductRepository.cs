using System.Threading.Tasks;
using OnlineStore.Domain.Entities;
namespace OnlineStore.Domain.Interfaces;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task AddAsync(Product product, CancellationToken cancellationToken = default);
    Task UpdateAsync(Product product, CancellationToken cancellationToken = default);
    Task DeleteAsync(Product product, CancellationToken cancellationToken = default);
}