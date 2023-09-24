using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;

namespace Library.Models.Entities
{
    public class Country
    {
       
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string ShortName { get; set; }

        [ValidateNever]
        public List<Author> Authors { get; set; }
    }
}
