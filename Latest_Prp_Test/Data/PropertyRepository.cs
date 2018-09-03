using Microsoft.EntityFrameworkCore; 
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities;

namespace WebApplication7.Data
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly CBContext context;
        private readonly ILogger<PropertyRepository> logger;

        public PropertyRepository(CBContext context, ILogger<PropertyRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public void AddEntity(object model)
        {
            context.Add(model);
        }

        public IEnumerable<Property> GetPropertiesBySearchTerm(string searchTerm, int minPrice, int maxPrice)
        {
            return context.Properties
                                .Where(p => (string.IsNullOrEmpty(searchTerm) || p.Address.Address1.Contains(searchTerm)) && (minPrice == 0 || minPrice <= p.Price) && (maxPrice == 0 || maxPrice >= p.Price))
                                .Include(o => o.Images)
                                .Include(c => c.VendorLinks).ThenInclude(v => v.Contact)
                                .ToList();
        }

        /*
        public IEnumerable<Order> GetAllOrders(bool includeItems)
        {
            if (includeItems)
            {
                return context.Orders
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
            {
                return context.Orders
                    .ToList();
            }
        }

        public IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems)
        {
            if (includeItems)
            {
                return context.Orders
                    .Where(o => o.User.UserName == username)
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
            {
                return context.Orders
                    .Where(o => o.User.UserName == username)
                    .ToList();
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {

            logger.LogInformation("GetAllProducts called");
            return context.Products.OrderBy(p => p.Title).ToList();
            // logger.LogError($"Failed to get all products: {ex}");

        }

        public Order GetOrderById(string username, int id)
        {
            return context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Id == id && o.User.UserName == username)
                .FirstOrDefault();
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return context.Products.Where(p => p.Category == category);
        }*/

        public bool SaveAll()
        {
            return context.SaveChanges() > 0;
        }
    }
}
