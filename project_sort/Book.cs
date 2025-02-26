namespace project_sort {
    public class Book : IComparable<Book> {
        string LastName {get; set;}
        string FirstName {get; set;}
        string Title {get; set;}
        DateTime ReleaseDate {get; set;}
        Book book {get; set;}

        Book() {
            book = new();
        }
        public Book Parse(string line) {
            string[] parts = line.Split("|");
            book.LastName = parts[0];
            book.FirstName = parts[1];
            book.Title = parts[2];
            book.ReleaseDate = DateTime.Parse(parts[3]);
            return book;
        }

        public Book TryParse(string line) {

        }
        
    }
}