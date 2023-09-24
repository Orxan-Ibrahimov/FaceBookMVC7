namespace Library.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Book> Books { get; set; }
    }
}
