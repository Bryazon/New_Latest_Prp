using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities;
using WebApplication7.Data.Entities.Complex_Types;
using WebApplication7.Services.Formatting;
using WebApplication7.ViewModels;

namespace WebApplication7.Data.Mapping
{
    public class PropertyMappingProfile : Profile
    {
        public PropertyMappingProfile()
        { 
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<Contact, ContactViewModel>().ReverseMap();
            CreateMap<PropertyImage, ImageViewModel>().ReverseMap();

            CreateMap<Property, PropertySearchViewModel>()
                .ForMember(a => a.MainVendor, to => to.MapFrom(b => b.VendorLinks.Where(v => v.IsMain).FirstOrDefault().Contact))
                .ForMember(a => a.MainImage, to => to.MapFrom(b => b.Images.Where(i => i.IsMain).FirstOrDefault()));
                
        }
    }

}
