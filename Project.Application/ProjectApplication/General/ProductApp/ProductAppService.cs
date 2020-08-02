using Abp.AutoMapper;
using Project.Domain;
using Project.Domain.Entities;
using Project.ProjectApplication.General.DTOs.InputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.InputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.OutputModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ProjectApplication.General.ProductApp
{
    public class ProductAppService : AppServiceBase, IProductAppService
    {
        #region Repositories
        private readonly IProductRepository _productRepository;
        #endregion

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetAllProductsOutput> GetAllProducts()
        {
            List<Product> products = await _productRepository.GetAllListAsync();

            return new GetAllProductsOutput
            {
                Products = products.MapTo<List<ProductOutput>>()
            };
        }

        public async Task<GetAllProductsOutput> GetAllActiveProducts()
        {
            List<Product> activeProducts = await _productRepository.GetAllListAsync(x => x.IsActive);

            return new GetAllProductsOutput
            {
                Products = activeProducts.MapTo<List<ProductOutput>>()
            };
        }

        public async Task<ProductOutput> SaveProduct(ProductInput saveProduct)
        {
            Product product;
            if (saveProduct.Id.HasValue)
            {
                product = await _productRepository.GetAsync(saveProduct.Id.Value);
                product = saveProduct.MapTo(product);
                if (saveProduct.IsSet)
                {
                    IEnumerable<SetProductInput> newSetProducts = saveProduct.SetProductsInput.Where(x => !x.Id.HasValue);
                    foreach (SetProductInput newSetProduct in newSetProducts)
                    {
                        product.SetProducts.Add(newSetProduct.MapTo<SetProduct>());
                    }
                }
                await _productRepository.UpdateAsync(product);
            }
            else
            {
                product = saveProduct.MapTo<Product>();
                if (saveProduct.IsSet)
                {
                    product.SetProducts = saveProduct.SetProductsInput.MapTo<List<SetProduct>>();
                }
                await _productRepository.InsertAndGetIdAsync(product);
            }

            return product.MapTo<ProductOutput>();
        }

        public async Task DeleteProduct(IdInput productId)
        {
            await _productRepository.DeleteAsync(productId.Id);
        }
    }
}
