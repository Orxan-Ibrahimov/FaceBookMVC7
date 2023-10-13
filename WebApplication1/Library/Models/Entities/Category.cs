using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Library.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ValidateNever]
        public List<Book> Books { get; set; }

    }
}
