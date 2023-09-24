namespace Library.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string PageCount { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
