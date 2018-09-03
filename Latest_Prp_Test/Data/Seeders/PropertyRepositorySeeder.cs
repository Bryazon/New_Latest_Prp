using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Authorisation;
using WebApplication7.Data.Entities;
using WebApplication7.Data.Entities.Complex_Types;
using WebApplication7.Data.Entities.EnumTypes;

namespace WebApplication7.Data.Seeders
{
    public class PropertyRepositorySeeder
    {
        private readonly CBContext context;
        private readonly IHostingEnvironment hosting;
        private readonly RoleManager<IdentityRole> roleManager;

        public PropertyRepositorySeeder(CBContext context, IHostingEnvironment hosting, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.hosting = hosting;
            this.roleManager = roleManager;
        }

        public async Task Seed()
        {
            context.Database.EnsureCreated();

            if (!context.Properties.Any())
            {
                SeedProperties();
                await SeedAuthorisation();

                context.SaveChanges();
            }
        }

        private async Task SeedAuthorisation()
        {
            await roleManager.CreateAsync(new IdentityRole("Administrator"));
            var role = await roleManager.FindByNameAsync("Administrator");
            await roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, AuthorisationClaims.TeamClaims.ApproveNewUsers));
        }

        private void SeedProperties()
        {
            SeedProperty(price: 495000, hseName: "Quarry Heath", address1: "Penkridge", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.rightmove.co.uk/dir/crop/10:9-16:9/47k/46853/66792838/46853_27901481_IMG_01_0000_max_656x437.jpg");
            SeedProperty(price: 305500, hseNumber: "10", address1: "Highfields Road", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.rightmove.co.uk/dir/crop/10:9-16:9/90k/89204/56238268/89204_4917471_IMG_25_0000_max_656x437.jpg");
            SeedProperty(price: 375000, hseNumber: "102", address1: "Waterloo Street", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.rightmove.co.uk/dir/crop/10:9-16:9/47k/46853/66792838/46853_27901481_IMG_01_0000_max_656x437.jpg");
            SeedProperty(price: 495000, hseName: "Estate Farm", address1: "Penkridge", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5483004/662008200/image-0-480x320.jpg");
            SeedProperty(price: 515000, hseNumber: "44", address1: "Highfields Road", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5480349/661391613/image-0-480x320.jpg");
            SeedProperty(price: 269500, hseNumber: "51", address1: "High Street", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5479750/661348674/image-0-480x320.jpg");
            SeedProperty(price: 345500, hseName: "The Barns", address1: "Penkridge", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5478370/661188051/image-0-480x320.jpg");
            SeedProperty(price: 215000, hseNumber: "4", address1: "Sunnyside Road", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5472383/660305359/image-0-480x320.jpg");
            SeedProperty(price: 97500, hseNumber: "14", address1: "Brook Lane", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5472384/660305374/image-0-480x320.jpg");
            SeedProperty(price: 495000, hseName: "The Elms", address1: "Penkridge", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5470122/659991029/image-0-480x320.jpg");
            SeedProperty(price: 305500, hseNumber: "10", address1: "Buckingham Road", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5455464/658158208/image-0-480x320.jpg");
            SeedProperty(price: 375000, hseNumber: "102", address1: "Bushmead Avenue", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5444852/656991544/image-0-480x320.jpg");
            SeedProperty(price: 495000, hseName: "Tanglewood", address1: "Penkridge", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5441124/656158051/image-0-480x320.jpg");
            SeedProperty(price: 335000, hseNumber: "11", address1: "Church End Lane", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5440888/656007853/image-0-480x320.jpg");
            SeedProperty(price: 269500, hseNumber: "5", address1: "Mortain Close", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5438745/655553288/image-0-480x320.jpg");
            SeedProperty(price: 345500, hseName: "Yew Tree Cottage", address1: "Penkridge", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5436048/655302728/image-0-480x320.jpg");
            SeedProperty(price: 215000, hseNumber: "71", address1: "Hall End Road", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5435595/655250639/image-0-480x320.jpg");
            SeedProperty(price: 345000, hseNumber: "6", address1: "Mill Road", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5429750/654408854/image-0-480x320.jpg");
            SeedProperty(price: 156500, hseName: "Orchard Cottage", address1: "Pipe hill", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5427657/654097666/image-0-480x320.jpg");
            SeedProperty(price: 115000, hseNumber: "2", address1: "Thorncote Green", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5423249/653460528/image-0-480x320.jpg");
            SeedProperty(price: 97000, hseNumber: "1", address1: "High Street", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5419500/652846447/image-0-480x320.jpg");
            SeedProperty(price: 950000, hseName: "Holly Cottage", address1: "Cannock Wood", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5418473/658234440/image-0-480x320.jpg");
            SeedProperty(price: 445000, hseNumber: "55", address1: "Berkshire Green", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5483338/662125853/image-0-480x320.jpg");
            SeedProperty(price: 989000, hseNumber: "13", address1: "Santa Maria Lane", address2: "Alrewas", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5483339/662128107/image-0-480x320.jpg");
            SeedProperty(price: 765000, hseName: "Hillside", address1: "Towester Road", address2: "Stafford", postcode: "ST15 1PP", title: "Mr", forename: "Craig", surname: "Bryan", picUrl: "https://media.onthemarket.com/properties/5483246/662089136/image-0-480x320.jpg");
            SeedProperty(price: 185000, hseNumber: "1", address1: "Bremen Grove", address2: "Chasetown", address3: "Burntwood", postcode: "WS14 4RP", title: "Mr", forename: "Dan", surname: "Brown", picUrl: "https://media.onthemarket.com/properties/5483240/662086513/image-0-480x320.jpg");
            SeedProperty(price: 155000, hseNumber: "34", address1: "Odell Close", address2: "Kents Hill", address3: "Lichfield", postcode: "WS11 4RR", title: "Mr", forename: "Peter", surname: "Johnson", picUrl: "https://media.onthemarket.com/properties/5483142/662037000/image-0-480x320.jpg");

        }

        private void SeedProperty(decimal price = 0, string hseName = "", string hseNumber = "", string address1 = "", string address2 = "", string address3 = "", string address4 = "", string postcode = "", string title = "", string forename = "", string surname = "", string picUrl = "")
        {
            Property property = new Property()
            {
                Created = DateTime.Now,
                Price = price,
                Status = PropertyStatus.ForSale,
                Address = new Address()
                {
                    HouseName = hseName,
                    HouseNumber = hseNumber,
                    Address1 = address1,
                    Address2 = address2,
                    Address3 = address3,
                    Address4 = address4,
                    PostalCode = postcode,
                }
            };
 

            Contact mainContact = new Contact()
            {
                Created = DateTime.Now,
                Title = title,
                Forename = forename,
                Surname = surname,
                Address = new Address() { }
            };

            context.Properties.Add(property); 
            context.Contacts.Add(mainContact);

            context.PropertyImages.Add(new PropertyImage()
            {
                IsMain = true,
                Property = property,
                Created = DateTime.Now,
                Title = "Main picture",
                URL = picUrl
            });

            context.PropertyContacts.Add(new PropertyContact()
            {
                IsMain = true,
                Property = property,
                Contact = mainContact
            });
        }
    }
}
