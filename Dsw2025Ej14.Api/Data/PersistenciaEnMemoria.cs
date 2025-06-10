using Dsw2025Ej14.Api.Domain;
using System.Text.Json;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private List<Product> _products = [];

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }

        public Product GetProduct(String sku)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Product> GetProducts()
        {
            return _products.Where(p => p.IsActive);
        }

        public void LoadProducts()
        {
            var json =  File.ReadAllTextAsync("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive=true,
            }) ??[];
        }

    }
}
