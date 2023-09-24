using Library.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.ViewModels
{
    public class AuthorVM
    {
        public Author Author { get; set; }
        public List<Country> Countries { get; set; }
        public List<SelectListItem> CountryList { get; set; }
    }
}
