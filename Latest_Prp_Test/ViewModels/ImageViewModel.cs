using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.ViewModels
{
    public class ImageViewModel
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    }
}
