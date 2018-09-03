using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.ViewModels
{
    public class ContactViewModel
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }

        #region Complex Types
        public AddressViewModel Address = new AddressViewModel();
        #endregion
    }
}
