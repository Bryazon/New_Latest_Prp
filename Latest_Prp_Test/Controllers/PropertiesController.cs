using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data;
using WebApplication7.Data.Entities;
using WebApplication7.ViewModels;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : Controller
    {
        private readonly IPropertyRepository repository;
        private readonly IMapper mapper;

        public PropertiesController(IPropertyRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get(string criteria = "", int minPrice = 0, int maxPrice = 0)
        {
            try
            {
                var properties = repository.GetPropertiesBySearchTerm(criteria, minPrice, maxPrice);

                if (properties != null) { return Ok(mapper.Map<IEnumerable<Property>, IEnumerable<PropertySearchViewModel>>(properties)); }

                else return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest("Bad request: " + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine + (ex.InnerException != null ? ex.InnerException.Message + Environment.NewLine + ex.InnerException.StackTrace : ""));
            }
        }
    }
}
