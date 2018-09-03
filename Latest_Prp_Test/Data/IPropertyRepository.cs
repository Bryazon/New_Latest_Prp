using System.Collections.Generic;
using WebApplication7.Data.Entities;

namespace WebApplication7.Data
{
    public interface IPropertyRepository
    {
        void AddEntity(object model);
        IEnumerable<Property> GetPropertiesBySearchTerm(string searchTerm, int minPrice, int maxPrice);
        bool SaveAll();
    }
}