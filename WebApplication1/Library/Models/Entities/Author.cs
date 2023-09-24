using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Library.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }    
        public string Nickname { get; set; }
        public int CountryId { get; set; }
        [ValidateNever]
        public Country Country { get; set; }
        [ValidateNever]
        public List<Book> Books { get; set; }
    }
}
