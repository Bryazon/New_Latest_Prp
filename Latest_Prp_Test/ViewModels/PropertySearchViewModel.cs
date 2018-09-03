using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.ViewModels
{
    public class PropertySearchViewModel
    { 
        public AddressViewModel Address { get; set; }
        public ContactViewModel MainVendor { get; set; }
        public ImageViewModel MainImage { get; set; }
        public string Id { get; set; }  
        public decimal Price { get; set; }

    }
 
}
